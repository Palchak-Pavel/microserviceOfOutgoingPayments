using microserviceOfOutgoingPayments.Mongodb.Entities;
using microserviceOfOutgoingPayments.Mongodb.ValueObjects;
using MongoDB.Driver;

namespace microserviceOfOutgoingPayments.Mongodb.Data
{
    public interface IMongoIncomePaymentContext
    {
        IMongoCollection<IncomePayment> IncomePayment { get; }
    }
}