using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum ItemType
{
    Potion, Weapon, Armor, Food
}

public class Item
{
    public string name;
    public ItemType type;
    public int price;

    public void print(int i)
    {
        Console.WriteLine($"{i+1}번 아이템");
        Console.WriteLine($"아이템 타입 : {type}\n아이템 이름 : {name}\n아이템 가격 : {price} ");
        Console.WriteLine();
    }
}

public class Potion : Item
{
    public Potion()
    {
        type = ItemType.Potion;
        name = "포션";
        price = 50;
    }
}
public class Weapon : Item
{
    public Weapon()
    {
        type = ItemType.Weapon;
        name = "무기";
        price = 800;
    }
}
public class Armor : Item
{
    public Armor()
    {
        type = ItemType.Armor;
        name = "갑옷";
        price = 500;
    }
}
public class Food : Item
{
    public Food()
    {
        type = ItemType.Food;
        name = "음식";
        price = 25;
    }
}

public class ItemFactory
{
    public static Item Create(ItemType type)
    {
        switch (type)
        {
            case ItemType.Potion:
                Potion potion = new Potion();
                return potion;
            case ItemType.Weapon:
                Weapon weapon = new Weapon();
                return weapon;
            case ItemType.Armor:
                Armor armor = new Armor();
                return armor;
            case ItemType.Food:
                Food food = new Food();
                return food;
            default:
                return null;
        }
    }
}