using System;

namespace Classes.Entities
{
    public class Food : Product
    {
        public string PackageType { get; }
        public DateTime ExpirationDate { get; }
        public int CalorieAmount { get; }

        public Food(int id, string name, string vendorCode, string packageType, DateTime expirationDate, int calorieAmount) 
            : base(id, name, vendorCode)
        {
            PackageType = packageType;
            ExpirationDate = expirationDate;
            CalorieAmount = calorieAmount;
        }

        public override string ToString()
        {
            return base.ToString() + $"Тип упаковки: {PackageType}, Срок годности: {ExpirationDate} ";
        }
    }
}