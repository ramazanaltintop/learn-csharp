using Business.Abstract;
using Business.Utilities;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;
        private IPersonService _personService;

        public CustomerManager(ICustomerDal customerDal, IPersonService personService)
        {
            _customerDal = customerDal;
            _personService = personService;
        }

        public void Add(Customer customer)
        {
            Utility.Validate(new CustomerValidator(), customer);
            CheckPersonExists(customer);
            CheckCustomerExists(customer);
            _customerDal.Add(customer);
        }
        public void AddByOtherBusiness(Customer customer)
        {
            ValidateFirstNameIfEmpty(customer);
            ValidateLastNameIfEmpty(customer);
            ValidateFirstNameLength(customer);

            CheckCustomerExists(customer);
            _customerDal.Add(customer);
        }

        /// <summary>
        /// Kişi bilgilerinin doğruluğunu kontrol ediyoruz
        /// </summary>
        /// <param name="person">Kişi Bilgisi</param>
        /// <exception cref="Exception"></exception>
        private void CheckPersonExists(Person person)
        {
            if (!_personService.CheckPerson(person))
            {
                throw new Exception("Person information is incorrect.");
            }
        }
        private void CheckCustomerExists(Customer customer)
        {
            if (_customerDal.CustomerExists(customer))
            {
                throw new Exception("Customer already exists.");
            }
        }
        private void ValidateFirstNameIfEmpty(Customer customer)
        {
            if (String.IsNullOrEmpty(customer.FirstName))
            {
                throw new Exception("A validation error occured.");
            }
        }
        private void ValidateLastNameIfEmpty(Customer customer)
        {
            if (String.IsNullOrEmpty(customer.LastName))
            {
                throw new Exception("A validation error occured.");
            }
        }
        private void ValidateIdentityNumberIfEmpty(Customer customer)
        {
            if (String.IsNullOrEmpty(customer.IdentityNumber))
            {
                throw new Exception("A validation error occured.");
            }
        }
        private void ValidateFirstNameLength(Customer customer)
        {
            if (customer.FirstName.Length < 2)
            {
                throw new Exception("A validation error occured.");
            }
        }
    }

}
