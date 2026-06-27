using System;

namespace _001_枚举类型
{
    class Test
    {
        enum RoleType //枚举类型的名字enum
        {
            Mage,Archer,Assassin,Tank,Support,Warrior
        }

        static void Main(string[] args)
        {
            //1.法师(Mage),2.射手(Archer),3.刺客(Assassin),4.坦克(Tank),5.辅助(Support),6.战士(Warrior)

            RoleType roleType = RoleType.Archer;
            
            if (roleType == RoleType.Assassin)
            {

            }

        }
    }
}

namespace _002_枚举类型的练习
{
    class Program
    {
        enum GameState
        {
            //菜单，游戏中，暂停，失败，成功
            Menu,Running,Pauese,Fail,Success
        }
        enum Week
        {
            //一周7天
            Sun,Mon,Tue,Wed,Thu,Fri,Sat
        }

        static void Main(string[] args)
        {
            GameState gamestate = GameState.Menu;
            gamestate = GameState.Running;

            if (gamestate == GameState.Menu)
            {

            }
            Console.WriteLine(gamestate);

            Week day = Week.Mon;
            day = Week.Tue;
            Console.WriteLine(day);
        }
    }
}