using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleVerseCard.Models
{
    public  class Chapter
    {
        public int ChapterId { get; set; }
        public int ChapterNumber { get; set; }
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public int MaxVerses { get; set; }
        public bool? IsSelected { get; set; }
        public virtual ICollection<Verse> Verses { get; private set; } = new ObservableCollection<Verse>();
    }
}
