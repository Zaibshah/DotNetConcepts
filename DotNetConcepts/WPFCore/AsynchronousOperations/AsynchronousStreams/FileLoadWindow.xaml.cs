using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPFCore.AsynchronousOperations.AsynchronousStreams
{
    /// <summary>
    /// Interaction logic for FileLoadWindow.xaml
    /// </summary>
    public partial class FileLoadWindow : Window
    {
        public FileLoadWindow()
        {
            InitializeComponent();
        }

        private async void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            IRecordsService recordsService = new RecordsService();
            ObservableCollection<Record> data = new ObservableCollection<Record>();

            ContentGrid.ItemsSource = data;

            await foreach (Record record in recordsService.GetRecordsFromFile())
            {
                data.Add(record);
            }
        }
    }
}
