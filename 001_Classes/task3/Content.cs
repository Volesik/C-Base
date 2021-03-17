using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Content
    {
        private string text;

        public string Text
        {
            private get
            {
                return text;
            }
            set
            {
                text = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
