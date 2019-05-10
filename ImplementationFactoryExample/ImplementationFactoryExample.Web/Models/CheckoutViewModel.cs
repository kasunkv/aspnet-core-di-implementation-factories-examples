using System.ComponentModel.DataAnnotations;

namespace ImplementationFactoryExample.Web.Models
{
    public class CheckoutViewModel
    {
        [Display(Name = "Item")]
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
        public double SubTotal { get; set; }
        public double Total { get; set; }

        public CheckoutViewModel(OrderViewModel order, double discount)
        {
            ItemName = order.ItemName;
            Quantity = order.Quantity;
            Discount = discount;
            SubTotal = order.Price * order.Quantity;
            Total = SubTotal - Discount;
        }

        public CheckoutViewModel() { }
    }
}
