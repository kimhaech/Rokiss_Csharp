using System;
using System.Collections.Generic;

// Lambda : 일회용 함수를 만드는데 사용하는 문법. 
namespace ConsoleApp1
{

    enum ItemType
    {
        Weapon,
        Armor,
        Amulet,
        Ring
    }

    enum Rarity
    {
        Normal,
        Uncommon,
        Rare
    }

    class Item
    {
        public ItemType ItemType;
        public Rarity Rarity;
    }

    class Program
    {
        static List<Item> _items = new List<Item>();

        delegate Return MyFunc<T, Return>(T item);

        static Item FindItem2(MyFunc<Item, bool> selector) // generic delegate
        {
            foreach (Item item in _items)
            {
                if (selector(item))
                    return item;
            }
            return null;
        }
        
        delegate bool ItemSelector(Item item);

        static Item FindItem(ItemSelector selector)
        {
            foreach(Item item in _items)
            {
                if (selector(item))
                    return item;
            }
            return null;
        }

        static Item FindItem3(Func<Item, bool> selector)
        {
            foreach (Item item in _items)
            {
                if (selector(item))
                    return item;
            }
            return null;
        }

        static void Main(string[] args)
        {
            _items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
            _items.Add(new Item() { ItemType = ItemType.Armor, Rarity = Rarity.Uncommon });
            _items.Add(new Item() { ItemType = ItemType.Ring, Rarity = Rarity.Rare });

            Func<Item, bool> selector3 = (Item item) => { return item.ItemType == ItemType.Weapon; };
            Item item5 = FindItem3(selector3);

            MyFunc<Item, bool> selector2 = (Item item) => { return item.ItemType == ItemType.Weapon; }; // generic delegate 
            Item item4 = FindItem2(selector2);

            ItemSelector selector = new ItemSelector((Item item) => { return item.ItemType == ItemType.Weapon; });
            Item item3 = FindItem(selector);

            Item item = FindItem(delegate (Item item) { return item.ItemType == ItemType.Weapon; }); // anonymous function
            Item item2 = FindItem((Item item) => { return item.ItemType == ItemType.Weapon; }); // lambda
        }
    }
}
