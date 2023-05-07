using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pd3
{
    class Program
    {
        class angle
        {
            public angle(int degree, float min, char direction)
            {

                this.degree = degree;
                this.min = min;
                this.direction = direction;
            }
            public angle()
            {

            }
            public string name;
            public int degree;
            public float min;
            public char direction;


        }

        class ship
        {
            public ship(string Le, string Lo)
            {
                this.latitude = Le;
                this.longitude = Lo;
            }
            public string latitude;
            public string longitude;

        }
        static List<angle> latitude = new List<angle>();
        static List<angle> longitude = new List<angle>();

        static void Main(string[] args)
        {
            char choice;

        n:p:
            Console.Clear();
            Console.WriteLine("1-Add Ship");
            Console.WriteLine("2-View Ship position");
            Console.WriteLine("3-View Ship serial no");
            Console.WriteLine("4-Change Ship position");
            Console.WriteLine("5-Exit");
            Console.WriteLine("Enter your choice:   ");
            choice = char.Parse(Console.ReadLine());
            if (choice == '1')
            {
                Console.Clear();
                char key;

                angle lat = new angle();
                Console.Write("Enter ship no:  ");
                lat.name = Console.ReadLine();
                Console.Write("Enter the Latitude Degree: ");
                lat.degree = int.Parse(Console.ReadLine());
                Console.Write("Enter the Latitude minute: ");
                lat.min = float.Parse(Console.ReadLine());
                Console.Write("Enter the Latitude Direction: ");
                lat.direction = char.Parse(Console.ReadLine());
                angle lati = new angle(lat.degree, lat.min, lat.direction);
                latitude.Add(lat);
                y:
                angle log = new angle();
                Console.Write("Enter ship no:  ");
                log.name = Console.ReadLine();
                if (lat.name == log.name)
                {
                    Console.Write("Enter the Longitude Degree: ");
                    log.degree = int.Parse(Console.ReadLine());
                    Console.Write("Enter the Longitude minute: ");
                    log.min = float.Parse(Console.ReadLine());
                    Console.Write("Enter the Longitude Direction: ");
                    log.direction = char.Parse(Console.ReadLine());
                    angle logi = new angle(log.degree, log.min, log.direction);
                    longitude.Add(log);
                }
                else
                {
                    Console.WriteLine("Name not matched with Latitude Name,Please Enter write name");
                    goto y;
                }



                Console.WriteLine("Enter any key yo go back: ");
                key = char.Parse(Console.ReadLine());
                goto n;
            }

            if (choice == '2')
            {
                char key;
                int flag = 1;
                Console.Clear();
                string number;
                Console.WriteLine("Enter the serial no of bus: ");
                number = Console.ReadLine();

                for (int x = 0; x < latitude.Count; x++)
                {
                    if (number == latitude[x].name)
                    {
                        Console.Write("Ship is at " + latitude[x].degree + "\u00b0" + latitude[x].min + "'" + latitude[x].direction);
                    }
                    else
                    {
                        flag = 0;
                    }


                }

                for (int x = 0; x < longitude.Count; x++)
                {
                    if (number == longitude[x].name)
                    {
                        Console.WriteLine(" and  " + longitude[x].degree + "\u00b0" + longitude[x].min + "'" + longitude[x].direction);
                    }
                    else
                    {
                        flag = 0;
                    }

                }
                if (flag == 0)
                {
                    Console.WriteLine("Ship not found");
                }
                Console.WriteLine("Enter any key yo go back: ");
                key = char.Parse(Console.ReadLine());
                goto p;

            }
            if (choice == '3')
            {
                char key;
                Console.Clear();
                int flag = 1;
                int latD, loD;
                float latM, loM;
                Console.Write("Enter the Latitude Degree: ");
                latD = int.Parse(Console.ReadLine());
                Console.Write("Enter the Latitude minute: ");
                latM = float.Parse(Console.ReadLine());
                Console.Write("Enter the Longitude Degree: ");
                loD = int.Parse(Console.ReadLine());
                Console.Write("Enter the Longitude minute: ");
                loM = float.Parse(Console.ReadLine());
                for (int x = 0; x < latitude.Count; x++)
                {
                    if (latD == latitude[x].degree && latM == latitude[x].min)
                    {
                        Console.WriteLine("Ship serial no is " + latitude[x].name);
                    }
                    else
                        flag = 0;

                }

                if (flag == 0)
                {
                    Console.WriteLine("Ship not found");
                }
                Console.WriteLine("Enter any key yo go back: ");
                key = char.Parse(Console.ReadLine());
                goto p;

            }
            if (choice == '4')
            {
                int flag = 1;
                char key;
                Console.Clear();
                string number;
                Console.WriteLine("Enter the serial no of bus: ");
                number = Console.ReadLine();
                for (int x = 0; x < latitude.Count; x++)
                {
                    if (number == latitude[x].name)
                    {
                       
                       
                        angle lat = new angle();
                        Console.Write("Enter ship no:  ");
                        lat.name = Console.ReadLine();
                        Console.Write("Enter the Latitude Degree: ");
                        lat.degree = int.Parse(Console.ReadLine());
                        Console.Write("Enter the Latitude minute: ");
                        lat.min = float.Parse(Console.ReadLine());
                        Console.Write("Enter the Latitude Direction: ");
                        lat.direction = char.Parse(Console.ReadLine());
                        latitude.RemoveAt(x);
                        latitude.Insert(x, lat);

                    }
                    else
                    {
                        flag = 0;
                    }



                }

                for (int x = 0; x < longitude.Count; x++)
                {
                    if (number == longitude[x].name)
                    {
                       
                        angle log = new angle();
                        Console.Write("Enter ship no  (same as latitude name):  ");
                        log.name = Console.ReadLine();
                        Console.Write("Enter the longitude Degree: ");
                        log.degree = int.Parse(Console.ReadLine());
                        Console.Write("Enter the longitude minute: ");
                        log.min = float.Parse(Console.ReadLine());
                        Console.Write("Enter the longitude Direction: ");
                        log.direction = char.Parse(Console.ReadLine());
                        longitude.RemoveAt(x);
                        longitude.Insert(x, log);

                    }
                    else
                    {
                        flag = 0;
                    }

                }
                if (flag == 0)
                {
                    Console.WriteLine("Ship not found");
                }
                if (flag == 1)
                {
                    Console.WriteLine("Ship data chnaged");
                }
                Console.WriteLine("Enter any key yo go back: ");
                key = char.Parse(Console.ReadLine());
                goto p;


            }
            if (choice =='5')
            {
                Console.WriteLine("Program Ended");
            }
                Console.ReadKey();
        }
    }
}
