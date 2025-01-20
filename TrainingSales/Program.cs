using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TrainingSales.TrainingManager;

namespace TrainingSales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITrainingService trainingService = new TrainingManager(
                new EfTrainingDal(), new PercentageDiscountCampaignManager());
            var result = trainingService.GetAll();

            foreach (var training in result)
            {
                Console.WriteLine($"{training.Name} = {training.Price}");
            }
        }
    }

    public interface IEntity
    {

    }

    public class Training : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public interface ITrainingDal
    {
        List<Training> GetAll();
    }

    public class EfTrainingDal : ITrainingDal
    {
        public List<Training> GetAll()
        {
            return new List<Training>
            {
                new Training{Id = 1, Name = "PHP", Price = 20000},
                new Training{Id = 2, Name = "Rust", Price = 30000},
                new Training{Id = 3, Name = "R", Price = 25000},
            };
        }
    }

    public interface ITrainingService
    {
        List<Training> GetAll();
    }

    public class TrainingManager : ITrainingService
    {
        private ITrainingDal _trainingDal;
        private ICampaignService _campaignService;

        public TrainingManager(ITrainingDal trainingDal, ICampaignService campaignService)
        {
            _trainingDal = trainingDal;
            _campaignService = campaignService;
        }

        public List<Training> GetAll()
        {
            List<Training> trainings = _trainingDal.GetAll();
            _campaignService.UpdatePrice(trainings);
            return trainings;
        }

        public interface ICampaignService
        {
            void UpdatePrice(List<Training> trainings);
        }

        public class StandardPriceCampaignManager : ICampaignService
        {
            public void UpdatePrice(List<Training> trainings)
            {
                foreach (var training in trainings)
                {
                    training.Price = GetCurrentStandardPrice();
                }
            }

            private decimal GetCurrentStandardPrice()
            {
                // connected to database
                return 10000;
            }
        }

        public class PercentageDiscountCampaignManager : ICampaignService
        {
            public void UpdatePrice(List<Training> trainings)
            {
                foreach (var training in trainings)
                {
                    training.Price = training.Price - (training.Price * GetApplyPercentage());
                }
            }

            private decimal GetApplyPercentage()
            {
                // connected to database
                return Convert.ToDecimal(0.90);
            }
        }
    }
}
