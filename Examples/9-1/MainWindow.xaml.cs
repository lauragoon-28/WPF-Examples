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

namespace _9_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //TextBox txt1 = new TextBox();
            //txt1.Text = "Hello World";

            lbloutput.Visibility = Visibility.Hidden;

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            string dob = txtDOB.Text;
            string name = txtName.Text;

            DateTime birthdate = Convert.ToDateTime(dob);
            TimeSpan age = DateTime.Now - birthdate;

            //MessageBox.Show((age.TotalDays / 365).ToString());
            double old = age.TotalDays / 365;
            lbloutput.Content = $"Hello {name}, you are {old.ToString("N2")} years old!!";
            lbloutput.Visibility = Visibility.Visible;
        }
    }
}
