using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligate_demo
{
    public class Bankdetails
    {
        //using System;
//using System.Diagnostics;
//using System.Security.Claims;

//namespace CrudOpe.Events
//{
//    public class Program
//    {
//        static void FailMessage()
//        {
//            Console.WriteLine("OOps ! You are fail");
//        }
//        static void PassMessage()
//        {
//            Console.WriteLine("Great ! You are Pass with good score");
//        }
//        static void Main(string[] args)
//        {
//            Student stud = new Student();
//            // bind event with delegate
//            stud.Fail += new DelegateHandler(FailMessage);
//            stud.Pass += new DelegateHandler(PassMessage);

//            stud.AcceptScore(73);
//        }
//    }




//    Create a Bank class
//    Initialize balance in the constructor
//Class must have two methods 1. Credit 2. Debit
//If User debit the amount which is greater than balance , raise an event “Insufficient balance”
//If balance is less than 3000, raise an event “Low balance”
//If balance is zero then raise an event “Zero balance”

//Credit will add amount to the balance

//}


;


   
        

        
            static void LowBal()
            {
                Console.WriteLine("Low Balalnce");

            }
            static void Insufficientbal()
            {
                Console.WriteLine("Insufficient Bal::");
            }
            static void ZeroBal()
            {
                Console.WriteLine("ZeroBal::");
            }
            public static void Main(string[] args)
            {

                EventsDemo eventsDemo = new EventsDemo();
                eventsDemo.LowBal += new DelegtaHandler(LowBal);
                eventsDemo.ZeroBal += new DelegtaHandler(ZeroBal);
                eventsDemo.InsufficientBal += new DelegtaHandler(Insufficientbal);

                eventsDemo.Credit(10000);
                eventsDemo.Debit(9000);
                eventsDemo.Debit(1000);
            }
        }
    }



