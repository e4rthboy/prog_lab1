using System;
using System.Runtime.Serialization;

namespace Classes.Entities
{
    public class Milk : Food
    {
        public double FatAmount { get; }
        public double Size { get; }
        public bool HasLactose { get; }

        public Milk(
            int id, 
            string name,
            string vendorCode, 
            string packageType, 
            DateTime expirationDate,
            double fatAmount, 
            double size,
            bool hasLactose
        ) : base(id, name, vendorCode, packageType, expirationDate)
        {
            FatAmount = fatAmount;
            Size = size;
            HasLactose = hasLactose;
        }

        public override string ToString()
        {
            return base.ToString() + $"Жирность: {FatAmount}, Объем: {Size}, Содержит лактозу: {HasLactose}";
        }
    }
}