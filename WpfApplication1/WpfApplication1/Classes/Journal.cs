using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WpfApplication1.Classes
{
    public class Journal
    {
        public Journal(string title)
        {
            Title = title;

            Entries = new ObservableCollection<JournalEntry>();
        }

        public string Title { get; private set; }

        public System.Collections.ObjectModel.ObservableCollection<JournalEntry> Entries { get; set; }
    }
}
