using System;

namespace MethodsChallenge
{
    internal class Program
    {
 
        static void Main(string[] args)
        {
            string[] friends = {"Pedro" , "Jv", "Gabriel"};

            for (int i = 0; i <= 2; i++) 
            {
                GreetFriend(friends[i]);
            }
        }
        public static void GreetFriend(string amigo)
        {
            Console.WriteLine($"Hey there {amigo}, my dear friend!");
        }
    }
}
