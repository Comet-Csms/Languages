using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Knight();
            Monster monster = new Orc();

            int damage = player.GetAttack();
            monster.OnDamaged(damage);
        }
    }
}