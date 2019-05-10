using ImplementationFactoryExample.Web.Models;

namespace ImplementationFactoryExample.Web.Services.Contracts
{
    public interface IDiscountProcessor
    {
        double ProcessDiscount(OrderViewModel order);
    }
}
