using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTestApp
{
    class Dog
    {
        private int age;
        //private string name;
        //color 생략
        /*public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }*/
        public string Name { get; set; } = "멍멍이"; //초기값 지정
        public string Color { get; set; } = "누런";

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    this.age = 1;
                }
                else if (value > 15)
                {
                    this.age = 15;
                }
                else
                {
                    this.age = value;
                }
                age = value;
            }
        }

        /*public string GetName() { return this.name; }
        public void SetName(string name) { this.name = name; }

        //값을 사용
        public int GetAge() { return this.age; }

        //값을 설정
        public void SetAge(int age) { 
            if (age < 0)
                {
                    this.age = 1;
                }
            else if (age > 15)
                {
                    this.age = 15;
                }
            else
            {
                this.age = age;
            }
        }*/

        //eat, sleep, bark() 생략...
    }
}
