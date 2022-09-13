using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    internal class Program
    {
        static void generate()
        {
            int rngPossibility;
            string password;
            int characters;
            Console.Write("How many character does your password have? ");
            Int32.TryParse(Console.ReadLine(), out characters);
            Console.Write("How should your password be?\n1)Only numbers\n2)Numbers + letters\n3)Numbers + letters + signs");
            int choice;
            Int32.TryParse(Console.ReadLine(), out choice);
            while(choice!=1 && choice!=2 && choice!=3)
            {
                Console.Write("You motherfucking idiot you cant even choose the right number\nTry again:");
                Int32.TryParse(Console.ReadLine(), out choice);
            }
            rngPossibility=choice;
            if (choice!=1)
            {
                
            }
            else if (choice!=2)
            {

            }
            else if (choice!=3)
            {

            }
        }
        static void check()
        {

        }
        static void Main(string[] args)
        {
            Console.Write("Welcome\nBecause you're a dipshit that can't decide on a password, we're gonna help you create one you moron.\nWhat do you want to do?\n1)Generate a password\n2)See if your shitty ass password is good or not\nEnter the number: ");
            int choice;
            Int32.TryParse(Console.ReadLine(), out choice);
            while(choice!=1 && choice!=2)
            {
                Console.Write("You motherfucking idiot you cant even choose the right number\nTry again:");
                Int32.TryParse(Console.ReadLine(), out choice);
            }
            if (choice==1)
                generate();
            if (choice==2)
                check();
        }
        
    }
}
