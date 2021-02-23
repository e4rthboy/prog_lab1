using System;

namespace Classes.Entities
{
    public abstract class Product
    {
        public int Id { get; }
        public string Name { get; }
        public string VendorCode { get; }
        public DateTime CreatedAt { get; }

        protected Product(int id, string name, string vendorCode)
        {
            Id = id;
            Name = name;
            VendorCode = vendorCode;
            CreatedAt = DateTime.Now;
        }
        
        public override string ToString()
        {
            return $"ID: {Id}, Название: {Name}, Артикул: {VendorCode} ";
        }
    }
}