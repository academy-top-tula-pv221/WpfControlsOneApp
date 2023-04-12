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

namespace WpfControlsOneApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count = 0;
        public MainWindow()
        {
            InitializeComponent();
            Button btn = new();
            btn.Content = "Code button";
            btn.Width = 200;
            btn.Height = 100;
            ToolTip tip = new();
            StackPanel stack = new();
            TextBlock text = new();
            text.Text = "Tool tip";
            stack.Children.Add(text);
            tip.Content = stack;
            btn.ToolTip = tip;

            rootStack.Children.Add(btn);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            txtCounter.Text = (++count).ToString();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            popup.IsOpen = true;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            popup.IsOpen = false;
        }
    }
}
