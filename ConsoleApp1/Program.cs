using System;
using System.Text;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  taking input 
            Console.WriteLine("please type something ");
            string userValue =Console.ReadLine();
           Console.WriteLine("you typed " + userValue);
           */

            /* if statement casual way 
            Console.WriteLine("please choose 1 or 2 or 3 ");
            string userValue = Console.ReadLine();

            if (userValue=="1")
            { Console.WriteLine("ya ");}
            else if (userValue.Equals("2"))
            {
                Console.WriteLine("yahoo");
            }
            else if (userValue == "3")
            {
                Console.WriteLine("yahoooooooooooooooo");
            }
            else
            {
                Console.WriteLine("you are a fool");
            }
            */




            /* a better way to stop repeatative work by assinging to a value 
            Console.WriteLine("choose between  1 or 2 or 3. to know your girlfriends message");
            string userValue = Console.ReadLine();
            string message="";

            if (userValue == "1")
            {
                message = "I love you "; }
            else if (userValue.Equals("2"))
            {
                message = "I love someone else";
            }
            else if (userValue == "3")
            {
                message = "you know I am a lesbian so its not possible ";
            }
            else
            {
                message="you are a brother to me";
            }

            Console.WriteLine(message);
            */



            /*
            // a better way to write to compare  
            Console.WriteLine("choose . to know your reward");
            string userValue = Console.ReadLine();
            string message = (userValue == "1") ? "car" : "shit ";
            Console.WriteLine("you won {0} and you typed {1}", message, userValue);
            */

            //for loop

            //for (int i=0; i< 10; i++)
            //{
            //    Console.WriteLine(i.ToString());
            //}
            /* // Arrays 
            int[] n=new int[5];
            n[0] = 12;
            n[1] = 24;
            n[2] = 36;
            n[3] = 48;
            n[4] = 60;

            // n[5]=2; // will display out of bounds error
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("Aray position "+ i.ToString() + " & the value is " + n[i].ToString());
            }

            // better way
            foreach (var i in n)
            {
                Console.WriteLine(i);
            }
           


            
            // 
            string sentence = "I dont know what to do";
            char[] charArray = sentence.ToCharArray();
            Array.Reverse(charArray);

            Console.WriteLine(sentence);
            Console.Write("Reversed : ");

            foreach (var c in charArray)
            {
                Console.Write(c);
            }
            
    */
    /*//reading from a text 
            StreamReader reader = new StreamReader("TextData.txt");
            string line = "";

            while (line != null)
            {
                line = reader.ReadLine();
                if (line != null)
                    Console.WriteLine(line);
            }
            

            reader.Close();
            */
            /*
            // using a method 
            Console.WriteLine("GO to drive : C: \\ ");
            string s = "asd";

            Console.WriteLine(formula("sdasd"));
            Console.ReadLine();
            */



            Car myNewCar = new Car();

            myNewCar.Maker = "Toyota";
            myNewCar.Color = "Black";
            myNewCar.Year = 2017;
            myNewCar.model = "corolla";
            myNewCar.price = 25000 ;



            Console.WriteLine(myNewCar.Maker +myNewCar.model + myNewCar.Year + 
                myNewCar.Color + myNewCar.price);


            Car myOtherCar = myNewCar;

            

            myOtherCar.Maker = "BMW";
            Console.WriteLine(myOtherCar.Maker);
            Console.WriteLine(myNewCar.Maker);



            Console.ReadLine();
        }

        public Car changebyValue(Car car)

        {
            car.Maker = "Lambo";
            return car;

        }


        public static string formula(string name)
        {
            return string.Format("hello you  {0}",name);
        }
        


    }
    class Car {
        public string Maker { get; set; }
        public string model { get; set; }
        public int Year { get; set; }
        public int price { get; set; }
        public string Color { get; set; }
    }


}
