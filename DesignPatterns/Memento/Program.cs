﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book
            {
                Isbn = "1",
                Title = "Ecce Homo",
                Author = "Friedrich Nietzsche"
            };
            book.ShowBook();

            CareTaker history = new CareTaker();
            history.Memento = book.CreateUndo();

            book.Isbn = "2";
            book.Title = "Varoluşçu Psikoterapi";
            book.Author = "Irvin Yalom";
            book.ShowBook();

            book.RestoreFromUndo(history.Memento);
            book.ShowBook();
        }
    }
    class Book
    {
        private string _title;
        private string _author;
        private string _isbn;
        private DateTime _lastEdited;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                SetLastEdited();
            }
        }
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
                SetLastEdited();
            }
        }
        public string Isbn
        {
            get
            {
                return _isbn;
            }
            set
            {
                _isbn = value;
                SetLastEdited();
            }
        }
        private void SetLastEdited()
        {
            _lastEdited = DateTime.UtcNow;
        }
        public Memento CreateUndo()
        {
            return new Memento(_title, _author, _isbn, _lastEdited);
        }
        public void RestoreFromUndo(Memento memento)
        {
            _title = memento.Title;
            _author = memento.Author;
            _isbn = memento.Isbn;
            _lastEdited = memento.LastEdited;
        }
        public void ShowBook()
        {
            Console.WriteLine("{0}, {1}, {2} edited : {3}", Title, Author, Isbn, _lastEdited);
        }
    }
    class Memento
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public DateTime LastEdited { get; set; }

        public Memento(string title, string author, string isbn, DateTime lastEdited)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
            LastEdited = lastEdited;
        }
    }
    class CareTaker
    {
        public Memento Memento { get; set; }
    }
}
