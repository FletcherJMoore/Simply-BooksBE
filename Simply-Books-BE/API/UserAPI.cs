using Simply_Books_BE.Data;
using Simply_Books_BE.Models;
namespace Simply_Books_BE.API
{
    public class UserAPI
    {
        public static void Map(WebApplication app)
        {
            app.MapPost("/checkUser", (SimplyBooksDbContext db, string uid) =>
            {
                var user = db.Users
                  .Where(u => u.Uid == uid)
                  .FirstOrDefault();

                if (user == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(user);
            });
        }
    }
}
