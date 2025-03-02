using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework;

public class EfServiceDal: GenericRepository<Service>, IServicesDal
{
    public EfServiceDal(Context context) : base(context)
    {
    }
}