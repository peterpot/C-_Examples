using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime? date = null;
            DateTime date = new DateTime();

            if (date == DateTime.MinValue)
                Console.WriteLine("Instance new DateTime() is DateTime.MinValue");
            Console.WriteLine();

            Write("date = new DateTime()", date);

            date = DateTime.MinValue;
            Write("date = DateTime.MinValue", date);

            int? intVal = null;
            decimal? decVal = null;
            double? doubleVal = null;
            float? floatVal = null;
            bool? boolVal = null;
            string strVal = null;

            Console.WriteLine("intVal: " + intVal);
            Console.WriteLine("decVal: " + decVal);
            Console.WriteLine("doubleVal: " + doubleVal);
            Console.WriteLine("floatVal: " + floatVal);
            Console.WriteLine("boolVal: " + boolVal);
            Console.WriteLine("strVal: " + strVal);
            Console.WriteLine();

            Console.WriteLine("intVal: " + (intVal == null));
            Console.WriteLine("decVal: " + (intVal == null));
            Console.WriteLine("doubleVal: " + (intVal == null));
            Console.WriteLine("floatVal: " + (intVal == null));
            Console.WriteLine("boolVal: " + (intVal == null));
            Console.WriteLine("strVal: " + (strVal == null));
            Console.WriteLine();

            Console.WriteLine("intVal: " + intVal.HasValue);
            Console.WriteLine("decVal: " + decVal.HasValue);
            Console.WriteLine("doubleVal: " + doubleVal.HasValue);
            Console.WriteLine("floatVal: " + floatVal.HasValue);
            Console.WriteLine("boolVal: " + boolVal.HasValue);
            Console.WriteLine("strVal: " + (strVal != null));
            Console.WriteLine();

            intVal = 0;
            decVal = 0;
            doubleVal = 0;
            floatVal = 0;
            boolVal = false;
            strVal = "";

            Console.WriteLine("intVal: " + intVal);
            Console.WriteLine("decVal: " + decVal);
            Console.WriteLine("doubleVal: " + doubleVal);
            Console.WriteLine("floatVal: " + floatVal);
            Console.WriteLine("boolVal: " + boolVal);
            Console.WriteLine("strVal: " + strVal);

            Console.ReadKey();
        }

        static void Write(string msg, DateTime date)
        {
            Console.WriteLine("=== " + msg + " ===");

            // bool hasValue = date.HasValue;

            // Console.WriteLine("date.HasValue = " + hasValue);

            // Console.WriteLine("date.Value = " + hasValue);

            Console.WriteLine("(date == null) = " + (date == null));

            Console.WriteLine("date =  " + date);

            Console.WriteLine("date.ToString() =  " + date.ToString());

            // if is Nullable (DateTime?) - you can NOT format:
            Console.WriteLine("date.ToString('d') =  " + date.ToString("d"));

            Console.WriteLine();
        }
    }
}
