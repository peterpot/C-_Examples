using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Accelarate(20);

            // MULTIPLE EXCEPTIONS:
            try
            {            
                c.Accelarate(10000);
            }
            catch (CarIsBrokenException exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.CauseOfError);
                Console.WriteLine(exc.ErrorTimeStamp);
                Console.WriteLine(exc.StackTrace);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            // EXCEPTION FILTERS:
            try
            {
                c.Accelarate(10000);
            }
            catch (CarIsBrokenException fe) when (fe.ErrorTimeStamp.DayOfWeek != DayOfWeek.Friday) // FILTER
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine(fe.CauseOfError);
                Console.WriteLine(fe.ErrorTimeStamp);
                Console.WriteLine(fe.StackTrace);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            Console.ReadLine();
        }
    }

    class Car
    {
        public void Accelarate(int delta)
        {
            // ....
            if (delta > 9000)
            {
                CarIsBrokenException exc = new CarIsBrokenException(message: "The engine is overheated!",
                    cause: "You have a lead foot!", time: DateTime.Now);
                exc.HelpLink = "http:www.porcshe.com";
                throw exc;
            }
        }
    }

    // ----------
    // EXAMPLE 1:
    // ----------
    class CarIsBrokenException : ApplicationException
    {
        private string messageDetails = string.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsBrokenException() {}

        public CarIsBrokenException(string message, string cause, DateTime time) {
            messageDetails = message;
            CauseOfError = cause;
            time = ErrorTimeStamp;
        }

        public override string Message
        {
            get
            {
                return string.Format("Car Error Message: {0}", messageDetails); 
            }
        }
    }

    // ----------
    // EXAMPLE 2:
    // ----------
    // THIS WORKS THE SAME AS EXAMPLE 1:
    class CarIsBrokenException2 : ApplicationException
    {
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsBrokenException2(string message, string cause, DateTime time) : base(message)
        {
            CauseOfError = cause;
            time = ErrorTimeStamp;
        }
    }
}
