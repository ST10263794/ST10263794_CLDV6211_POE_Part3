using System.ComponentModel.DataAnnotations;

namespace ST10263794_CLDV6211_POE_PART2.Models
{
    public class ShoppingCart
    {
        private List<CartItem> items = new List<CartItem>();
        public IReadOnlyList<CartItem> Items => items;
        
        public void AddItem(Product product, int quantity)
        {
            var existingItem = items.FirstOrDefault(i => i.Product.ProductId == product.ProductId);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                items.Add(new CartItem { Product = product, Quantity = quantity });
            }
        }
    }

    public class CartItem
    {
        
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
