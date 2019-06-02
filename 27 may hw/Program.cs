using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_may_hw
{
    class Program
    {
        static void Main(string[] args)
        {

            //   1 Indexer;
            loop();

            
            // 2  Extension metod
            //int a = 5;
            //Console.WriteLine(a.yukselt());
             
        }


        
        public static void loop()
        {
            NameBook nbk = new NameBook();
            Console.WriteLine("TElefon kitabcasi 10 neferlik");
            Console.WriteLine("Shexs elave etmek ucun yaz,Shexse baxmagcun bax komandasini daxil edin");
            
            while (true)
            {
                Console.Write("komanda daxil edin :");
                string com = Console.ReadLine();
                if (com == "yaz")
                {
                    Console.Write("Elave etmek istediyiniz shexsin adini daxil edin :");
                    string rn = Console.ReadLine();
                    Console.Write("Shexsin nomresini daxil edin :");
                    string rnm = Console.ReadLine();
                    nbk[$"{rn}"] = $"{rnm}";

                }
                else if (com == "bax")
                {
                    Console.Write("Baxmaq istediyiniz shexsin adini qeyd edin :");
                    string nms = Console.ReadLine();
                  
                    Console.WriteLine(nbk[nms]);
                }
                else
                {
                    Console.WriteLine("Duzgun emr daxil edin");
                }
            }
        }
    }
    class NameBook
    {
        private static int count = 0;
        public string[] names=new string[10];
        public string[] numbers = new string[10];
        public string this[string name]
        {
            get
            {
                int n;
                if (int.TryParse(name,out n))
                {
                    return names[n] + " " + numbers[n];
                }
                else
                {
                    int index = Array.IndexOf(names, name);
                    return names[index] + " " + numbers[index]; 
                }
                 
            }
            set
            {
                names[count] = name;
                numbers[count] = value;
                count++;
            }
        }
        
        
    }
    public static class Yukselt
    {
        public static int yukselt(this int x)
        {
            return x *= x;
        }
    }
}
