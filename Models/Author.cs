namespace Simply_Books_BE.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? Image {  get; set; }
        public bool Favorite { get; set; }
        public string? Uid { get; set; }
        public List<Book> Books { get; set;}
    }
}
