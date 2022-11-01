using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleVerseCard.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public int MaxChapter { get; set; }
        public bool? IsSelected { get; set; }
        public virtual ICollection<Chapter> Chapters { get; private set; } = new ObservableCollection<Chapter>();
    }
}
