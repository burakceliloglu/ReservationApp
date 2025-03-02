using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework;

public class EfRoomDal: GenericRepository<Room>, IRoomDal
{
    public EfRoomDal(Context context) : base(context)
    {
    }
}