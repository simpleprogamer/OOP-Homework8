using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1
{
    //Який принцип S.O.L.I.D. порушено? Виправте!
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; } 
    }
    class Order
    {
        private readonly List<Item> _items = new List<Item>();
        public IReadOnlyList<Item> Items => _items;

        public void AddItem(Item item) => _items.Add(item);
        public void DeleteItem(Item item) => _items.Add(item);
        public int GetItemCount() => _items.Count;
        public decimal CalculateTotalSum() => _items.Sum(i => i.Price);
        }
        class OrderPrinter 
        {
        public void Print(Order order) { }
        public void Show(Order order) { }

        }
        class OrderRepository
        {
            public Order Load(int id) 
            {
                return new Order();
            }
            public void Save(Order order)
            {
            }
            public void Delete(Order order) { }
            public void Update(Order order) { }
        }


    

    class Program
    {
        static void Main()
        {
        }
    }
}
