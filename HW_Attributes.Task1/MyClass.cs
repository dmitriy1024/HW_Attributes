using System;

namespace HW_Attributes.Task1
{
    class MyClass
    {
        [ForPrint(Color = ConsoleColor.Blue)]
        public string One { get; private set; }

        [ForPrint(Color = ConsoleColor.Red)]
        public string Two { get; private set; }

        public string Three { get; private set; }

        public string Four { get; private set; }

        [ForPrint(Color = ConsoleColor.Green)]
        public string Five { get; private set; }

        public MyClass()
        {
            One = "One";
            Two = "Two";
            Three = "Three";
            Four = "Four";
            Five = "Five";
        }
    }
}
