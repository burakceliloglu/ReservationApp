using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework;

public class EfSubscribeDal: GenericRepository<Subscribe>, ISubscribeDal
{
    public EfSubscribeDal(Context context) : base(context)
    {
    }
}