using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class Notebook
        {
            private string company;
            private string type;
            private int price;
            public void Show()
            {
                Console.WriteLine($"Производитель {company}  Тип {type}  Цена {price} ");
            }

            public Notebook()
            {
                company = "Samsung "; type = "UltraBook "; price = 50000;
            }
            public Notebook(string n)
            {
                type = n;
            }
            public Notebook(string s, string n, int p) : this(n)
            {
                company = s; this.price = p;
            }
            public int Price()
            {
                return price;
            }
            public string Type()
            {
                return type;
            }
        }           
                static void Main()
                {
                    string s, n;
                    int p, SumPrice, UltraB, Aprice;
                    Aprice = 0;
                    SumPrice = 0;
                    UltraB = 1;
                    s = "Asus";
                    n = "Netbook";
                    p = 30000;
                    Notebook notebook1 = new Notebook();
                    notebook1.Show();           
                    Notebook notebook2 = new Notebook(s, n, p);
                    notebook2.Show();                   
                    Notebook[] T = new Notebook[5];
                    n = "Ultrabook";
                    for (int i = 0; i < T.Length; i++)
                    {
                        T[i] = new Notebook(s, n, (10000*(i)+20000));
                    }
                    for (int i = 0; i < T.Length; i++)
                    {
                        T[i].Show();
                    }
                    for (int i = 0; i < T.Length; i++)
                    {
                        SumPrice+= T[i].Price();
                        Aprice = SumPrice / T.Length;
                        if (T[i].Type() == "Ultrabook")
                        {
                            UltraB++;
                        }
                    }
                    Console.WriteLine($"Средняя стоимость {Aprice} ");
                    Console.WriteLine($"Количество ультрабуков {UltraB}");
                }
    }
}
    



