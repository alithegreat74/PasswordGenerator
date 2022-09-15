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
            
            int characters;
            Console.Write("How many character does your password have?\nIf you want to return, enter 0 you loser. ");
            Int32.TryParse(Console.ReadLine(), out characters);
            if (characters == 0)
            {
                Console.Clear();
                Main();
            }
            char[] Password = new char[characters];
            Console.Write("How should your password be?\n1)Only numbers\n2)Numbers + letters\n3)Numbers + letters + symbols\nChoose: ");
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
            int[] symbols = new int[33] { 32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,58,59,60,61,62,63,64,91,92,93,94,95,96,123,124,125,126 } ;
            
            if (choice==1)
            {
                
                for (int i = 0; i<characters; i++)
                {
                    Password[i]=Convert.ToChar(rnd.Next(48, 57));
                    Console.Write(Password[i]);
                }
                Console.Write("\n");
            }
            else if (choice==2)
            {
                for(int i = 0; i<characters; i++)
                {
                    rng=rnd.Next(1, 20);
                    if (rng<10)
                    {
                        Password[i]=Convert.ToChar(rnd.Next(48, 57));
                    }
                    else if (rng<15)
                    {
                        Password[i]=(char)rnd.Next(65, 90);
                    }
                    else if (rng<20)
                    {
                        Password[i]=(char)rnd.Next(97, 122);
                    }
                    Console.Write(Password[i]);
                }
                Console.Write("\n");
            }
            
            
            else if (choice==3)
            {
                for(int i = 0; i<characters; i++)
                {
                    rng=rnd.Next(1, 30);
                    if (rng<10)
                    {
                        Password[i]=Convert.ToChar(rnd.Next(48, 57));
                    }
                    else if (rng<15)
                    {
                        Password[i]=(char)rnd.Next(65, 90);
                    }
                    else if (rng<20)
                    {
                        Password[i]=(char)rnd.Next(97, 122);
                    }
                    else if (rng<30)
                    {
                        int pass = rnd.Next(symbols.Length);
                        Password[i]=(char)symbols[pass+1];
                    }
                    Console.Write(Password[i]);
                }
                Console.Write("\n");
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
