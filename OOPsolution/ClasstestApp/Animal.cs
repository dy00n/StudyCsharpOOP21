using System;

namespace ClasstestApp
{
    class Animal
    {
        private int UniqueID { get; set; }
        protected string Name { get; set; }
        public void Eat(string meal)
        {
            Console.WriteLine($"{this.Name} 이 {meal}를 먹습니다.");
        }

        public virtual void Sleep() { Console.WriteLine($"{this.Name}이(가) 잡니다."); }
    }
}
