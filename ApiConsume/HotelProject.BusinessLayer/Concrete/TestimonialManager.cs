using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class TestimonialManager: ITestimonialService
{
    private readonly ITestimonialDal _testimonialDal;

    public TestimonialManager(ITestimonialDal testimonialDal)
    {
        _testimonialDal = testimonialDal;
    }

    public void TInsert(Testimonial t)
    {
        _testimonialDal.Insert(t);
    }

    public void TDelete(Testimonial t)
    {
        _testimonialDal.Delete(t);
    }

    public void TUpdate(Testimonial t)
    {
        _testimonialDal.Update(t);
    }

    public List<Testimonial> TGetList()
    {
        return _testimonialDal.GetList();
    }

    public Testimonial? TGetByID(int id)
    {
        return _testimonialDal.GetByID(id);
    }
}