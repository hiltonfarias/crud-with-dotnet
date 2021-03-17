using System;
using System.Collections.Generic;
using CrudSeries.Interfaces;
namespace CrudSeries.Classes
{
    public class SeriesRepository : InterfaceRepository<Series>
    {
        private List<Series> listSeries = new List<Series>();
        public void Delete(int id)
        {
            listSeries[id].Delete();
        }

        public void Insert(Series entity)
        {
            listSeries.Add(entity);
        }

        public List<Series> List()
        {
            return listSeries;
        }

        public int NextId()
        {
            return listSeries.Count;
        }

        public Series ReturnById(int id)
        {
            return listSeries[id];
        }

        public void Update(int id, Series entity)
        {
            listSeries[id] = entity;
        }
    }
}