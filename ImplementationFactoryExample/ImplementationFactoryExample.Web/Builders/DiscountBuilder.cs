using ImplementationFactoryExample.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationFactoryExample.Web.Builders
{
    public class DiscountBuilder
    {
        private Discount _discount = new Discount();

        public DiscountBuilder WithMinimumItemCount(int count)
        {
            _discount.MinimumItemCount = count;
            return this;
        }

        public DiscountBuilder WithMinimumBillAmount(double amount)
        {
            _discount.MinimumBillAmount = amount;
            return this;
        }

        public DiscountBuilder WithPercentage(double percentage)
        {
            _discount.Percentage = percentage;
            return this;
        }

        public DiscountBuilder WithDefaults()
        {
            _discount = new Discount
            {
                MinimumBillAmount = 1000,
                MinimumItemCount = 3,
                Percentage = 5
            };
            
            return this;
        }

        public Discount Build()
        {
            return _discount;
        }
    }
}
