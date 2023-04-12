using AutoMapper;
using Ordering.Application.Features.Orders.Queries.GetOrderList;
using Ordering.Domain.Entities;
using Ordering.Application.Features.Orders.Command.CheckoutOrder;
using Ordering.Application.Features.Orders.Command.UpdateOrder;

namespace Ordering.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrdersVm>().ReverseMap();
            CreateMap<Order, CheckoutOrderCommand>().ReverseMap();
            CreateMap<Order, UpdateOrderCommand>().ReverseMap();
        }
    }
}
