using MyJournal.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MyJournal
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        private JournalEntry currentEntry;

        public void LoadEntry(JournalEntry entry)
        {
            currentEntry = entry;

            textBox_EditTitle.Text = entry.Title;

            textBox_EditEntry.Text = entry.Entry;

            datePicker_EntryDate.SelectedDate = entry.EntryDate;
                   
        }

        public EditWindow()
        {
            InitializeComponent();
        }

        private void button_SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            // validation

            string title = textBox_EditTitle.Text;

            string entry = textBox_EditEntry.Text;

            JournalEntry editEntry = new JournalEntry();

            currentEntry.EntryDate = datePicker_EntryDate.SelectedDate.GetValueOrDefault(DateTime.Now);

            currentEntry.Title = title;

            currentEntry.Entry = entry;

            var mainWindow = (MainWindow)Owner;

            mainWindow.RefreshGrid();

            Close();
        }
    }
}
