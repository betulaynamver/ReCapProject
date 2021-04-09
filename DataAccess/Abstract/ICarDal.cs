using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        public void Add(Car car);
        public void Delete(Car car);
        public void Update(Car car);

        List<Car> GetById(int Id);
    }
}
