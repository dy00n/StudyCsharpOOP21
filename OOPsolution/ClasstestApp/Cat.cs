using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasstestApp
{
    class Cat : Animal
    {
        //public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public Cat() { /*Nothing*/ }
        public Cat(string name, string color, int age)
        {
            //initialization
            this.Name = name;
            this.Color = color;
            this.Age = age;
        } 
        public Cat(string name, string color)
        {
            //초기화
            this.Name = name;
            this.Color = color;
        }
        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void Meow() { Console.WriteLine($"{this.Color} {this.Name}, 야옹!"); }
        //public void Meow() { Console.WriteLine("{0} {1}, 야옹!", this.Color, this.Name); }

        public override void Sleep()
        {
            //base.Sleep(); //부모의 sleep() 실행
            //이후 자식 클래스의 sleep 내용 실행
            Console.WriteLine($"{this.Color} 고양이 {this.Name}이(가) ZZ잡니다!");
        }
    }
}
