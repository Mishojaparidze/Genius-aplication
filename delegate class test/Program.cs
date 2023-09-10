using System;
using System.IO;
using System.Net.Mail;
using System.Threading.Channels;

namespace delegate_class_test
{
    public delegate void DelegateFirst(string message);
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Account account = new Account();
            //    account.SetDelegate(x => Console.WriteLine(x));
            //    account.SetDelegate(x => {
            //        string path = @"C:\Users\misho\Desktop\New folder\file.txt";
            //        File.AppendAllText(path, x + Environment.NewLine);
            //    });
            //    account.FillBalance(7894);
            //    account.WithdrawBalance(4578);
            //    int[] array = new int[] { 1, 2, 3 };

            Age_Calculator_OK age_Calculator_OK = new Age_Calculator_OK()
            {
                CurrentYear = new DateTime(2022,12,1)
            };

            Age_Validator ageValidator = new Age_Validator();
            ageValidator.isYEarValid(new DateTime(2020,1,1), age_Calculator_OK);
            age_Calculator_OK.calcuateAge(new DateTime(2011,3,1));
            Console.WriteLine(  );


            Console.WriteLine("mishos branchis damateba");

        }

    }
    public class Age_Calculator_OK
    {
        public DateTime CurrentYear { get; set; }


        public void calcuateAge(DateTime birthdate)
        {
            Console.WriteLine(CurrentYear.Year - birthdate.Year);
        }

    }
    public class Age_Validator
    {
        public void isYEarValid(DateTime birthdate, Age_Calculator_OK age)
        {

            if (age.CurrentYear.Year < birthdate.Year)
            {
                Console.WriteLine("Is not Valid");
            }
        }
    }
}








//    interface IIinterface1
//    {
//        void Method();
//    }

//    public interface IIinterface2
//    {
//        void Method();
//    }
//    class ConcreteClass : IIinterface2, IIinterface1
//    {
//         void IIinterface1.Method()
//        {
//            Console.WriteLine("Implemented 1 ");
//        }

//        public  void IIinterface2.Method()
//        {
//            Console.WriteLine("Implemented 2 ");
//        }
//    }

//    public class Account
//    {
//        DelegateFirst delegateFirst;
//        public decimal Balance;
//        public Account()
//        {
//               Balance = 1500;
//        }
//        public void FillBalance(decimal x) 
//        { 
//            Balance += x;
//            if (delegateFirst!=null)
//            {
//                Console.WriteLine ($"Balance has filled with {x} Gel amount,your Balance on the account is {Balance} ");
//                string path = @"C:\Users\misho\Desktop\New folder\file.txt";
//                File.AppendAllText(path, x + Environment.NewLine);
//            }  
//        }
//        public void WithdrawBalance(decimal y)
//        {
//            if (Balance >= y)
//            {
//                Balance -= y;
//                if (delegateFirst != null)
//                {
//                    delegateFirst($"Balance has withdrawn with {y} Gel amount,your Balance on the account is {Balance}");
//                }
//            }
//            else
//            {
//                if (delegateFirst != null)
//                    Console.WriteLine ("insufficient amount");
//            }

//        }
//        public void SetDelegate(DelegateFirst delegateFirst)
//        {
//            this.delegateFirst += delegateFirst;
//        }

//        static void Something(string x)
//        {
//            Console.WriteLine(  x);
//        }
//        static string Something(string x, string y)
//        {
//            Console.WriteLine(x);
//            return x+y;
//        }
//        static string Something(string x, string y, string t)
//        {
//            return x + y+t;
//        }



//    }
//}
