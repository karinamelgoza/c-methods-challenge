using System;

namespace MethodsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "sam";
            string friend2 = "bob";
            string friend3 = "tim";

            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
        }

        public static void GreetFriend(string myFriend)
        {
            Console.WriteLine($"hi {myFriend}, my friend!");
        }
    }
}
