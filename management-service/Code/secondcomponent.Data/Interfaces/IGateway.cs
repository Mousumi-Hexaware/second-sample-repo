using MongoDB.Driver;

namespace secondcomponent.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
