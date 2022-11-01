using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleVerseCard.Models
{
    public class Verse
    {
        public int VerseId { get; set; }
        public int VerseNumber { get; set; }
        public int ChapterId { get; set; }
        public virtual Chapter Chapter { get; set; }
        public string Text { get; set; }
        public bool IsSelected { get; set; }
    }
}
