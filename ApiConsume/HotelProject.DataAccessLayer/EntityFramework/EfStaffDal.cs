using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework;

public class EfStaffDal: GenericRepository<Staff>, IStaffDal
{
    public EfStaffDal(Context context) : base(context)
    {
    }
}