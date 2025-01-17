using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace RegularCustomer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();
            var customer = new Customer("Alice");
            var customer2 = new Customer("Bob");
            shop.Subscribe(customer);
            shop.Subscribe(customer2);

            Console.WriteLine("Welcome to our shop!");
            Console.WriteLine("Press 'A' to add new item");
            Console.WriteLine("Press 'D' to remove item by id");
            Console.WriteLine("Press 'X' to exit");

            while (true)
            {
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.X)
                {
                    Console.WriteLine();
                    Console.WriteLine("Good Bye");
                    Thread.Sleep(1000);
                    break;
                }
                else if (key.Key == ConsoleKey.A)
                {
                    Console.WriteLine();
                    shop.Add(String.Format("Item from {0}", DateTime.Now));
                }
                else
              if (key.Key == ConsoleKey.D)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter the product ID to delete");
                    var id = Console.ReadLine();
                    int itemId;
                    if (int.TryParse(id, out itemId))
                    {
                        if (!shop.Remove(itemId))
                        {
                            Console.WriteLine("No product found with the specified ID");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{id} is not int!");
                    }
                }
            }
        }
    }

    class Shop
    {
        private ObservableCollection<Item> Items = new ObservableCollection<Item>();
        private int _nextId = 0;
        public void Add(string name)
        {
            var item = new Item();
            item.Name = name;
            item.Id = ++_nextId;
            Items.Add(item);
        }

        public bool Remove(int itemId)
        {
            Item? item = null!;
            bool deleted = false;
            foreach (var _item in Items)
            {
                if (_item.Id == itemId)
                    item = _item;
            }
            if (item != null)
            {
                deleted = true;
                Items.Remove(item);
            }
            return deleted;
        }

        public void Subscribe(Customer customer)
        {
            Items.CollectionChanged += customer.OnItemChanged;
        }
    }

    class Customer(string _name)
    {
        public void OnItemChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            var action = e.Action;
            switch (action)
            {
                case NotifyCollectionChangedAction.Add:
                    var item = e.NewItems?[0] as Item;
                    Console.WriteLine("message to {1}: added item {0}", $"{item?.Name} ({item?.Id})", _name);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    item = e.OldItems?[0] as Item;
                    Console.WriteLine("message to {1}: removed item {0}", $"{item?.Name} ({item?.Id})", _name);
                    break;
            }
        }
    }

    class Item
    {
        public int Id;
        public string? Name;
    }
}
