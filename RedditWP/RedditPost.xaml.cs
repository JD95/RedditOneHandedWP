﻿using System;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace RedditWP
{
    public sealed partial class RedditPost : UserControl
    {
        MainPage main;
        
        public RedditPost(MainPage m)
        {
            this.main = m;
            this.InitializeComponent();
        }

        public void setImage(string filepath)
        {
            var pic = new BitmapImage(new Uri(@"ms-appx:///Assets/RedditPics/"+filepath));
            this.image.Source = pic;
        }

        public void setText(string text)
        {
            this.textBlock.Text = text;
        }

        public void focusPost()
        {
            this.postOptions.Visibility = Visibility.Visible;
            this.selectPost.Visibility = Visibility.Collapsed;
        }

        public void unfocusPost()
        {
            this.postOptions.Visibility = Visibility.Collapsed;
            this.selectPost.Visibility = Visibility.Visible;
        }

        public void hide()
        {
            hidden.Visibility = Visibility.Visible;
        }

        public void unhide()
        {
            hidden.Visibility = Visibility.Collapsed;
        }

        private void menu_Click(object sender, RoutedEventArgs e)
        {
            main.summonRadialMenu();
        }
        public void nightMode()
        {
            this.postOptions.Background = new SolidColorBrush(Windows.UI.Colors.White);
            this.postGrid.Background = new SolidColorBrush(Windows.UI.Colors.Black);
            this.textBlock.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
        }
    }
}
