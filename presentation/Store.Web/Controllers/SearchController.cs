using Microsoft.AspNetCore.Mvc;

namespace Store.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly BookService bookService;

        public SearchController(BookService bookSerivce)
        {
            this.bookService = bookSerivce;      
        }

        public IActionResult Index(string query)
        {

            var books = bookService.GetAllByQuery(query);

            return View("Index",books);
        } 
    }
}
