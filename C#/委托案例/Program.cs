using System;

namespace _001_委托案例
{
    class Program
    {
        delegate void OnDieDelegate();
        static void Play(OnDieDelegate onDie)
        {
            Console.WriteLine("做任务");
            Console.WriteLine("玩家正在战斗");
            Console.WriteLine("死亡");

            if (onDie != null)
            {
                onDie();
            }
        }

        static void ShowDieUI()
        {
            Console.WriteLine("显示游戏死亡后的UI");
            Console.WriteLine("返回首页UI");

        }

        static void Main(string[] args)
        {
            //A主角
            //B 游戏UI 菜单
            Console.WriteLine("");
            Play(ShowDieUI);
        }
    }
}