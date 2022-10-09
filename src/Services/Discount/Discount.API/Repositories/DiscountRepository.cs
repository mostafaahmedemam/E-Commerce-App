using Discount.API.Entities;
using System.Threading.Tasks;

namespace Discount.API.Repositories
{
    public class DiscountRepository : IDiscountRepository
    {
        public Task<bool> CreateDiscount(Coupon coupon)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteDiscount(string productName)
        {
            throw new System.NotImplementedException();
        }

        public Task<Coupon> GetDiscount(string productName)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateDiscount(Coupon coupon)
        {
            throw new System.NotImplementedException();
        }
    }
}
