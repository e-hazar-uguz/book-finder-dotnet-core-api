using BookFinder.DataAccess.Abstract;
using BookFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookFinder.DataAccess.Concrete
{
    public class BookRepository : IBookRepository
    {
        public Book CreateBook(Book book)
        {
            using (var bookDbContext = new BookDbContext())
            {
                bookDbContext.Books.Add(book);
                bookDbContext.SaveChanges();
                return book;
            }
        }

        public void DeleteBook(int id)
        {
            using (var bookDbContext = new BookDbContext())
            {
                var deletedBook = GetBookById(id);
                bookDbContext.Books.Remove(deletedBook);
                bookDbContext.SaveChanges();
            }
        }

        public List<Book> GetAllBooks()
        {
            using (var bookDbContext = new BookDbContext())
            {
                return bookDbContext.Books.ToList();
            }
        }

        public Book GetBookById(int id)
        {
            using (var bookDbContext = new BookDbContext())
            {
                return bookDbContext.Books.Find(id);
            }
        }

        public Book UpdateBook(Book book)
        {
            using (var bookDbContext = new BookDbContext())
            {
                bookDbContext.Books.Update(book);
                bookDbContext.SaveChanges();
                return book;

            }
        }
    }
}

