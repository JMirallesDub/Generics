using System;

namespace Generics
{
    public class Author
    {
        public Author(string name, short age, string title, bool mvp, DateTime pubdate)
        {
            Name = name;
            Age = age;
            BookTitle = title;
            IsMvp = mvp;
            PublishedDate = pubdate;
        }

        public string Name { get; set; }

        public short Age { get; set; }

        public string BookTitle { get; set; }

        public bool IsMvp { get; set; }

        public DateTime PublishedDate { get; set; }
    }
}