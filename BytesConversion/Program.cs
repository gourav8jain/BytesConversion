using System;
using System.Globalization;

namespace BytesConversion
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(Constants.InputNumber);
            var inputParameter = Convert.ToInt64(Console.ReadLine());
            var result = Utility.ConvertBytesToReadableFormat(inputParameter);
            Console.WriteLine(string.Format(Constants.ConvertedValue, result));
        }
    }
}
