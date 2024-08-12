using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using System.Windows;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        char key;
        char lastkey;

        List<char> Operaters;
        List<int[]> Nums;
        int lastrun = 0;

        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Calculator";
            this.ResizeMode = ResizeMode.CanMinimize;
            Operaters = new List<char>();
            Nums = new List<int[]>();
        }

        private void NumClick(object sender, RoutedEventArgs e)
        {
            BoxOfText.Text += ((int)sender.ToString().Last<char>() - 48);
            if (lastrun % 2 == 1)
            {
                Nums[1][lastrun] = (int)sender.ToString().Last<char>() - 48;
            }
            lastrun++;
        }

        private void OperaterClick(object sender, RoutedEventArgs e)
        {
            BoxOfText.Text += (int)sender.ToString().Last<char>();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            key = e.Key.ToString().Last<char>();
            if ((int)key >= 49
                && (int)key <= 58)
            {
                BoxOfText.Text += key;
            }
            if ((int)lastkey == 116 && (int)key == 115) BoxOfText.Text += " + ";
            else if ((int)key == 115) BoxOfText.Text += " - ";
            else if ((int)key == 88) BoxOfText.Text += " X ";
            else if (key == '=') BoxOfText.Text += " = ";
            lastkey = key;
        }
    }
}
