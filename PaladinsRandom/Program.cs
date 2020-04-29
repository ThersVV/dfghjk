using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaladinsRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] support = { "Furia", "Seris", "Grover", "Ying", "Jenos", "Mal'Damba", "Io", "Grohk", "Pip" };
            string[] flanker = { "Androxus", "Buck", "Evie", "Koga", "Lex", "Maeve", "Moji", "Skye", "Talus", "Zhin" };
            string[] frontline = { "Ash", "Atlas", "Barik", "Fernando", "Inara", "Khan", "Makoa", "Raum", "Ruckus", "Terminus", "Torvald (I´m so sorry)" };
            string[] damage = { "Bomb king", "Cassie", "Dredge", "Drogoz", "Imani", "Kinessa", "Lian", "Shalin", "Strix", "Tiberius", "Tyra", "Viktor", "Vivian", "Willo" };
            string[] all = support.Concat(flanker.Concat(frontline.Concat(damage))).ToArray();
            Random rnd = new Random();
            Console.WriteLine("Choose your class: Support (s), Flank(f), Tank(t), Damage(d) or all of them (all)");
            string Class = Console.ReadLine();
            if (Class.ToLower().Contains("all"))
            {
                
                int cislo = rnd.Next(0, 43);
                Console.WriteLine(all[cislo]);
            }
            if (Class.ToLower().Contains("s")||Class.ToLower().Contains("sup"))
            {
                int cislo = rnd.Next(0, 8);
                Console.WriteLine(support[cislo]);
            }
            if (Class.ToLower().Contains("f") || Class.ToLower().Contains("fla"))
            {
                Console.WriteLine("");
                int cislo = rnd.Next(0, 9);
                Console.WriteLine(flanker[cislo]);
            }
             if (Class.ToLower().Contains("t") || Class.ToLower().Contains("tank") || Class.ToLower().Contains("front"))
            {
                Console.WriteLine("");
                int cislo = rnd.Next(0, 10);
                Console.WriteLine(frontline[cislo]);
            }
             if (Class.ToLower().Contains("d") || Class.ToLower().Contains("dam") || Class.ToLower().Contains("dmg"))
            {
                Console.WriteLine("");
                int cislo = rnd.Next(0, 13);
                Console.WriteLine(damage[cislo]);
            }
            
            
            Console.ReadLine();
        }
    }
}
