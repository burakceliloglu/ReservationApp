using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;

namespace DataAccessLayer.Repositories;

public class GenericRepository<T>: IGenericDal<T> where T: class
{
    public readonly Context _context;

    public GenericRepository(Context context)
    {
        _context = context;
    }
    
    public void Insert(T t)
    {
        _context.Add(t);
        _context.SaveChanges();
    }

    public void Delete(T t)
    {
        _context.Remove(t);
        _context.SaveChanges();
    }

    public void Update(T t)
    {
        _context.Update(t);
        _context.SaveChanges();
    }

    public List<T> GetList()
    {
        return _context.Set<T>().ToList();
    }

    public T? GetByID(int id)
    {
        return _context.Set<T>().Find(id);
    }
}