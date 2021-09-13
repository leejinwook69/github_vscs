using System;


public class Player
{

    public static void PVP(Player _Left, Player _Right)
    {
        _Left.HP -= _Right.HP;
        _Right.HP -= _Left.HP;
    }

    private int HP = 100;
    void Damage(int _Damage)
    {
        HP -= _Damage;
    }
}
namespace staticfunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Newplayer = new Player();
            
        }
    }
}
