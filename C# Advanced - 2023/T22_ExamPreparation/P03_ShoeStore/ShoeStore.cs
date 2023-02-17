using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeStore
{
    public class ShoeStore
    {
        public ShoeStore(string name, int storageCapacity)
        {
            this.Name = name;
            this.StorageCapacity = storageCapacity;
            this.Shoes = new List<Shoe>();
        }

        public string Name { get; set; }
        public int StorageCapacity { get; set; }
        public List<Shoe> Shoes;

        public int Count => this.Shoes.Count;

        public string AddShoe(Shoe shoe)
        {
            if (this.Count >= this.StorageCapacity)
            {
                return $"No more space in the storage room.";
            }
            Shoes.Add(shoe);
            return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
        }

        public int RemoveShoes(string material)
        => Shoes.RemoveAll(s => s.Material == material);

        public List<Shoe> GetShoesByType(string type)
        => this.Shoes.Where(s => s.Type.ToLower() == type.ToLower()).ToList();

        public Shoe GetShoeBySize(double size)
        => Shoes.FirstOrDefault(s => s.Size == size);

        public string StockList(double size, string type)
        {
            if (Shoes.Any(s => s.Size == size && s.Type == type))
            {
                StringBuilder sb = new();

                sb.AppendLine($"Stock list for size {size} - {type} shoes:");

                foreach (var shoe in Shoes.Where(s => s.Size == size && s.Type == type))
                {
                    sb.AppendLine(shoe.ToString());
                }

                return sb.ToString().TrimEnd();
            }
            return "No matches found!";
        }
    }
}
