using System.Collections.Generic;
using System.Windows.Documents;

namespace BibleVerseCard.Models
{
    public class Verses
    {
        public string Book_Id { get; set; }
        public string Book_Name { get; set; }
        public string Chapter { get; set; }
        public string Text { get; set; }
    }

    public class VersesByChapter
    {
        public int chapter { get; set; }

        public List<int> verseCount { get; set; } = new List<int>();
    }

    public class TheBible
    {
        public List<KeyValuePair<int, int>> keyValuePairs { get; set; }
    }
}
