using System;
using System.Collections.Generic;

namespace LDTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Topic> testiKokoelma = new Dictionary<int, Topic>();

            Topic uusiTopique = new Topic();
            uusiTopique.Id = 100;
            uusiTopique.Title = "TestiMeno";
            uusiTopique.Description = "Opitaan jotain";
            uusiTopique.EstimatedTimeToMaster = 0.5;


            if(testiKokoelma.ContainsKey(100))
            {
                Console.WriteLine("Löytyi!");
            }
            else
            {
                Console.WriteLine("Ei löydy :(");
            }

            testiKokoelma.Add(uusiTopique.Id, uusiTopique);

            if (testiKokoelma.ContainsKey(100))
            {
                Console.WriteLine("Löytyi!");
            }
            else
            {
                Console.WriteLine("Ei löydy :(");
            }

            Console.WriteLine(testiKokoelma.Values);

            List<Topic> listTopic = new List<Topic>();

            Topic toinenOlio = new Topic();
            toinenOlio.Id = 123;
            toinenOlio.Title = "listaan meno";
            toinenOlio.Description = "Opitaan jotain taas toivon mukaan";
            toinenOlio.EstimatedTimeToMaster = 0.25;
            listTopic.Add(toinenOlio);


            testiKokoelma.Add(toinenOlio.Id,toinenOlio);

            foreach(int i in testiKokoelma.Keys)
            {
                Topic haettuTopic = null;
                testiKokoelma.TryGetValue(i, out haettuTopic);

                Console.WriteLine(haettuTopic.Title);

            }

            //Console.WriteLine("Hello World!");
        }
    }

    class Topic
    {
        public int Id;
        public string Title;
        public string Description;
        public double EstimatedTimeToMaster;
    }
}
