using ConsoleApp1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int s1 = Opracoes.Sum(new int[] {2, 3});
            //int s2 = Opracoes.Sum(new int[] {2, 3, 4});

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);

            //----------------------------------------------------

            //int a = 10;
            //int triple;

            ////Opracoes.Triple(ref a);
            //Opracoes.Triple(a, out triple);
            //Console.WriteLine(triple);

            //----------------------------------------------------

            //Conjuntos

            //HashSet<int> A = new HashSet<int>();
            //HashSet<int> B = new HashSet<int>();

            //A.Add(3);
            //A.Add(5);
            //A.Add(8);
            //A.Add(9);

            //B.Add(3);
            //B.Add(4);
            //B.Add(5);

            //Remove itens do conjunto
            //B.Remove(4);

            //Remove itens do conjunto baseado nos número de outro conjunto
            //A.ExceptWith(B);

            //Adiciona itens no conjunto  baseado nos número de outro conjunto
            //A.UnionWith(B);
            //Mostra os itens do conjunto que estão presentes em outro conjunto
            //A.IntersectWith(B);

            //foreach (int x in A)
            //{
            //    Console.WriteLine(x);
            //}

            //Console.WriteLine("Digite um valor Inteiro: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //if (B.Contains(n))
            //{
            //    Console.WriteLine(n + " pertence ao Conjunto B.");
            //}
            //else
            //{
            //    Console.WriteLine(n + " não pertence ao Conjunto B.");
            //}


            //----------------------------------------------------

            //Exercicios Conjuntos


            //    HashSet<int> Joaquim = new HashSet<int>();

            //    Console.Write("O curso A possui quantos alunos? ");
            //    int Contador1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("----------------------------");

            //    for (int i = 0; i < Contador1; i++)
            //    {
            //        Joaquim.Add(Convert.ToInt32(Console.ReadLine()));
            //    }

            //    Console.Write("O curso B possui quantos alunos? ");
            //    int Contador2 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("----------------------------");

            //    for (int x = 0; x < Contador2; x++)
            //    {
            //        Joaquim.Add(Convert.ToInt32(Console.ReadLine()));
            //    }

            //    Console.Write("O curso C possui quantos alunos? ");
            //    int Contador3 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("----------------------------");

            //    for (int y = 0; y < Contador3; y++)
            //    {
            //        Joaquim.Add(Convert.ToInt32(Console.ReadLine()));
            //    }

            //    Console.WriteLine("----------------------------");

            //    Console.WriteLine("Total de alunos: " + Joaquim.Count.ToString());

            //----------------------------------------------------

            //Switch Case

            //int x = Convert.ToInt32(Console.ReadLine());

            //switch (x)
            //{
            //    case 1:
            //        Console.WriteLine("Domingo");
            //        break;
            //    case 2:
            //        Console.WriteLine("Segunda-Feira");
            //        break;
            //    case 3:
            //        Console.WriteLine("Terça-Feira");
            //        break;
            //    case 4:
            //        Console.WriteLine("Quarta-Feira");
            //        break;
            //    case 5:
            //        Console.WriteLine("Quinta-Feira");
            //        break;
            //    case 6:
            //        Console.WriteLine("Sexta-Feira");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sábado");
            //        break;
            //    default:
            //        Console.WriteLine("Esse número não representa nada!");
            //        break;
            //}

            //-------------------------------------------------------------------

            //Condição Ternária

            //double preco = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05 ;

            //Console.WriteLine(desconto);

            //-------------------------------------------------------------------

            //String Funções

            //string original = "abcde FGHIJ ABC abc DEFG";

            //string s1 = original.ToUpper();
            //string s2 = original.ToLower();
            //string s3 = original.Trim();
            //int n1 = original.IndexOf("bc");
            //int n2 = original.LastIndexOf("bc");

            //string s4 = original.Substring(3);
            //string s5 = original.Substring(3, 5);
            //string s6 = original.Replace('a', 'x');
            //string s7 = original.Replace("abc", "xy");

            //bool b1 = String.IsNullOrEmpty(original);
            //bool b2 = String.IsNullOrWhiteSpace(original);

            //Console.WriteLine("Original - " + original + " -");
            //Console.WriteLine("ToUpper - " + s1 + " -");
            //Console.WriteLine("ToLower - " + s2 + " -");
            //Console.WriteLine("Trim - " + s3 + " -");
            //Console.WriteLine("IndexOf - " + n1 + " -");
            //Console.WriteLine("Substring(3) - " + s4 + " -");
            //Console.WriteLine("Substring(3,5) - " + s5 + " -");
            //Console.WriteLine("Replace(a)(x) - " + s6 + " -");
            //Console.WriteLine("Repalce(abc)(xy) - " + s7 + " -");
            //Console.WriteLine("IsNullOrEmpty - " + b1 + " -");
            //Console.WriteLine("IsNullOrWhiteSpace - " + b2 + " - ");

            //-------------------------------------------------------------------

            //Date Time

            //DateTime d1 = new DateTime(2018,10,11);
            //DateTime d2 = new DateTime(2018, 10, 11, 20, 45, 3);

            //DateTime d3 = DateTime.Now;
            //DateTime d4 = DateTime.Today;
            //DateTime d5 = DateTime.UtcNow;

            //DateTime d6 = Convert.ToDateTime("2000-08-10");
            //DateTime d7 = Convert.ToDateTime("2000-08-10 13:05:08");
            //DateTime d8 = DateTime.ParseExact("2000-08-10", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            //DateTime d9 = DateTime.ParseExact("15/08/2019 13:21:09", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);
            //Console.WriteLine(d5);
            //Console.WriteLine(d6);
            //Console.WriteLine(d7);
            //Console.WriteLine(d8);
            //Console.WriteLine(d9);

            //DateTime d1 = new DateTime(2018, 10, 11, 13, 45, 58);
            //DateTime d2 = new DateTime(2011, 10, 11, 13, 45, 58);

            //Console.WriteLine(d1.ToLongDateString());
            //Console.WriteLine(d1.ToLongTimeString());
            ////Formato de Data Padrão
            //Console.WriteLine(d1.ToShortDateString());
            //Console.WriteLine(d1.ToShortTimeString());

            //string s1 = d1.ToString("yyyy-MM-dd HH:mm:ss");
            //string s2 = d1.ToString("yyyy-MM-dd HH:mm:ss:fff");


            //d1.AddHours(2);
            //d1.AddMinutes(10);

            //d1.AddDays(7);


            ////Subtrair datas
            //TimeSpan t = d1.Subtract(d2);

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);

            //-------------------------------------------------------------------

            //Time Span

            //TimeSpan t2 = new TimeSpan();
            //TimeSpan t3 = new TimeSpan(9000000000L);
            //TimeSpan t1 = new TimeSpan(0, 10, 36);
            //TimeSpan t4 = new TimeSpan(1,0, 10, 36);
            //TimeSpan t5 = new TimeSpan(1, 0, 10, 36, 341);



            //TimeSpan t6 = TimeSpan.FromDays(1.5) ;
            //TimeSpan t7 = TimeSpan.FromHours(1.5);
            //TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            //TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            //TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            //TimeSpan t11 = TimeSpan.FromTicks(900000000L);

            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);
            //Console.WriteLine(t4);
            //Console.WriteLine(t5);
            //Console.WriteLine(t6);
            //Console.WriteLine(t7);
            //Console.WriteLine(t8);
            //Console.WriteLine(t9);
            //Console.WriteLine(t10);
            //Console.WriteLine(t11);

            //-------------------------------------------------------------------

            //Time Span 2 
            //TimeSpan t1 = TimeSpan.MaxValue;
            //TimeSpan t2 = TimeSpan.MinValue;
            //TimeSpan t3 = TimeSpan.Zero;

            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);

            //TimeSpan t1 = new TimeSpan(1, 30, 10);
            //TimeSpan t2 = new TimeSpan(0, 10, 5);

            //TimeSpan sum = t1.Add(t2);
            //TimeSpan dif = t1.Subtract(t2);

            //Console.WriteLine(sum);
            //Console.WriteLine(dif);


            //-------------------------------------------------------------------

            //DateTime d1 = new DateTime(2005, 05, 13, 22, 0, 0, DateTimeKind.Utc);
            //DateTime d2 = new DateTime(2005, 05, 13, 23, 0, 0, DateTimeKind.Local);
            //DateTime d3 = new DateTime(2005, 05, 13, 23, 0, 0);

            //Console.WriteLine("d1: "+ d1);
            //Console.WriteLine("d1 Kind: " + d1.Kind);
            //Console.WriteLine("d1 to Local:" + d1.ToLocalTime());
            //Console.WriteLine("d1 to Utc:" + d1.ToUniversalTime());

            //Console.WriteLine("---------------------------------------");

            //Console.WriteLine("d2: " + d2);
            //Console.WriteLine("d2 Kind: " + d2.Kind);
            //Console.WriteLine("d2 to Local:" + d2.ToLocalTime());
            //Console.WriteLine("d2 to Utc:" + d2.ToUniversalTime());

            //Console.WriteLine("---------------------------------------");

            //Console.WriteLine("d3: " + d3);
            //Console.WriteLine("d3 Kind: " + d3.Kind);
            //Console.WriteLine("d3 to Local:" + d3.ToLocalTime());
            //Console.WriteLine("d3 to Utc:" + d3.ToUniversalTime());

            DateTime d1 = Convert.ToDateTime("2000-12-09 13:45:00");
            DateTime d2 = Convert.ToDateTime("2000-12-09T13:45:00Z");

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local:" + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc:" + d1.ToUniversalTime());

            Console.WriteLine("---------------------------------------");

            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local:" + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc:" + d2.ToUniversalTime());

            Console.WriteLine("d2 to Utc:" + d2.ToUniversalTime().ToString("2000-12-09T13:45:00Z"));







        }
    }
}

