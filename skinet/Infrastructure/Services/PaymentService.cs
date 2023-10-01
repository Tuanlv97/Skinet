using Core.Entities;
using Core.Entities.OrderAggregate;
using Core.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBasketRepository _basketRepository;
        private readonly IConfiguration _config;
        public PaymentService(IUnitOfWork unitOfWork, IBasketRepository basketRepository,
            IConfiguration config)
        {
            _config = config;
            _basketRepository = basketRepository;
            _unitOfWork = unitOfWork;
        }
        public Task<CustomerBasket> CreateOrUpdatePaymentIntent(string basketId)
        {
            throw new NotImplementedException();
        }

        public Task<Order> UpdateOrderPaymentFailed(string paymentIntentId)
        {
            throw new NotImplementedException();
        }

        public Task<Order> UpdateOrderPaymentSucceeded(string paymentIntentId)
        {
            throw new NotImplementedException();
        }
    }
}
