using Simply_Books_BE.Models;

namespace Simply_Books_BE.Data
{
    public class BookData
    {
        public static List<Book> Books = new List<Book>
        {
            new Book
            {
                Id = 1,
                AuthorId = 2,
                Description = "",
                Image = "https://images-na.ssl-images-amazon.com/images/I/91+NBrXG-PL.jpg",
                Price = 24.99M,
                Sale = false,
                Title = "A Promise Land",
                Uid = "bQ8n51pkphNBlIlN5RPliCL1N7o2"
            },
            new Book
            {
                Id = 2,
                AuthorId = 1,
                Description = "",
                Image = "https://images-na.ssl-images-amazon.com/images/I/A1agLFsWkOL.jpg",
                Price = 12.99M,
                Sale = true,
                Title = "Children of Blood and Bone",
                Uid = "bQ8n51pkphNBlIlN5RPliCL1N7o2"
            },
             new Book
            {
                Id = 3,
                AuthorId = 3,
                Description = "",
                Image = "https://images-na.ssl-images-amazon.com/images/I/51529Lfc2ML.jpg",
                Price = 30.00M,
                Sale = false,
                Title = "A People's History of the United States of America",
                Uid = "bQ8n51pkphNBlIlN5RPliCL1N7o2"
            },
              new Book
            {
                Id = 4,
                AuthorId = 4,
                Description = "",
                Image = "https://images-na.ssl-images-amazon.com/images/I/81rRRmZZvZL.jpg",
                Price = 15.89M,
                Sale = false,
                Title = "Concrete Rose",
                Uid = "bQ8n51pkphNBlIlN5RPliCL1N7o2"
            },
              new Book
            {
                Id = 5,
                AuthorId = 5,
                Description = "",
                Image = "https://images-na.ssl-images-amazon.com/images/I/A1Cu4ywUeyL.jpg",
                Price = 25.00M,
                Sale = true,
                Title = "The Underground Railroad",
                Uid = "bQ8n51pkphNBlIlN5RPliCL1N7o2"
            },
               new Book
            {
                Id = 6,
                AuthorId = 6,
                Description = "this is a book",
                Image = "https://res.cloudinary.com/bloomsbury-atlas/image/upload/w_360,c_scale/jackets/9781526622402.jpg",
                Price = 50.00M,
                Sale = true,
                Title = "Hood Feminism",
                Uid = "bQ8n51pkphNBlIlN5RPliCL1N7o2"
            },
                 new Book
            {
                Id = 7,
                AuthorId = 7,
                Description = "",
                Image = "https://images-na.ssl-images-amazon.com/images/I/81Uf1dTjfQL.jpg",
                Price = 15.00M,
                Sale = false,
                Title = "A Blade So Black",
                Uid = "bQ8n51pkphNBlIlN5RPliCL1N7o2"
            },
                  new Book
            {
                Id = 8,
                AuthorId     = 7,
                Description = "",
                Image = "https://m.media-amazon.com/images/I/51BZdlchEsL.jpg",
                Price = 14.99M,
                Sale = false,
                Title = "A Dream So Dark",
                Uid = "bQ8n51pkphNBlIlN5RPliCL1N7o2"
            },
                   new Book
            {
                Id = 9,
                AuthorId = 8,
                Description = "",
                Image = "https://images-na.ssl-images-amazon.com/images/I/61GSqXVhhKL.jpg",
                Price = 12.00M,
                Sale = false,
                Title = "The Fire Next Time",
                Uid = "bQ8n51pkphNBlIlN5RPliCL1N7o2"
            },


        };
    }
}
