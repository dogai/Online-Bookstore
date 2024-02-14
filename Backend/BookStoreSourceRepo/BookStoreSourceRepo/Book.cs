using System;

namespace BookStoreSourceRepo
{
    public class Book
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        public string ImagePath { get; set; }

        public decimal Price { get; set; }

        public string Publisher { get; set; }


        public Book(string name, string description, string author, string imagePath, decimal price, string publisher){

            this.Name = name;
            this.Description = description;
            this.Author = author;
            this.ImagePath = imagePath;
            this.Price = price;
            this.Publisher = publisher;


            }

    }
}
