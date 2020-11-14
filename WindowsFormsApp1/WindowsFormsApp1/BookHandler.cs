﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class BookHandler: QueryObject
    {
        public List<Book> books { get; protected set; }
        public Book filterBook { get; set; }
        public Book newBook { get; set; }
        public Book deleteBook { get; set; }
        public Book currentBook { get; set; }
        public void getBookswithFilter()
        {
            books = getWhere(filterBook, "Books");
        }
        public void insertNewBook()
        {
            insertObject(newBook, "Books");
        }
        public void deleteOldBook()
        {
            deleteObject(deleteBook, "Books");
        }
        public void updateBook()
        {
            updateObject(currentBook, newBook, "Books");
        }
    }
}
