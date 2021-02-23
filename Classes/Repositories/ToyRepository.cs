using System;
using System.Collections.Generic;
using System.Linq;
using Classes.Entities;

namespace Classes.Repositories
{
    public class ToyRepository
    {
        private readonly List<Toy> _toys;

        public ToyRepository()
        {
            _toys = new List<Toy>();
        }

        public void Save(string name, string vendorCode, string material, string color)
        {
            var toy = new Toy(GetId(), name, vendorCode, material, color);
            
            _toys.Add(toy);
        }

        public List<Toy> GetList()
        {
            return _toys;
        }

        public Toy GetById(int id)
        {
            return _toys.Find(toy => toy.Id == id);
        }

        private int GetId()
        {
            return _toys.Any() ? _toys.Count() + 1 : 1;
        }
    }
}