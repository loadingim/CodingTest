using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace FactoryTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 자꾸 객체 생성이 안되서 우수 코드 참고했습니다 as넣으니까 되더라구요 제가 아직 잘 이해를 못해서 왜 그런지 피드백으로 설명 해주실 수 있으신가요...
            Potion potion = ItemFactory.Create(ItemType.Potion) as Potion;
            Weapon weapon = ItemFactory.Create(ItemType.Weapon) as Weapon;
            Armor armor = ItemFactory.Create(ItemType.Armor) as Armor;
            Food food = ItemFactory.Create(ItemType.Food) as Food;

            Item[] items = new Item[4] { potion, weapon, armor, food };
            
            for (int i = 0; i < items.Length; i++)
            {
                items[i].print(i);
            }
        }
    }
}
