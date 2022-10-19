using DevTrackR.ShippingOrders.Core.Entities;

namespace DevTrackR.ShippingOrders.Core.Repositories
{
    public interface IShippingServiceRopository
    {
        Task<List<ShippingService>> GetAllAsync();
    }
}