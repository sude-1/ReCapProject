using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        //bir iş sınıfı başka sınıfları new'lemez
        ICarDal _carDal;// soyut nesneyle bağlantı kurcaz inmemory veya entityframework ismi olmıcak yani new'lemicez :)

        public CarManager(ICarDal carDal) // veri tabanı değişirse yani memory entityframework ikisi veya başkası kullanılır new'lemedik
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            // iş kodları 
            return _carDal.GetAll();
        }
    }
}
