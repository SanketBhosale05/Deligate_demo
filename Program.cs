//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Deligate_demo
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Calculation c = new Calculation();
//            // c.Add --> added method reference
//            MyDelegate myDelegate = new MyDelegate(c.Add);
//            myDelegate += new MyDelegate(c.sub);

//            Delegate[] list = myDelegate.GetInvocationList();

//            foreach (Delegate d in list)
//            {
//                Console.WriteLine(d.Method);
//                Console.WriteLine(d.DynamicInvoke(52,69));
//            }
            

//            //Console.WriteLine(myDelegate.Invoke(20, 30));

//            //Test t1 = new Test();

//            //Delegate1 d1 = new Delegate1(t1.AcceptDetails);

//            //d1.Invoke(1, "sanket", 500000);

            
                

//        }
//    }
//}
