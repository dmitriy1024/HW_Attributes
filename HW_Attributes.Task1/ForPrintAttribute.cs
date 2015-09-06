using System;

namespace HW_Attributes.Task1
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    class ForPrintAttribute : Attribute
    {
        public ConsoleColor Color = ConsoleColor.Gray;

        public ForPrintAttribute() { }
    }
}
