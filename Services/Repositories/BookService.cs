using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LibraryCMS.Models;

namespace LibraryCMS.Services.Repositories
{
    public class BookService
    {
        private readonly IDataService<Book> _bookService;

        public IQueryable<Book> FindBooksByAuthor(string author)
        {
            return _bookService
                .GetAll()
                .Where(book =>
                   book.BookAuthor.LastName.Contains(author) || book.BookAuthor.LastName.Contains(author)
                );
        }

        public void CreateBook()
        {
            _bookService.Create(new Book());
        }

        public IQueryable<Book> GetAllBooks(int offset, int count)
        {
            return _bookService.GetAll().Skip(offset).Take(count);
        }
        public BookService(IDataService<Book> bookService)
        {
            _bookService = bookService;
        }
    }
}