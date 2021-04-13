namespace TDDSolution
{
    public class Review
    {
        private string comment;
        private int rating;

        public Review(string comment, int rating)
        {
            this.comment = comment;
            this.rating = rating;
        }

        public string Comment { get { return comment; } set { comment = value; } }
        public int Rating { get { return rating; } set { rating = value; } }
    }
}