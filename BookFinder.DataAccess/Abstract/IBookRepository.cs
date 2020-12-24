using BookFinder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookFinder.DataAccess.Abstract
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();
        Book GetBookById(int id);
        Book CreateBook(Book book);
        Book UpdateBook(Book book);
        void DeleteBook(int id);

    }
}
