using BookFinder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookFinder.Business.Abstract
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        Book GetBookById(int id);
        Book CreateBook(Book book);
        Book UpdateBook(Book book);
        void DeleteBook(int id);
       
    }
}
