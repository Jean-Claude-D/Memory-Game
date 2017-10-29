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

namespace MemoryGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] primary = new string[36];
       // string[] secondary;
        Image[] imgs;

        GenerateArray instantiate = new GenerateArray();
        ImageSourceConverter s = new ImageSourceConverter();

        Image click1;
        Image click2;
        //int numClicks = 0;
        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();  //THIS SHIT CREATE A FUCKING TIMER

        public MainWindow()
        {
            InitializeComponent();

            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);

            // Store all the name of images in the 6 x 6
            imgs = new Image[] {img1, img2, img3, img4, img5, img6, img7, img8, img9, img10,
                                img11, img12, img13, img14, img15, img16, img17, img18, img19,
                                img20, img21, img22, img23, img24, img25, img26, img27, img28,
                                img29, img30, img31, img32, img33, img34, img35, img36};

            // generate random array of image
            primary = instantiate.randomizeImagePosition(@"..\..\Pictures\Shapes");

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            ReturnToDefault(click1, click2);
           // numClicks = 0;
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
            if (click1 == null)
            {
                click1 = clickedImage;
            }
            else if (click1 != null && click2 == null)
            {
                click2 = clickedImage;
            }
            else if (click1 != null && click2 != null)
            {
                if (match(click1, click2))
                {

                    click1.IsEnabled = false;
                    click2.IsEnabled = false;

                }
                else
                    timer.Start();
                    //ReturnToDefault(click1, click2);
                    //numClicks = 0;
            }
        }

        //private void imgHandler(object sender, MouseButtonEventArgs e)
        //{
        //    int i = Array.IndexOf(imgs, ((Image)sender));

        //    ((Image)sender).Source = (ImageSource)s.ConvertFromString(primary[i]);

        //}

        private void img1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img1.Source = (ImageSource)s.ConvertFromString(primary[0].ToString());
            OnClick(img1);
            
        }

        private void img2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img2.Source = (ImageSource)s.ConvertFromString(primary[1].ToString());
            OnClick(img2);
        }

        private void img3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img3.Source = (ImageSource)s.ConvertFromString(primary[2].ToString());
            OnClick(img3);
        }

        private void img4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img4.Source = (ImageSource)s.ConvertFromString(primary[3].ToString());
            OnClick(img4);
        }

        private void img5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img5.Source = (ImageSource)s.ConvertFromString(primary[4].ToString());
            OnClick(img5);
        }

        private void img6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img6.Source = (ImageSource)s.ConvertFromString(primary[5].ToString());
            OnClick(img6);
        }

        private void img7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img7.Source = (ImageSource)s.ConvertFromString(primary[6].ToString());
            OnClick(img7);
        }

        private void img8_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img8.Source = (ImageSource)s.ConvertFromString(primary[7].ToString());
            OnClick(img8);
        }

        private void img9_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img9.Source = (ImageSource)s.ConvertFromString(primary[8].ToString());
            OnClick(img9);
        }

        private void img10_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img10.Source = (ImageSource)s.ConvertFromString(primary[9].ToString());
            OnClick(img10);
        }

        private void img11_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img11.Source = (ImageSource)s.ConvertFromString(primary[10].ToString());
            OnClick(img11);
        }

        private void img12_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img12.Source = (ImageSource)s.ConvertFromString(primary[11].ToString());
            OnClick(img12);
        }

        private void img13_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img13.Source = (ImageSource)s.ConvertFromString(primary[12].ToString());
            OnClick(img13);
        }

        private void img14_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img14.Source = (ImageSource)s.ConvertFromString(primary[13].ToString());
            OnClick(img14);
        }

        private void img15_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img15.Source = (ImageSource)s.ConvertFromString(primary[14].ToString());
            OnClick(img15);
        }

        private void img16_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img16.Source = (ImageSource)s.ConvertFromString(primary[15].ToString());
            OnClick(img16);
        }

        private void img17_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img17.Source = (ImageSource)s.ConvertFromString(primary[16].ToString());
            OnClick(img17);
        }

        private void img18_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img18.Source = (ImageSource)s.ConvertFromString(primary[17].ToString());
            OnClick(img18);
        }

        private void img19_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img19.Source = (ImageSource)s.ConvertFromString(primary[18].ToString());
            OnClick(img19);
        }

        private void img20_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img20.Source = (ImageSource)s.ConvertFromString(primary[19].ToString());
            OnClick(img20);
        }

        private void img21_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img21.Source = (ImageSource)s.ConvertFromString(primary[20].ToString());
            OnClick(img21);
        }

        private void img22_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img22.Source = (ImageSource)s.ConvertFromString(primary[21].ToString());
            OnClick(img22);
        }

        private void img23_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img23.Source = (ImageSource)s.ConvertFromString(primary[22].ToString());
            OnClick(img23);
        }

        private void img24_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img24.Source = (ImageSource)s.ConvertFromString(primary[23].ToString());
            OnClick(img24);
        }

        private void img25_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img25.Source = (ImageSource)s.ConvertFromString(primary[24].ToString());
            OnClick(img25);
        }

        private void img26_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img26.Source = (ImageSource)s.ConvertFromString(primary[25].ToString());
            OnClick(img26);
        }

        private void img27_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img27.Source = (ImageSource)s.ConvertFromString(primary[26].ToString());
            OnClick(img27);
        }

        private void img28_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img28.Source = (ImageSource)s.ConvertFromString(primary[27].ToString());
            OnClick(img28);
        }

        private void img29_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img29.Source = (ImageSource)s.ConvertFromString(primary[28].ToString());
            OnClick(img29);
        }

        private void img30_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img30.Source = (ImageSource)s.ConvertFromString(primary[29].ToString());
            OnClick(img30);
        }

        private void img31_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img31.Source = (ImageSource)s.ConvertFromString(primary[30].ToString());
            OnClick(img31);
        }

        private void img32_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img32.Source = (ImageSource)s.ConvertFromString(primary[31].ToString());
            OnClick(img32);
        }

        private void img33_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img33.Source = (ImageSource)s.ConvertFromString(primary[32].ToString());
            OnClick(img33);
        }

        private void img34_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img34.Source = (ImageSource)s.ConvertFromString(primary[33].ToString());
            OnClick(img34);
        }

        private void img35_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img35.Source = (ImageSource)s.ConvertFromString(primary[34].ToString());
            OnClick(img35);
        }

        private void img36_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img36.Source = (ImageSource)s.ConvertFromString(primary[35].ToString());
            OnClick(img36);
        }
    }
}
