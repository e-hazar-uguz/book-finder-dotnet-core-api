using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using BookFinder.Entities;
using BookFinder.Business.Abstract;
using BookFinder.Business.Concrete;

namespace BookFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : Controller
    {
        private IBookService _bookservice;

        public BooksController(IBookService bookService)
        {
            _bookservice = bookService;
        }
        [HttpGet("GetAllBooks")]
        public List<Book> GetAllBooks()
        {
            return _bookservice.GetAllBooks();
        }
        [HttpGet("GetBookById")]
        public Book GetBookById(int id)
        {
            return _bookservice.GetBookById(id);
        }
        [HttpPost("AddNewBook")]
        public Book AddNewBook([FromBody] Book book)
        {
            return _bookservice.CreateBook(book);
        }
        [HttpPut("UpdateBook")]
        public Book UpdateBook([FromBody] Book book)
        {
            return _bookservice.UpdateBook(book);
        }

        [HttpDelete("DeleteBookById")]
        public void DeleteBookById(int id)
        {
             _bookservice.DeleteBook(id);
        }
    }
}
