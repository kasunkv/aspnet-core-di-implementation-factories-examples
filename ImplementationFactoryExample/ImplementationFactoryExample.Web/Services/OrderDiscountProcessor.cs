using ImplementationFactoryExample.Web.Models;
using ImplementationFactoryExample.Web.Services.Contracts;

namespace ImplementationFactoryExample.Web.Services
{
    public class OrderDiscountProcessor : IDiscountProcessor
    {
        private readonly Discount _discount;

        public OrderDiscountProcessor(Discount discount)
        {
            _discount = discount;
        }

        public double ProcessDiscount(OrderViewModel order)
        {
            double discount = 0.0;
            double totalBill = order.Quantity * order.Price;

            if (order.Quantity >= _discount.MinimumItemCount && totalBill >= _discount.MinimumBillAmount)
            {
                discount = (totalBill * _discount.Percentage) / 100.0;
            }

            return discount;
        }
    }
}
