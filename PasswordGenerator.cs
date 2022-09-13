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
            int characters;
            Console.Write("How many character does your password have?\nIf you want to return, enter 0 you loser. ");
            Int32.TryParse(Console.ReadLine(), out characters);
            if (characters == 0)
            {
                Console.Clear();
                Main();
            }
            char[] Password = new char[characters];
            Console.Write("How should your password be?\n1)Only numbers\n2)Numbers + letters\n3)Numbers + letters + signs\nChoose: ");
            int choice;
            Int32.TryParse(Console.ReadLine(), out choice);
            while(choice!=1 && choice!=2 && choice!=3)
            {
                Console.Write("You motherfucking idiot you cant even choose the right number\nTry again:");
                Int32.TryParse(Console.ReadLine(), out choice);
            }
            if (choice==0)
            {
                Console.Clear();
                Main();
            }
            int rng=0;
            Random rnd=new Random();
            if (choice==1)
            {
                
                for (int i = 0; i<characters; i++)
                {
                    Password[i]=Convert.ToChar(rnd.Next(48, 57));
                }
                for (int i = 0; i<characters; i++)
                {
                    Console.Write(Password[i]);
                }
                    
            }
            else if (choice==2)
            {
                for(int i = 0; i<characters; i++)
                {
                    rng=rnd.Next(1, 2);
                    if (rng==1)
                    {
                        Password[i]=Convert.ToChar(rnd.Next(48, 57));
                    }
                    else if (rng==2)
                    {
                        Password[i]=(char)rnd.Next(65, 122);
                    }
                }
                for (int i = 0; i<characters; i++)
                {
                    Console.Write(Password[i]);
                }
            }
            else if (choice==3)
            {

            }
        }
        static void check()
        {

        }
        static void Main()
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
            {
                Console.Clear();
                generate();
            }
            if (choice==2)
            {
                Console.Clear();
                check();
            }
        }
        
    }
}
