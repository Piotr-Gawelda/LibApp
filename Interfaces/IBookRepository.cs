using System.Collections.Generic;
using System.Threading.Tasks;
using LibApp.Models;
using System;

namespace LibApp.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
        Book GetBookById(int id);
        void AddBook(Book book);
        void DeleteBook(int id);
        void UpdateBook(Book book);
        void Save();
        Task GetByIdAsync(int id);
    }
}
