using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Book // Я понимаю что все Поля по умолчанию private, но для себя я все равно помечаю их как private, возможно для удобства, возможно привычка с Java. 
    {
        private Title title = null;
        private Content content = null;
        private Author author = null;

        private void InitializeBook()
        {
            this.title = new Title();
            this.content = new Content();
            this.author = new Author();
        }

        public Book(string title)
        {
            InitializeBook();
            this.title.Content = title;
        }

        public void Show()
        {
            this.title.Show();
            this.content.Show();
            this.author.Show();
        }

        public string Content
        {
            set
            {
                this.content.Text = value;
            }
        }

        public string Author
        {
            set
            {
                this.author.Content = value;
            }
        }
    }
}
