using Microsoft.AspNetCore.Mvc;

namespace BookSite.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    private readonly ILogger<BookController> _logger;

    public BookController(ILogger<BookController> logger)
    {
        _logger = logger;
    }

    [HttpGet()]
    public Book Get()
    {
        Book returnBook = new Book
        {
            Id = "1",
            Img = "http://books.google.com/books/content?id=t_ZYYXZq4RgC&printsec=frontcover&img=1&zoom=1&edge=curl&source=gbs_api",
            Title = "Mistborn",
            Author = "Brandon Sanderson",
            PageCount = 400,
            Genre = "Fiction",
            Uid = "",
            DateRead = new DateTime(),
            Rating = 4,
        };
        return (returnBook);
    }
}
