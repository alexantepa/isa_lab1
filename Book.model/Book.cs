namespace Book.model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"[{Id}] {Title} — {Author}, \n\tжанр: {Genre}, \n\tцена: {Price:0.00}";
        }
    }
}
