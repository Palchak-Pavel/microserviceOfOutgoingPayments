using microserviceOfOutgoingPayments.Mongodb.Entities;
using MongoDB.Bson.Serialization;

namespace microserviceOfOutgoingPayments.Mongodb;

public class EntitiesConfig
{
    public static void Config()
    {
        BsonClassMap.RegisterClassMap<IncomePayment>(x =>
        {
            x.AutoMap();
            x.SetIgnoreExtraElements(true);
        });
    }
}