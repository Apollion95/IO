using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Repository.Interfaces;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class CityRepository : ICityRepository
    {
        private BookStoreContext context;
        public const int PAGE_SIZE = 10;

        public CityRepository(BookStoreContext context)
        {
            this.context = context;
        }
        public void DeleteCity(City city)
        {
            City cityFromDb = context.Cities.FirstOrDefault(x=>x.city.Equals(city.city));
            if(cityFromDb!=null)
                context.Cities.Remove(cityFromDb);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public PagedList<City> GetCities(int pageNumber)
        {
            return (PagedList<City>)context.Cities.ToPagedList(pageNumber, PAGE_SIZE);
        }

        public Optional<City> GetCityByName(string name)
        {
            Optional<City> city = context.Cities.FirstOrDefault(x => x.city.Equals(name));
            return city;
        }

        public Optional<City> GetCityByPostalCode(string postalCode)
        {
            Optional<City> city = context.Cities.FirstOrDefault(x => x.postal_code.Equals(postalCode));
            return city;
        }

        public void InsertCity(City city)
        {
            context.Cities.Add(city);
        }

        public void UpdateCity(City city)
        {
            context.Entry(city).State = EntityState.Modified;
        }
    }
}
