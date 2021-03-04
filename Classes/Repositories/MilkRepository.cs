using System;
using System.Collections.Generic;
using System.Linq;
using Classes.Entities;

namespace Classes.Repositories
{
    public class MilkRepository
    {
        private readonly List<Milk> _milkList;

        public MilkRepository()
        {
            _milkList = new List<Milk>();
        }

        public void Save(
            string name,
            string vendorCode,
            string packageType,
            DateTime expirationDate,
            int calorieAmount,
            double fatAmount,
            double size,
            bool hasLactose
        ) {
            var milk = new Milk(
                GetId(),
                name,
                vendorCode,
                packageType,
                expirationDate,
                calorieAmount,
                fatAmount,
                size,
                hasLactose
            );
            
            _milkList.Add(milk);
        }

        public List<Milk> GetList()
        {
            return _milkList;
        }
        
        public Milk GetById(int id)
        {
            return _milkList.Find(milk => milk.Id == id);
        }
        
        private int GetId()
        {
            return _milkList.Any() ? _milkList.Count() + 1 : 1;
        }
    }
}