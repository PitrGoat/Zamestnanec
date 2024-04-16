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

namespace WpfApp1
{
    /// <summary>
    /// Interakční logika pro AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();
        }

        public string GetRecord()
        {
            string jmeno = Jmeno.Text;
            string prijmeni = Prijmeni.Text;
            string id = ID1.Text;
            string date = datePicker.SelectedDate?.ToShortDateString();
            return $"Jmeno: {jmeno}/  Příjmení: {prijmeni}/ ID : {id} - DATUM: {date}";
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}

