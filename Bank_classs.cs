using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligate_demo
{
    

        //Create a Bank class
        //Initialize balance in the constructor
        //Class must have two methods 1. Credit 2. Debit
        //If User debit the amount which is greater than balance , raise an event “Insufficient balance”
        //If balance is less than 3000, raise an event “Low balance”
        //If balance is zero then raise an event “Zero balance”

        //Credit will add amount to the balance

        //public delegate void DelegateHandler();
        //public class Student
        //{
        //    // declaration of event
        //    public event DelegateHandler Fail;
        //    public event DelegateHandler Pass;
        //    public void AcceptScore(int score)
        //    {
        //        if (score < 40)
        //        {
        //            // raise an event
        //            Fail();
        //        }
        //        else
        //        {
        //            Pass();
        //        }
        //    }
        //}
        public delegate void DelegtaHandler();
        public class EventsDemo
        {
            public int bal;
            //public int credit;
            //public int debit;
            int amount;


            public event DelegtaHandler LowBal;
            public event DelegtaHandler ZeroBal;
            public event DelegtaHandler InsufficientBal;

            public EventsDemo()
            {
                amount = 1000;
            }
            public void Credit(int amount)
            {
                bal += amount;
                Console.WriteLine(bal);
            if (bal <= 3000)
            {
                LowBal();
            }
            else
            {
                Console.WriteLine(bal);
            }
        }
            public void Debit(int amount)
            {
                bal -= amount;
                if (bal < 3000)
                {
                    LowBal();
                }
                else if (bal == 0)
                {
                    ZeroBal();
                }
                else if (amount < bal)
                {
                    InsufficientBal();
                }

                else
                {
                    Console.WriteLine(bal);
                }
                Console.WriteLine(bal);

            }
           


        }
    }

