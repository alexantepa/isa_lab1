namespace Book.model
{
    public class Book
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string genre { get; set; }
        public int price { get; set; }

        public override string ToString()
        {
            return $"[{id}] {title} — {author}, \n\tжанр: {genre}, \n\tцена: {price:0.00}";
        }
    }
}
