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
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace DoctorWPF
{
    /// <summary>
    /// Interaction logic for Journal.xaml
    /// </summary>
    public partial class Journal : Window
    {
      

        //string DbConnectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Doctor;Integrated Security=True;Pooling=False";
        public Journal()
        {
            InitializeComponent();
           
            //_NavigationFrame.Navigate(new Journal());
            //this.NavigationService.Navigate(new Uri("DoctorWPF/Result.xaml", UriKind.Relative));
        }
    //    public object NavigationService { get; private set; }

    //    private void textBox_socker_TextChanged(object sender, TextChangedEventArgs e)
    //    {
    //        int socker;
    //        bool isNumber = int.TryParse(textBox_S.Text, out socker);



    //        if (socker >= 120 && socker <= 125)
    //        {

    //            MessageBox.Show("your socker is normal");

    //        }
    //        else if (socker < 120)
    //        {
    //            MessageBox.Show("your socker is too low");
    //        }
    //        else
    //        { 
    //            MessageBox.Show("your socker is tooo high");
    //        }
    //    }
    //    private void textBox_B_TextChanged(object sender, TextChangedEventArgs e)
    //    {

    //    }

    //    private void textBox_C_TextChanged(object sender, TextChangedEventArgs e)
    //    {

    //    }

    //    private void button_Click(object sender, RoutedEventArgs e)
    //    {
    //        int socker;
    //        bool isNumber = int.TryParse(textBox_S.Text, out socker);



    //        if (socker == 0)
    //        {

    //            MessageBox.Show("your socker is toooo low");

    //        }
    //    }


    //}

    //private void textBox_B_TextChanged(object sender, TextChangedEventArgs e)
    //{
    //    if (textBox_B.Text != null)
    //    {
    //        string address = textBox_B.Text;
    //        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Doctor;Integrated Security=True;Pooling=False");
    //    }
    //    else
    //    {
    //        textBox_B.Focus();
    //    }
    //}
    //private void textBox_C_TextChanged(object sender, TextChangedEventArgs e)
    //{
    //    if (textBox_C.Text != null)
    //    {
    //        string address = textBox_C.Text;
    //        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Doctor;Integrated Security=True;Pooling=False");
    //    }
    //    else
    //    {
    //        textBox_B.Focus();
    //    }
    //}
    //private void textBox_socker_TextChanged(object sender, TextChangedEventArgs e)
    //{
    //    if (textBox_S.Text != null)
    //    {
    //        string address = textBox_S.Text;
    //        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Doctor;Integrated Security=True;Pooling=False");
    //    }
    //    else
    //    {
    //        textBox_B.Focus();
    //    }
    //}
    //private void button_Click(object sender, RoutedEventArgs e)
    //{

    //}
}
