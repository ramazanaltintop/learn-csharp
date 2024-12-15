using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();
            Teacher teacher = new Teacher(mediator);
            teacher.FirstName = "Ramazan";
            mediator.Teacher = teacher;

            Student student = new Student(mediator);
            student.FirstName = "John";
            Student student2 = new Student(mediator);
            student2.FirstName = "Jack";

            mediator.Students = new List<Student> { student, student2 };

            teacher.SendNewImageUrl("slide1.jpg");
            student2.SendQuestion("I dont understant this subject", student2);
        }
    }
    abstract class CourseMember
    {
        protected Mediator Mediator;

        protected CourseMember(Mediator mediator)
        {
            Mediator = mediator;
        }
    }
    class Teacher : CourseMember
    {
        public string FirstName { get; set; }
        public Teacher(Mediator mediator) : base(mediator)
        {
        }

        public void ReceiveQuestion(string question, Student student)
        {
            Console.WriteLine("Teacher received question from {0}: {1}", student.FirstName, question);
        }

        public void SendNewImageUrl(string url)
        {
            Console.WriteLine("Teacher changed slide : {0}", url);
            Mediator.UpdateImage(url);
        }

        public void AnswerQuestion(string answer, Student student)
        {
            Console.WriteLine("Teacher answered question {0} : {1}", student.FirstName, answer);
        }
    }
    class Student : CourseMember
    {
        public string FirstName { get; set; }

        public Student(Mediator mediator) : base(mediator)
        {
        }

        public void ReceiveImage(string url)
        {
            Console.WriteLine("{1} received image : {0}", url, FirstName);
        }

        public void ReceiveAnswer(string answer)
        {
            Console.WriteLine("Student received answer : {0}", answer);
        }

        public void SendQuestion(string question, Student student)
        {
            Console.WriteLine("Student send question : {0}", question);
            Mediator.SendQuestion(question, student);
        }
    }
    class Mediator
    {
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }
        public void UpdateImage(string url)
        {
            foreach (var student in Students)
            {
                student.ReceiveImage(url);
            }
        }
        public void SendQuestion(string question, Student student)
        {
            Teacher.ReceiveQuestion(question, student);
        }
        public void SendAnswer(string answer, Student student)
        {
            student.ReceiveAnswer(answer);
        }
    }
}
