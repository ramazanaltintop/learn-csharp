using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
    //Online bir eğitim platformu bulunmaktadır.
    //İlk defa eğitim alacak olan öğrencilere ilk eğitimini yarı fiyatına verecektir.
    internal class Program
    {
        static void Main(string[] args)
        {
            LessonBuilder lessonBuilder = new OldStudentLessonBuilder();
            LessonDirector lessonDirector = new LessonDirector(lessonBuilder);
            lessonDirector.Make();

            Lesson lesson = lessonBuilder.GetResult();
            Console.WriteLine($"{lesson.Name} - {lesson.UnitPrice} - {lesson.DiscountedPrice}");
        }
    }
    // Farklı sunumları olan sınıfımız budur.
    class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountedPrice { get; set; }
        public bool DiscountApplied { get; set; }
        public string LessonNote { get; set; }
    }
    //Lesson sınıfına ait nesnenin oluşturulması için soyut arayüz sağlar.
    abstract class LessonBuilder
    {
        public abstract void GetLesson();
        public abstract void ApplyDiscount();
        public abstract void AddLessonNote();
        public abstract Lesson GetResult();
    }
    //LessonBuilder sınıfından türer ve orada tanımlı adımları gerçekleştirir.
    class NewStudentLessonBuilder : LessonBuilder
    {
        // Burada nesne çağırma işlemleri gerçekleştirilmektedir.
        Lesson lesson = new Lesson();
        public override void AddLessonNote()
        {
            lesson.LessonNote = "Your discount code has been applied!...";
        }
        public override void ApplyDiscount()
        {
            lesson.DiscountedPrice = lesson.UnitPrice * (decimal)0.50;
            lesson.DiscountApplied = true;
        }
        public override void GetLesson()
        {
            lesson.Id = 1;
            lesson.Name = "Calculus";
            lesson.UnitPrice = 10000;
        }
        public override Lesson GetResult()
        {
            return lesson;
        }
    }
    //LessonBuilder sınıfından türer ve orada tanımlı adımları gerçekleştirir.
    class OldStudentLessonBuilder : LessonBuilder
    {
        // Burada nesne çağırma işlemleri gerçekleştirilmektedir.
        Lesson lesson = new Lesson();
        public override void AddLessonNote()
        {
            lesson.LessonNote = "";
        }
        public override void ApplyDiscount()
        {
            lesson.DiscountedPrice = lesson.UnitPrice;
            lesson.DiscountApplied = false;

        }
        public override void GetLesson()
        {
            lesson.Id = 1;
            lesson.Name = "Calculus";
            lesson.UnitPrice = 10000;
        }
        public override Lesson GetResult()
        {
            return lesson;
        }
    }
    class LessonDirector
    {
        private LessonBuilder _lessonBuilder;
        public LessonDirector(LessonBuilder lessonBuilder)
        {
            _lessonBuilder = lessonBuilder;
        }
        public void Make()
        {
            _lessonBuilder.GetLesson();
            _lessonBuilder.ApplyDiscount();
            _lessonBuilder.AddLessonNote();
        }
    }
}
