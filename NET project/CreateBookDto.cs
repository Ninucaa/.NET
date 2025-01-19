namespace BookstoreAPI.Dtos
{
    public class CreateBookDto
    {
        public string Title { get; set; }
        public int YearOfPublication { get; set; }
        public string AuthorName { get; set; }
    }
}