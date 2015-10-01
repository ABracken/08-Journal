using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyJournal.Classes
{
    public class Journal
    {
        public Journal(string title)
        {
            Title = title;

            Entries = new ObservableCollection<JournalEntry>();
        }

        public string Title { get; private set; }

        public ObservableCollection<JournalEntry> Entries { get; set; }
    }
}
