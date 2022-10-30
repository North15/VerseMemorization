﻿using System.Collections.Generic;

namespace BibleVerseCard.Models
{
    public class APIResponse
    {
        public string Reference { get; set; }
        public List<Verses> Verses { get; set; }
        public string Text { get; set; }
        public string Translation_Id { get; set; }
        public string Translation_Name { get; set; }
        public string Translation_Note { get; set; }
    }
}