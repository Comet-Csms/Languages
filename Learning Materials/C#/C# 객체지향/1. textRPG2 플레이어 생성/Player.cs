using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public enum PlayerType
    {
        None = 0,
        Knight = 1,
        Archer = 2,
        Mage = 3
    }

    class Player
    {
        protected PlayerType type = PlayerType.None; // 내부에서만 사용하는 변수의 경우 _type과 같이 사용하기도 한다.
        protected int hp;
        protected int attack;

        protected Player(PlayerType type)
        {
            this.type = type;
        }

        public void SetInfo(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
        }

        public PlayerType GetPlayerType()
        {
            return type;
        }

        public int GetHp()
        {
            return hp;
        }

        public int GetAttack()
        {
            return attack;
        }

        public bool IsDead()
        {
            return hp <= 0;
        }

        public void OnDamaged(int damage)
        {
            hp -= damage;
            if (hp < 0)
            {
                hp = 0;
            }
        }
    }

    class Knight : Player
    {
        public Knight() : base(PlayerType.Knight)
        {
            SetInfo(100, 10);
        }
    }

    class Archer : Player
    {
        public Archer() : base(PlayerType.Archer)
        {
            SetInfo(75, 12);
        }
    }

    class Mage : Player
    {
        public Mage() : base(PlayerType.Mage)
        {
            SetInfo(50, 15);
        }
    }
}
