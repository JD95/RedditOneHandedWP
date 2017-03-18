using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace RedditWP
{
    public sealed partial class RadialMenu : UserControl
    {

        public event RoutedEventHandler button1Click;
        public event RoutedEventHandler button2Click;
        public event RoutedEventHandler button3Click;


        public RadialMenu()
        {
            this.InitializeComponent();
            
        }

        public void setMenuOptions(string t1, RoutedEventHandler e1, string t2, RoutedEventHandler e2, string t3, RoutedEventHandler e3)
        {
            button1.Content = t1;
            button1Click = e1;

            button2.Content = t2;
            button2Click = e2;

            button3.Content = t3;
            button3Click = e3;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            button1Click?.Invoke(this, e);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            button2Click?.Invoke(this, e);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            button3Click?.Invoke(this, e);
        }
    }
}
