using System.Linq;
namespace Store.Memory

{
    public class BookRepository : IBookRepository  
    {
        private readonly Book[] books = new[]
        {
            new Book(1,"ISBN 12312-31231","D. Knuth","Art Of Programming",
                "Книга пидорасная на вид но не скучная внутри пидор сккибиди туалет на ротан давайка мне насри",
                55.3m),

            new Book(2,"ISBN 12312-31232","M. Fowler","Refactoring",
                "Книжка весела ну да просто трахни блять меня", 
                300m),

            new Book(3,"ISBN 12312-31233","B. Kernighan, D. Ritchie","C Programming Language",
                "Книгу эту береги как в трусах мешочек в темноте увидешь беги и спасай хуёчек", 
                25.6m),

        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn)
                        .ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Title.Contains(query)
                                    || book.Author.Contains(query))
                        .ToArray();
        }

        public Book GetById(int id)
        {
            return books.Single(book =>  book.Id == id);
        }
    }
}
