using System;

namespace HW_Attributes.Task1
{
    class Printer
    {   
        public void Print<T>(T obj)
        {
            var properties = obj.GetType().GetProperties();
            foreach (var item in properties)
            {
                var attributes = item.GetCustomAttributes(typeof(ForPrintAttribute),false);
                if(attributes.Length > 0)
                {
                    var printAttr = attributes[0] as ForPrintAttribute;

                    if (printAttr != null)
                    {
                        Console.ForegroundColor = printAttr.Color;
                        Console.WriteLine(item.GetValue(obj).ToString());
                        Console.ResetColor();
                    }
                }                
            }
        }
    }
}
