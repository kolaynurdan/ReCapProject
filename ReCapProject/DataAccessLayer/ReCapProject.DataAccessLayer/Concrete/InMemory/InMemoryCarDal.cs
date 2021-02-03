namespace ReCapProject.DataAccessLayer.Concrete.InMemory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using ReCapProject.DataAccessLayer.Abstract;
    using ReCapProject.EntityLayer.Entityes;

    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            this._cars = new List<Car>
                             {
                                 new Car{Id = 1,CreatebyName = "User",BrandId = 1,ColorId = 1,Description = "VIP Car",ModelYear =2018 },
                                 new Car{Id = 2,CreatebyName = "User",BrandId = 1,ColorId = 1,Description = "Taxi",ModelYear =2018 },
                                 new Car{Id = 3,CreatebyName = "User",BrandId = 1,ColorId = 1,Description = "For Rent a Car",ModelYear =2018 },
                                 new Car{Id = 4,CreatebyName = "User",BrandId = 1,ColorId = 1,Description = "Very Clear",ModelYear =2018 },

                             };
        }
        public void Add(Car entity)
        {
            this._cars.Add(entity);
        }

        public void Update(Car entity)
        {
         
            Car carUpdate = this._cars.SingleOrDefault(p => p.Id == entity.Id);
            carUpdate.ColorId = entity.ColorId;
            carUpdate.BrandId = entity.BrandId;
            carUpdate.Description = entity.Description;
         
        }

        public void Delete(Car entity)
        {
          
            Car carDelete = this._cars.SingleOrDefault(p => p.Id == entity.Id && p.IsActive==true);
            this._cars.Remove(carDelete);
        
        }

        public Car GetById(int ıd)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return this._cars;
        }

      

    
    }
}