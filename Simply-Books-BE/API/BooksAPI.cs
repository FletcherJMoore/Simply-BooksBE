using Microsoft.EntityFrameworkCore;
using Simply_Books_BE.Models;
namespace Simply_Books_BE.API
{
    public class BooksAPI
    {
        public static void Map(WebApplication app)
        {
            // GET ALL BOOKS
            app.MapGet("/books", (SimplyBooksDbContext db) =>
            {
                return db.Books.Select(b => new
                {
                    Id = b.Id,
                    Title = b.Title,
                    Image = b.Image,
                    Price = b.Price,
                    Sale = b.Sale,
                    AuthorId = b.AuthorId,
                    Uid = b.Uid,
                    Description = b.Description,
                });
            });

            // GET ALL BOOKS BY USER UID
            app.MapGet("/api/books", (SimplyBooksDbContext db, string Uid) =>
            {
                var books = db.Books
                    .Where(b => b.Uid == Uid)
                    .Select(b => new
                    {
                        Id = b.Id,
                        Title = b.Title,
                        Image = b.Image,
                        Price = b.Price,
                        Sale = b.Sale,
                        AuthorId = b.AuthorId,
                        Uid = b.Uid,
                        Description = b.Description,
                    })
                    .ToList();

                return books;
            });

            // GET BOOK DETAILS AND ITS AUTHORS
            app.MapGet("/books/{bookId}", (SimplyBooksDbContext db, int bookId) =>
            {
                Book? book = db.Books
                .Include(b => b.Author)
                .SingleOrDefault(b => b.Id == bookId);

                if (book == null)
                {
                    return Results.NotFound("Invalid Book Id");
                }

                return Results.Ok(new
                {
                    book.Id,
                    book.Title,
                    book.Description,
                    book.Image,
                    book.Price,
                    book.Sale,
                    book.AuthorId,
                    Author = new
                    {
                        book.Author.Email,
                        book.Author.First_Name,
                        book.Author.Last_Name,
                        book.Author.Image
                    },
                });
            });


            //CREATE NEW BOOK
            app.MapPost("/books", (SimplyBooksDbContext db, Book book) =>
            {
                db.Books.Add(book);
                db.SaveChanges();
                return Results.Created($"/books/{book.Id}", book);
            });

            //UPDATE BOOK BY ID
            app.MapPatch("/books/{bookId}", (SimplyBooksDbContext db, Book book, int bookId) =>
            {
                Book bookToUpdate = db.Books.SingleOrDefault(book => book.Id == bookId);
                if (bookToUpdate == null)
                {
                    return Results.NotFound();
                }
                bookToUpdate.Title = book.Title;
                bookToUpdate.Price = book.Price;
                bookToUpdate.Image = book.Image;
                bookToUpdate.Sale = book.Sale;
                bookToUpdate.Description = book.Description;
                bookToUpdate.AuthorId = book.AuthorId;
                db.SaveChanges();
                return Results.NoContent();
            });

            //DELETE BOOK BY ID
            app.MapDelete("/books/{bookId}", (SimplyBooksDbContext db, int bookId) =>
            {
                Book book = db.Books.SingleOrDefault(b => b.Id == bookId);
                if (book == null)
                {
                    return Results.NotFound();
                }
                db.Books.Remove(book);
                db.SaveChanges();
                return Results.NoContent();
            });
        }
    }
}
