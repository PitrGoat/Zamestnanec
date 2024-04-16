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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddRecord_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addRecordWindow = new AddWindow();
            if (addRecordWindow.ShowDialog() == true)
            {
                listBox.Items.Add(addRecordWindow.GetRecord());
            }
        }

        private void DeleteRecord_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                listBox.Items.Remove(listBox.SelectedItem);
            }
        }
        private void EditZamestnance_Click(object sender, RoutedEventArgs e) 
        {
          EditEmployee editEmployee = new EditEmployee();

            if (editEmployee.ShowDialog() == true)
            {
                listBox.Items.Refresh();
            }
        }

        
    }
}
