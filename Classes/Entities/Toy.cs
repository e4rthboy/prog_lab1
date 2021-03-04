namespace Classes.Entities
{
    public class Toy : Product
    {
        public string Material { get; }
        public string Color { get; }
        public bool IsSoft { get; }
        
        public Toy(int id, string name, string vendorCode, string material, string color, bool isSoft) 
            : base(id, name, vendorCode)
        {
            Material = material;
            Color = color;
            IsSoft = isSoft;
        }

        public override string ToString()
        {
            return base.ToString() + $"Материал: {Material}, Цвет: {Color}, Создано: {CreatedAt}";
        }
    }
}