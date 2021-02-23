namespace Classes.Entities
{
    public class Toy : Product
    {
        public string Material { get; }
        public string Color { get; }
        
        public Toy(int id, string name, string vendorCode, string material, string color) 
            : base(id, name, vendorCode)
        {
            Material = material;
            Color = color;
        }

        public override string ToString()
        {
            return base.ToString() + $"Материал: {Material}, Цвет: {Color}, Создано: {CreatedAt}";
        }
    }
}