using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Author
    {
        private string content;

        public string Content
        {
            private get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
