using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Application.ViewModels
{
    public class AnswersModel
    {
        public Item[] Items { get; set; }
        public bool HasMore { get; set; }
        public int BackOff { get; set; }
        public int QuotaMax { get; set; }
        public int QuotaRemaining { get; set; }
    }
}
