﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace _3rdYearProject.Models
{
    public class BookInitializer : DropCreateDatabaseIfModelChanges<BookDBContext>
    {
        protected override void Seed(BookDBContext context)
        {
            var books = new List<Book> {  
                    
                new Book {ISBN= "120SS", Title = "The Son",   
                             Author = "Jo Nesbo",   
                             Genre="Crime Fiction", Publisher="Harvill Secker", PublishDate=DateTime.Parse("2014-04-10"), numCopies = 1, format="Paperback", OnShelf = true, OnLoan = false},        

                new Book { ISBN= "122BB", Title = "Divergent",   
                             Author = "Veronica Roth",   
                             Genre="Sci-fi & Fantasy", Publisher="HarperCollins Publishers LLC", PublishDate=DateTime.Parse("2011-04-25"), numCopies = 1, format="Paperback", OnShelf = false, OnLoan = true },  
                
                 new Book { ISBN= "123BB", Title = "Insurgent",   
                             Author = "Veronica Roth",   
                             Genre="Sci-fi & Fantasy", Publisher="HarperCollins Publishers LLC", PublishDate=DateTime.Parse("2012-05-01"), numCopies = 1, format="Paperback", OnShelf = false, OnLoan = true },  

                 new Book { ISBN= "124BB", Title = "Allegiant",   
                             Author = "Veronica Roth",   
                             Genre="Sci-fi & Fantasy", Publisher="HarperCollins Publishers LLC", PublishDate=DateTime.Parse("2013-10-22"), numCopies = 1, format="Paperback", OnShelf = false, OnLoan = true },

                 new Book { ISBN= "131AB", Title = "Harry Potter and the Philosopher's Stone",   
                             Author = "J. K. Rowling",   
                             Genre="Kids & Family", Publisher="Bloomsbury Publishing", PublishDate=DateTime.Parse("1997-06-26"), numCopies = 1, format="Paperback", OnShelf = true, OnLoan = false }, 
                             
                  new Book { ISBN= "132AB", Title = "Harry Potter and the Chamber of Secrets",   
                             Author = "J. K. Rowling",   
                             Genre="Kids & Family", Publisher="Bloomsbury Publishing", PublishDate=DateTime.Parse("1998-07-02"), numCopies = 1, format="Paperback", OnShelf = true, OnLoan = false },  

                  new Book { ISBN= "133AB", Title = "Harry Potter and the Prisoner of Azkaban",   
                             Author = "J. K. Rowling",   
                             Genre="Kids & Family", Publisher="Bloomsbury Publishing", PublishDate=DateTime.Parse("1999-07-08"), numCopies = 1, format="Paperback", OnShelf = true, OnLoan = false },

                 new Book { ISBN= "133AB", Title = "Harry Potter and the Goblet of Fire",   
                             Author = "J. K. Rowling",   
                             Genre="Kids & Family", Publisher="Bloomsbury Publishing", PublishDate=DateTime.Parse("2000-07-08"), numCopies = 1, format="Paperback", OnShelf = true, OnLoan = false },

                 new Book { ISBN= "133AB", Title = "Harry Potter and the Order of the Phoenix",   
                             Author = "J. K. Rowling",   
                             Genre="Kids & Family", Publisher="Bloomsbury Publishing", PublishDate=DateTime.Parse("2003-06-21"), numCopies = 1, format="Paperback", OnShelf = true, OnLoan = false },

                 new Book { ISBN= "133AB", Title = "Harry Potter and the Half-Blood Prince",   
                             Author = "J. K. Rowling",   
                             Genre="Kids & Family", Publisher="Bloomsbury Publishing", PublishDate=DateTime.Parse("2005-07-16"), numCopies = 1, format="Paperback", OnShelf = true, OnLoan = false },

                 new Book { ISBN= "133AB", Title = "Harry Potter and the Deathly Hallows",   
                             Author = "J. K. Rowling",   
                             Genre="Kids & Family", Publisher="Bloomsbury Publishing", PublishDate=DateTime.Parse("2007-07-21"), numCopies = 1, format="Paperback", OnShelf = true, OnLoan = false },

                  new Book { ISBN= "175BD", Title = "The Hunger Games",   
                             Author = "Suzanne Collins",   
                             Genre="Adventure", Publisher="Scholastic", PublishDate=DateTime.Parse("2008-09-14"), numCopies = 1, format="Paperback", OnShelf = true, OnLoan = false},    
                     
                  new Book { ISBN= "176BD", Title = "The Hunger Games: Catching Fire",   
                             Author = "Suzanne Collins",   
                             Genre="Adventure", Publisher="Scholastic", PublishDate=DateTime.Parse("2009-09-01"), numCopies = 1, format="Paperback", OnShelf = false, OnLoan = true},

                  new Book { ISBN= "177BD", Title = "The Hunger Games: Mockingjay",   
                             Author = "Suzanne Collins",   
                             Genre="Adventure", Publisher="Scholastic", PublishDate=DateTime.Parse("2010-08-24"), numCopies = 1, format="Paperback", OnShelf = true, OnLoan = false},

                  new Book { ISBN= "194FC", Title = "Fifty Shades of Grey",   
                             Author = "E. L. James",   
                             Genre="Romance", Publisher="Random House", PublishDate=DateTime.Parse("2011-06-20"), numCopies = 0, format="Paperback", OnShelf = false, OnLoan = false}, 

                  new Book {ISBN= "219TI", Title = "Twilight",   
                             Author = "Stephenie Meyer",   
                             Genre="Romance", Publisher="Little, Brown and Company", PublishDate=DateTime.Parse("2005-10-05"), numCopies = 1, format="Paperback", OnShelf = true, OnLoan = false},  

                new Book {ISBN= "220BT", Title = "The Book Thief",   
                             Author = "Markus Zusak",   
                             Genre="Novel-Historical Fiction", Publisher="Alfred A. Knopf, Inc.", PublishDate=DateTime.Parse("2006-03-14"), numCopies = 1, format="Paperback", OnShelf = false, OnLoan = true},
            };

            books.ForEach(d => context.Books.Add(d));
        }
    }
}