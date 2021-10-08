using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Player
{
    int AT = 10;
    int HP = 50;
    int MAXHP = 100;

    public void StatusRender()
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine("공격력 : " + AT);
        Console.WriteLine("체력 : " + HP+"/"+MAXHP);
        Console.WriteLine("--------------------------------");
    }

    public void Heal(int HealHp)
    {
        while(HealHp > 0)
        {
            if(HP<MAXHP)
            {
                HP++;
            }
            HealHp--;
        }
        
    }
    public void Enhence(int EnhenceAt)
    {
        AT += EnhenceAt;
    }
}

class Monster
{

}

enum STARTSELECT
{
    SELECTTOWN, SELECTBATTLE, SELECTNONE
}

namespace TextRpg001
{
    class Program
    {
        static STARTSELECT StartSelect()
        {
            Console.Clear();
            Console.WriteLine("1. 마을");
            Console.WriteLine("2. 배틀");
            Console.WriteLine("어디로 가시겠습니까?");


            ConsoleKeyInfo CKI = Console.ReadKey();

            switch (CKI.Key)
            {
                case ConsoleKey.D1:
                    return STARTSELECT.SELECTTOWN;
                case ConsoleKey.D2:
                    return STARTSELECT.SELECTBATTLE;
                default:
                    return STARTSELECT.SELECTNONE;
            }

            
        }

        static void Town(Player _Player)
        {
            while (true)
            {
                Console.Clear();
                _Player.StatusRender();
                Console.WriteLine("마을에서 무슨일을 하시겠습니까?");
                Console.WriteLine("1. 체력을 회복한다.");
                Console.WriteLine("2. 무기를 강화한다.");
                Console.WriteLine("3. 마을을 나간다.");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        _Player.Heal(10);
                        break;
                    case ConsoleKey.D2:
                        _Player.Enhence(1);
                        break;
                    case ConsoleKey.D3:
                        return;


                }
            }
        }

        static void Battle()
        {
            Console.Clear();
            Console.WriteLine("아직 개장 전입니다.");

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            while (true)
            {
                STARTSELECT SelectCheck = StartSelect();
                
                switch (SelectCheck)
                {
                    case STARTSELECT.SELECTTOWN:
                        Town(NewPlayer);
                        break;
                    case STARTSELECT.SELECTBATTLE:
                        Battle();
                        break;
                    case STARTSELECT.SELECTNONE:
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
