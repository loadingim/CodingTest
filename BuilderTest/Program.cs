using System.Text;
using System;
using System.Reflection.Emit;
using System.Xml.Linq;
using System.Threading;

namespace BuilderTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();


            MonsterBuilder dragon = new MonsterBuilder();
            dragon.SetName("드래곤");
            dragon.SetExp(1000);
            dragon.SetApp("흑색 비늘을 가진 흑룡");
            dragon.SetLoot("흑룡의 비늘");
            dragon.SetAttackRange("7X7칸");
            dragon.SetAttackStyle("브레스");

            MonsterBuilder slime = new MonsterBuilder();
            slime.SetName("슬라임");
            slime.SetExp(5);
            slime.SetApp("반투명한 액체의 청소부");
            slime.SetLoot("슬라임의 체액");
            slime.SetAttackRange("1칸");
            slime.SetAttackStyle("몸통박치기");

            MonsterBuilder nineTailFox = new MonsterBuilder();
            nineTailFox.SetName("구미호");
            nineTailFox.SetExp(400);
            nineTailFox.SetApp("아홉개의 하얀 꼬리를 가진 900년 이상 살아온 여우");
            nineTailFox.SetLoot("여우구슬");
            nineTailFox.SetAttackRange("6X2칸");
            nineTailFox.SetAttackStyle("혼령구슬");


            List<Monster> monsters = new List<Monster>();

            for (int i = 0; i < 5; i++)
            {
                switch (rand.Next(1, 4))
                {
                    case 1:
                        monsters.Add(dragon.Build());
                        break;
                    case 2:
                        monsters.Add(slime.Build());
                        break;
                    case 3:
                        monsters.Add(nineTailFox.Build());
                        break;
                    default:
                        break;
                }
            }

            for (int i = 0; i < monsters.Count; i++)
            {
                Console.WriteLine($"{i+1}번 몬스터");
                Console.WriteLine($"몬스터의 이름 : {monsters[i].name} ({monsters[i].app})\n몬스터 전리품 : {monsters[i].loot}\n몬스터 경험치 : {monsters[i].exp}\n몬스터의 공격사거리와 스타일 :  {monsters[i].attackRange}, {monsters[i].attackStyle}");
                Console.WriteLine();
            }
        }
    }
}
