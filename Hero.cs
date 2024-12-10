using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15homework
{
    internal class Hero
    {
        string _name;
        int _hp;
        int _atk;
        int _def;
        public Hero() 
        {
            _name = "영웅";
            _hp = 100;
            _atk = 20;
            _def = 10;
        }
        public Hero(string name, int hp, int atk, int def)
        {
            _def = def;
            _name = name;   
            _hp = hp;   
            _atk = atk; 
        }
        public void Takedamage(int damage)
        {
            _hp -= (damage-_def);
        }

        public void AttackMob(Monster mob)
        {
            Console.WriteLine($"{mob.MName}을 공격!");
            mob.Takedamage(this._atk);
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"플레이어명 {_name}");
            Console.WriteLine($"현재 체력{_hp}");
            Console.WriteLine($"플레이어의 공격력과 방어력: {_atk} {_def}");
        }
        public int HP
        {
            get { return _hp; }
            set { _hp = value; }
        }

        public int Atk
        {
            get { return _atk; }
            set
            {
                _atk = value;
            }




        }
    }
}
