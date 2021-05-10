using System;
using System.Reflection;

namespace DynCreationTestApp
{
    class Profile
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public void Print() { Console.WriteLine($"{Name}, {PhoneNumber}"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //일반적으로 객체생성 방식
            Profile profile1 = new Profile();
            profile1.Name = "박찬호";
            profile1.PhoneNumber = "010-4546-4785";
            profile1.Print();

            //리플랙션 객체생성
            Type type = typeof(Profile);
            object profile2 = Activator.CreateInstance(type);
            PropertyInfo name = type.GetProperty("Name");
            PropertyInfo phonenumber = type.GetProperty("phonenumber");
            name.SetValue(profile2, "류현진", null);
            phonenumber.SetValue(profile2, 010 - 4569 - 7895, null);

            MethodInfo print = type.GetMethod("Print");
            print.Invoke(profile2, null);
        }
    }
}
