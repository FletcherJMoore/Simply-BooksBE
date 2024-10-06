using Microsoft.EntityFrameworkCore;
using Simply_Books_BE.Data;
using Simply_Books_BE.Models;

namespace Simply_Books_BE.API
{
    public class AuthorsAPI
    {
        public static void Map(WebApplication app)
        {
            // GET ALL AUTHORS
            app.MapGet("/authors", (SimplyBooksDbContext db) =>
            {
                return db.Authors.Select(a => new
                {
                    Id = a.Id,
                    First_Name = a.First_Name,
                    Last_Name = a.Last_Name,
                    Email = a.Email,
                    Favorite = a.Favorite,
                    Image = a.Image,
                    Uid = a.Uid,
                });
            });

            // GET ALL AUTHORS BY USER UID
            app.MapGet("/api/authors", (SimplyBooksDbContext db, string Uid) =>
            {
                var authors = db.Authors
                    .Where(a => a.Uid == Uid)
                    .Select(a => new
                    {
                        Id = a.Id,
                        First_Name = a.First_Name,
                        Last_Name = a.Last_Name,
                        Email = a.Email,
                        Favorite = a.Favorite,
                        Image = a.Image,
                        Uid = a.Uid,
                    })
                    .ToList();

                return authors;
            });

            // GET AUTHOR DETAILS AND ACCOCIATED BOOKS
            app.MapGet("/authors/{authorId}", (SimplyBooksDbContext db, int authorId) =>
            {
                Author author = db.Authors
                .Include(b => b.Books)
                .SingleOrDefault(b => b.Id == authorId);

                if (author == null)
                {
                    return Results.NotFound("Author not found. Please enter a valid author Id");
                }

                return Results.Ok(new
                {
                    author.Id,
                    author.First_Name,
                    author.Last_Name,
                    author.Image,
                    Books = author.Books.Select(book => new
                    {
                        book.Id,
                        book.Title,
                        book.Image,
                        book.Description,
                        book.Price,
                        book.Sale,
                        book.AuthorId,
                        book.Uid,
                    }),
                });
            });

                //CREATE NEW AUTHOR
                app.MapPost("/authors", (SimplyBooksDbContext db, Author author) =>
                {
                    db.Authors.Add(author);
                    db.SaveChanges();
                    return Results.Created($"/author/{author.Id}", author);
                });

                //UPDATE AUTHOR BY ID
                app.MapPut("/authors/{authorId}", (SimplyBooksDbContext db, Author author, int authorId) =>
                {
                    Author authorToUpdate = db.Authors.SingleOrDefault(author => author.Id == authorId);
                    if (authorToUpdate == null)
                    {
                        return Results.NotFound();
                    }
                    authorToUpdate.First_Name = author.First_Name;
                    authorToUpdate.Last_Name = author.Last_Name;
                    authorToUpdate.Image = author.Image;
                    authorToUpdate.Favorite = author.Favorite;
                    authorToUpdate.Email = author.Email;
                    db.SaveChanges();
                    return Results.Ok(authorToUpdate);
                });

                //DELETE AUTHOR BY ID
                app.MapDelete("/authors/{authorId}", (SimplyBooksDbContext db, int authorId) =>
                {
                    Author author = db.Authors.SingleOrDefault(a => a.Id == authorId);
                    if (author == null)
                    {
                        return Results.NotFound();
                    }
                    db.Authors.Remove(author);
                    db.SaveChanges();
                    return Results.NoContent();
                });
            }
          
    }
}
