using System;
using System.Collections;
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
using System.Windows.Threading;
using System.Diagnostics;

namespace MemoryGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        int initialScore = 500000;
        string[] primary = new string[36];
        Stopwatch showTime = new Stopwatch();
        int attempts = 0;
        int timeCounter = 0;
        int matches = 0;
        int totalAttempts = 0;
        GameState status = GameState.RUNNING;


        Image[] imgs;

        GenerateArray instantiate = new GenerateArray();
        ImageSourceConverter s = new ImageSourceConverter();

        DispatcherTimer mainTimer = new DispatcherTimer();
        

        Image click1;
        Image click2;

        DispatcherTimer timeDelay = new System.Windows.Threading.DispatcherTimer();  // THIS SHIT CREATE A FUCKING TIMER

        public MainWindow()
        {
            InitializeComponent();
           
            easyLbl.Content = Level.Easy;
            medLbl.Content = Level.Medium;
            hrdLbl.Content = Level.Hard;
            xtrmLbl.Content = Level.Extreme;

            
            shapeLbl1.Content = Theme.SHAPE;
            shapeLbl1.IsSelected = true;
            gameLbl1.Content = Theme.GAME;
            memeLbl1.Content = Theme.MEME;

            timeDelay.Tick += new EventHandler(timer_Tick);
            timeDelay.Interval = new TimeSpan(0, 0, 1);

            mainTimer.Tick += mainTimer_Tick;
            mainTimer.Interval = new TimeSpan(0, 0, 1);

           

            // Store all the name of images in the 6 x 6
            imgs = new Image[] {img1, img2, img3, img4, img5, img6, img7, img8, img9, img10,
                                img11, img12, img13, img14, img15, img16, img17, img18, img19,
                                img20, img21, img22, img23, img24, img25, img26, img27, img28,
                                img29, img30, img31, img32, img33, img34, img35, img36};

            // generate random array of image
            
            TimerDisplayTxt.Content = showTime.Elapsed;
        }

        private void timer_Tick(object sender, EventArgs e)
        {


            timeDelay.Stop();
            showTime.Start();
            IsHitTestVisible = true;
            ReturnToDefault(click1, click2);
            click1 = null;
            click2 = null;
            if (attempts >= getMaxAttempt())
            {
                for (int i = 0; i < imgs.Length; i++)
                {
                    imgs[i].Source = (ImageSource)s.ConvertFromString(@"..\..\Pictures\Random.jpg");
                }

                matches = 0;
                attempts = 0;
            }
        }

        // Check if 2 images are equal to each other by comparing their souce
        private Boolean match(Image click1, Image click2)
        {
            if (click1.Source.ToString().Equals(click2.Source.ToString()))
            {
                return true;
            }
            return false;
        }

        // Return the images that are on click back to their default sources.
        private void ReturnToDefault(Image click1, Image click2)
        {
            click1.Source = (ImageSource)s.ConvertFromString(@"..\..\Pictures\Random.jpg");  // P.H
            click2.Source = (ImageSource)s.ConvertFromString(@"..\..\Pictures\Random.jpg");  // P.H
        }

        // Determine main game's logic. If the 2 images match, make them unclickable and visible.
        private void OnClick(Image clickedImage)
        {
            status = GameState.RUNNING;
            
            if (!showTime.IsRunning)
            {
                levelMenu.IsEnabled = false;
                themeMenu.IsEnabled = false;
                mainTimer.Start();
                showTime.Start();
            }


            if (click1 == null)
            {
                click1 = clickedImage;
            }
            else if (click1 != null && click2 == null)
            {
                click2 = clickedImage;
                if (click1 != click2)
                {
                    if (match(click1, click2))
                    {
                        attempts = 0;
                        click1.IsEnabled = false;
                        click2.IsEnabled = false;
                        click1 = null;
                        click2 = null;
                        matches++;

                        if (matches == 18)
                        {
                            mainTimer.Stop();
                            scoreLbl.Content = (initialScore * (int)(Level)((ComboBoxItem)levelMenu.SelectedItem).Content) / (timeCounter * totalAttempts);
                        }
                    }
                    else
                    {
                        IsHitTestVisible = false;
                        timeDelay.Start();
                        attempts++;
                        showTime.Stop();
                        totalAttempts++;
                        TotalAttempsTxt.Content = totalAttempts;
                        AttempsLeftTxt.Content = getMaxAttempt() - attempts;


                       

                    }
                }
                else
                {

                    click2 = null;
                }
            }
        }



        private void Img_Clicked(object sender, MouseButtonEventArgs e)
        {
            int i = Array.IndexOf(imgs, ((Image)sender));

            ((Image) sender).Source = (ImageSource)s.ConvertFromString(primary[i].ToString());
            OnClick((Image) sender);
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            TimerDisplayTxt.Content = showTime.Elapsed;
            timeCounter++;
        }

        private void restartBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private int getMaxAttempt()
        {

            return LevelUtil.getAttempts((Level)((ComboBoxItem)levelMenu.SelectedItem).Content);
        }

        private void themeMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem a = (ComboBoxItem)themeMenu.SelectedItem;

            Theme b = (Theme)a.Content;

            primary = instantiate.randomizeImagePosition(b);
        }
    }
}
