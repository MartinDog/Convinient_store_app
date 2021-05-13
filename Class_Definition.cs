using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convinient_store_app
{
    public class Merchandise
    {
        protected string Name;
        protected int Product_Quantity;
        protected int Price;
        protected string Manufacturer;
        protected string Serial_number;
        protected string Location;

        public Merchandise()
        {
            Name = "NA";
            Product_Quantity = -1;
            Price = 0;
            Manufacturer = "NA";
            Serial_number = "NA";
        }
        public Merchandise(string name, int quantity, int price, string manu, string serial)
        {
            NAME = name;
            Quantity = quantity >= 0 ? quantity : 0;
            PRICE = price >= 0 ? price : 0;
            MAN = manu;
            SERIAL = serial;
        }
        public string NAME
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public int Quantity
        {
            get
            {
                return Product_Quantity;
            }
            set
            {
                if (value >= 0)
                {
                    Product_Quantity = value;
                }
                else
                {
                    Console.WriteLine("Unproper_input");
                    Product_Quantity = 0;
                }
            }
        }
        public int PRICE
        {
            get
            {
                return Price;
            }
            set
            {
                if (value >= 0)
                {
                    Price = value;
                }
                else
                {
                    Console.WriteLine("Unproper_input");
                    Price = 0;
                }
            }
        }
        public string MAN
        {
            get
            {
                return Manufacturer;
            }
            set
            {
                Manufacturer = value;
            }
        }
        public string SERIAL
        {
            get
            {
                return Serial_number;
            }
            set
            {
                Serial_number = value;
            }
        }
    }
    class Food_Snack : Merchandise
    {
        protected string date;
        public Food_Snack() : base()
        {
            DT = "00/00/0000";
        }
        public Food_Snack(string name, int quantity, int price, string manu, string serial, string Dt) : base(name, quantity, price, manu, serial)
        {
            DT = Dt;
        }
        public string DT
        {
            get
            {
                return date;
            }
            set
            {
                string[] D = value.Split('/');
                DateTime T = new DateTime();
                T = DateTime.Now;
                String tmp = T.Date.ToString("d");
                string[] ND = tmp.Split('-');
                if (int.Parse(ND[2]) <= int.Parse(D[2]))
                {
                    if (int.Parse(ND[1]) <= int.Parse(D[1]))
                    {

                        if (int.Parse(ND[0]) < int.Parse(D[0]))
                        {
                            date = value;
                        }
                        else
                        {
                            date = "out_of_date";
                        }
                    }
                    else
                    {
                        date = "out_of_date";
                    }
                }
                else
                {
                    date = "out_of_date";
                }

            }
        }
        public class convinient
        {
            private static string CS_Name;
            private static int CS_Capital;
            public convinient()
            {
                CS_Name = "NULL";
                CS_Capital = 0;
            }
            public convinient(string name, int money = 0)
            {
                CS_Name = name;
                CS_Capital = money;
            }

        }
        public class Part_time_job_people : convinient
        {
            private string name;
            private int wage;
            private int[] working_day = new int[7];
            private int working_hour;
        }

    }

}
