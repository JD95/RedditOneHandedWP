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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RedditWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string[] postTitles =
        {
            "fat kitty",
            "baby and her best friend",
            "My husband met a fox on duty",
            "Look, no one cares",
            "Pocket kitten!",
            "I'll take 20",
            "Underwater battle",
            "glitch art",
            "I made this!",
            "Someone should give him a push!"
        };

        public MainPage()
        {
            this.InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                var post = new RedditPost(this);
                post.setImage(i.ToString() + ".jpg");
                post.setText(postTitles[i]);
                this.posts.Items.Add(post);
            }

            radialMenu.setMenuOptions("upvote", switchToComments, 
                                      "downvote", switchToComments, 
                                      "comments", switchToComments);
        }

        public void switchToComments(object sender, RoutedEventArgs e)
        {
            postsPivot.SelectedIndex = 1;
            banishRadialMenu();
            radialMenu.setMenuOptions("upvote", switchToComments,
                                      "downvote", switchToComments,
                                      "posts", returnToPosts);
        }

        public void returnToPosts(object sender, RoutedEventArgs e)
        {
            postsPivot.SelectedIndex = 0;
            banishRadialMenu();
            radialMenu.setMenuOptions("upvote", switchToComments,
                                      "downvote", switchToComments,
                                      "comments", switchToComments);
        }

        public void summonRadialMenu()
        {
            radialMenu.Margin =  new Thickness(292, 507, 0, 0);
            radialMenu.IsEnabled = true;
            radialMenu.Visibility = Visibility.Visible;
            SummonRadialMenu.Begin();
        }

        public void banishRadialMenu()
        {
            radialMenu.Margin = new Thickness(292, 807, 0, -300);
            radialMenu.IsEnabled = false;
            radialMenu.Visibility = Visibility.Collapsed;
            BanishRadialMenu.Begin();
        }
    }
}
