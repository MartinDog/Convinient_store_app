using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Convinient_store_app
{
    public class Merchandise_Manager : Merchandise
    {
        private List<Merchandise> stuff = new List<Merchandise>();
        public List<Merchandise> STUFF
        {
            get
            {
                return stuff;
            }
            set
            {

            }
        }
        public void Add(string name, int quantity, int price, string manu, string serial)
        {
            stuff.Add(new Merchandise(name, quantity, price, manu, serial));
        }
        public void Add(string name, int quantity, int price, string manu, string serial, string date)
        {
            stuff.Add(new Food_Snack(name, quantity, price, manu, serial, date));
        }
        public void save()
        {
            FileStream fs = File.Create("stuffs.csv");
            StreamWriter sw = new StreamWriter(fs);
            foreach (var stuffs in stuff)
            {
                if (stuffs is Food_Snack == false)
                {
                    Console.WriteLine($"{stuffs.NAME}, {stuffs.Quantity}, {stuffs.PRICE}, {stuffs.MAN},{stuffs.SERIAL}");
                    sw.WriteLine($"{stuffs.NAME}, {stuffs.Quantity}, {stuffs.PRICE}, {stuffs.MAN},{stuffs.SERIAL}");
                }
                else
                {
                    Console.WriteLine($"{stuffs.NAME}, {stuffs.Quantity}, {stuffs.PRICE}, {stuffs.MAN},{stuffs.SERIAL}");
                    sw.WriteLine($"{stuffs.NAME}, {stuffs.Quantity}, {stuffs.PRICE}, {stuffs.MAN},{stuffs.SERIAL},{((Food_Snack)stuffs).DT}");
                }
            }
            sw.Close();
            fs.Close();
        }
        public void load()
        {
            FileStream fs = File.OpenRead("stuffs.csv");
            StreamReader sr = new StreamReader(fs);
            string s;
            string[] sitems;
            stuff.Clear();
            while (sr.EndOfStream == false)
            {
                s = sr.ReadLine();
                sitems = s.Split(',');
                if (sitems.Length == 5)
                {
                    Add(sitems[0], int.Parse(sitems[1]), int.Parse(sitems[2]), sitems[3], sitems[4]);
                }
                else if (sitems.Length == 6)
                {
                    Add(sitems[0], int.Parse(sitems[1]), int.Parse(sitems[2]), sitems[3], sitems[4], sitems[5]);
                }
            }
            foreach(var i in stuff)
            {
                Console.WriteLine(i.NAME);
            }
            sr.Close();
            fs.Close();
        }
        public void delete_stuff(string serial)
        {
            int index = 0;
            for(int i=0;i<stuff.Count; i++)
            {
                if (serial.Equals(stuff[i].SERIAL))
                {
                    index = i;
                    break;
                }
            }
            stuff.RemoveAt(index);
        }
    }

}
