using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class SubscribeManager: ISubscribeService
{
    private readonly ISubscribeDal _subscribeDal;

    public SubscribeManager(ISubscribeDal subscribeDal)
    {
        _subscribeDal = subscribeDal;
    }

    public void TInsert(Subscribe t)
    {
        _subscribeDal.Insert(t);
    }

    public void TDelete(Subscribe t)
    {
        _subscribeDal.Delete(t);
    }

    public void TUpdate(Subscribe t)
    {
        _subscribeDal.Update(t);
    }

    public List<Subscribe> TGetList()
    {
        return _subscribeDal.GetList();
    }

    public Subscribe? TGetByID(int id)
    {
        return _subscribeDal.GetByID(id);
    }
}