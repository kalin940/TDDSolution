using System.Collections.Generic;
using System.Linq;

namespace TDDSolution
{
    public class CD 
    {
        private string title;
        private string artist;
        private int quantity;
        private double price;
        private ReviewManager reviewManager;

        public CD(string title, string artist, double price)
        {
            this.title = title;
            this.artist = artist;
            this.price = price;
        }

        public CD(string title, string artist, int quantity)
        {
            this.title = title;
            this.artist = artist;
            this.quantity = quantity;
        }
        public CD(string title, string artist, int quantity, double price)
        {
            this.title = title;
            this.artist = artist;
            this.quantity = quantity;
            this.price = price;
        }

        public string Artist { get { return artist; } set { artist = value; } }
        public string Title { get { return title; } set { title = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public double Price { get { return price; } set { price = value; } }

        public ReviewManager ReviewManager { get { return reviewManager; } set { reviewManager = value; } }

    }
}