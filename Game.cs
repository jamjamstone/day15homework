using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15homework
{
    internal class Game
    {
        Hero _hero;
        Monster _monster;
        public Game()
        {
            _hero = new Hero("Archer",100,30,5);
            _monster = new Monster("Skeleton",50,20,5,1);
        }
        public void Play()
        {
            Console.WriteLine("게임이 시작되었습니다!");
            while (true)
            {
                if (_hero.HP <= 0||_monster.HP<=0)
                {
                    if (_monster.HP <= 0)
                    {
                        Console.WriteLine("몹 사망으로 종료");
                    }
                    else if (_hero.HP <= 0) {
                        Console.WriteLine("영웅 사망으로 종료");
                    }
                    break;
                }
                Console.WriteLine("다음 행동으로 무엇을 하시겠습니까? (1혹은 2 입력 후 엔터)");
                Console.WriteLine("1. 영웅이 몬스터를 공격");
                Console.WriteLine("2. 몬스터가 영웅 공격");
                int sw = 0;
                int.TryParse(Console.ReadLine(),out sw);
                switch (sw) 
                {
                    case 0:
                        continue;
                    case 1:
                        _hero.AttackMob(_monster);
                        _hero.DisplayInfo();
                        _monster.DisplayInfo();
                        break;
                    case 2:
                        _monster.AttackHero(_hero);
                        _hero.DisplayInfo();
                        _monster.DisplayInfo();
                        break;
                    default:
                        Console.WriteLine("다시 입력해 주십시오");
                        continue;
                }


            }



        }





    }
}
