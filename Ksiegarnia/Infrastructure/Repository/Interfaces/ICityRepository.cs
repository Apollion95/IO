using Domain.Entities;
using Microsoft.CodeAnalysis;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Interfaces
{
    internal interface ICityRepository : IDisposable
    {
        PagedList<City> GetCities(int pageNumber);
        Optional<City> GetCityByPostalCode(string postalCode);
        Optional<City> GetCityByName(string name);
        void InsertCity(City city);
        void UpdateCity(City city);
        void DeleteCity(City city);
    }
}
