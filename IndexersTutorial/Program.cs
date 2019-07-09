using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            IndexerClass Team = new IndexerClass();
            Team[0] = "Nemanja";
            Team[1] = "Milosh";
            Team[2] = "Mandara";
            Team[3] = "Bobby";
            Team[4] = "Ziggy";

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(Team[i]);
            }
        }
    }
}
