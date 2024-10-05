using Simply_Books_BE;
using Simply_Books_BE.Models;
namespace Simply_Books_BE.Data;


public class AuthorData
{
    public static List<Author> Authors = new List<Author>
    {
        new Author
        {
             Id = 1,
             Email = "ta@ta.com",
             First_Name = "Tomi",
             Last_Name = "Adeyemi",
             Image = "https://upload.wikimedia.org/wikipedia/commons/1/17/Tomi_Adeyemi_2020.JPG",
             Favorite = true,
             Uid ="bQ8n51pkphNBlIlN5RPliCL1N7o2",

        },
        new Author
        {
            Id = 2,
            Email = "ba@obama.com",
            First_Name = "Barack",
            Last_Name = "Obama",
            Image = "https://upload.wikimedia.org/wikipedia/commons/8/8d/President_Barack_Obama.jpg",
            Favorite = true,
            Uid = "bQ8n51pkphNBlIlN5RPliCL1N7o2"
        },
        new Author
        {
            Id = 3,
            Email = "hz@zinn.com",
            First_Name = "Howard",
            Last_Name = "Zinn",
            Image = "https://upload.wikimedia.org/wikipedia/commons/e/ef/Howard_Zinn%2C_2009_%28cropped%29.jpg",
            Favorite = false,
            Uid = "bQ8n51pkphNBlIlN5RPliCL1N7o2"
        },
        new Author
        {
            Id = 4,
            Email = "at@thomas.com",
            First_Name = "Angie",
            Last_Name = "Thomas",
            Image = "https://upload.wikimedia.org/wikipedia/commons/a/a1/Angie_thomas_9022008.jpg",
            Favorite = false,
            Uid = "bQ8n51pkphNBlIlN5RPliCL1N7o2"
        },
        new Author
        {
            Id = 5,
            Email = "cw@whithead.com",
            First_Name = "Colson",
            Last_Name = "Whitehead",
            Image = "https://upload.wikimedia.org/wikipedia/commons/5/5c/Colson_Whitehead_BBF_2011_Shankbone.JPG",
            Favorite = false,
            Uid = "bQ8n51pkphNBlIlN5RPliCL1N7o2"
        },
        new Author
        {
            Id = 6,
            Email = "mk@kendall.com",
            First_Name = "Mikki",
            Last_Name = "Kendall",
            Image = "https://upload.wikimedia.org/wikipedia/commons/1/17/Author%2C_activist%2C_and_cultural_critic_Mikki_Kendall.jpg",
            Favorite = true,
            Uid = "bQ8n51pkphNBlIlN5RPliCL1N7o2"
        },
        new Author
        {
            Id = 7,
            Email = "lm@lm.com",
            First_Name = "L.L",
            Last_Name = "McKinney",
            Image = "https://mpd-biblio-authors.imgix.net/200066919.jpg?fit=crop&crop=faces&w=870&h=870",
            Favorite = true,
            Uid = "bQ8n51pkphNBlIlN5RPliCL1N7o2"
        },
        new Author
        {
            Id = 8,
            Email = "jb@baldwin.com",
            First_Name = "James",
            Last_Name = "Baldwin",
            Image = "https://upload.wikimedia.org/wikipedia/commons/3/37/James_Baldwin_33_Allan_Warren.jpg",
            Favorite = false,
            Uid = "bQ8n51pkphNBlIlN5RPliCL1N7o2"
        },

    };
}