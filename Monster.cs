using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace day15homework
{
    internal class Monster
    {
        string _mname;
        int _mhp;
        int _matk;
        int _mdef;
        int _mlv;
        public Monster()
        {
            _mname = "Basic Monster";
            _mhp = 50;
            _matk = 15;
            _mlv = 1;
            _mdef = 5;
                
        }
        public Monster(string name, int mhp, int matk, int mdef,int mlv)
        {
            _mname = name;
            _mhp = mhp;
            _matk = matk;
            _mdef = mdef;
            _mlv = mlv;
        }







        public void Takedamage(int damage)
        {
            _mhp -= (damage - _mdef);
        }
        public void AttackHero(Hero hero)
        {
            hero.Takedamage(_matk);
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"몬스터: {_mname}");
            Console.WriteLine($"현재 체력{_mhp}");
            Console.WriteLine($"몬스터의 공격력과 방어력: {_matk} {_mdef}");
        }

        public int HP
        {
            get { return _mhp; }
            set { _mhp = value; }
        }
        public int MAtk
        {
            get { return _matk; }
            set { _matk = value; }
        }
        public string MName
        {
            get { return _mname; }
            set { _mname = value; }
        }

    }
}
