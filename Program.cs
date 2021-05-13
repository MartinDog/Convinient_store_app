using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convinient_store_app
{
    public class test
    {
        public int a;
        public test(int a)
        {
            this.a = a;
        }
    }
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            List<test> b = new List<test>();
            b.Add(new test(10));
            test t = new test(10);
            b.RemoveAt(0);
            Console.WriteLine(b.Count());
            string s;
            Merchandise_Manager m = new Merchandise_Manager();
            for (int i = 0; i < 2; i++)
            {
                s = Console.ReadLine();
                string[] tf = s.Split(' ');
                if (tf.Length == 5)
                {
                    m.Add(tf[0], int.Parse(tf[1]), int.Parse(tf[2]), tf[3], tf[4]);
                }
                else if (tf.Length == 6)
                {
                    m.Add(tf[0], int.Parse(tf[1]), int.Parse(tf[2]), tf[3], tf[4], tf[5]);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            m.save();
            m.load();
            m.delete_stuff("1234");
            foreach (var Item in m.STUFF)
            {
                Console.WriteLine(Item.SERIAL);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
