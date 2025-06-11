using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Domain.Products
{
    public class Product
    {
        [Required]
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public int Price { get; private set; }

        public Product(string title, int price)
        {
            Guard(title, price);
            Title = title;
            Price = price;
        }

        public void Edit(string title, int price)
        {
            Guard(title, price);
            Title = title;
            Price = price;
        }


        private void Guard(string title, int price)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentNullException("Title");

            if (price < 0)
                throw new ArgumentOutOfRangeException();

        }

    }



}
