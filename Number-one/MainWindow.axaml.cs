using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using Tmds.DBus.Protocol;

namespace Number_one
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            yes.Click += Click_Yes;
        }

        public void Click_Yes(object sender, RoutedEventArgs args)
        {
            Window1 taskWindow = new Window1();
            taskWindow.Show();
            this.Close();
        }

        public void Click_No(object sender, RoutedEventArgs args)
        {
            char[] letters = "1234567890".ToCharArray();
            Random rnd = new Random();
            string phone = "";
            for (int j = 1; j <= 10; j++)
            {
                int letter_num = rnd.Next(0, letters.Length - 1);
                phone += letters[letter_num];
            }
            phone = "+7" + phone;
            message.Text = phone;
        }
    }
}