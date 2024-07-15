using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Library.Controllers
{
    [Route("api/([controller])")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly DataContext _context;
        public BookController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<List<Book>>> CreateBook(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            
            return Ok(book);
        }

        [HttpGet]

        public async Task<ActionResult<List<Book>>> GetBook()
        {
            return Ok(await _context.Books.ToListAsync());
        }
       

    }
}
