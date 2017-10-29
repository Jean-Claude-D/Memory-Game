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
        string[] secondary;
        Image[] imgs;
        int[] imgNumbers;
        GenerateArray instantiate = new GenerateArray();
        ImageSourceConverter s = new ImageSourceConverter();



        public MainWindow()
        {
            InitializeComponent();

            imgs = new Image[] {img1, img2, img3, img4, img5, img6, img7, img8, img9, img10,
                                img11, img12, img13, img14, img15, img16, img17, img18, img19,
                                img20, img21, img22, img23, img24, img25, img26, img27, img28,
                                img29, img30, img31, img32, img33, img34, img35, img36};

            // generate random array of image
            primary = instantiate.randomizeImagePosition(@"C:\Users\Crusader2142\Desktop\Assignments\C#\MemoryGame\MemoryGame\MemoryGame");
            imgNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 }; // some of my experiene stupid idea, ignore itoko
            
        }

        private void Shape_Click(object sender, RoutedEventArgs e)
        {

            //primary = instantiate.randomizeImagePosition(Theme.SHAPE);



            //Console.WriteLine(primary.Count);


                //imgs[i].Source = (ImageSource)s.ConvertFromString(primary[i].ToString());


        }

        private void imgHandler(object sender, MouseButtonEventArgs e)
        {

            int i = Array.IndexOf(imgs, ((Image)sender));

            ((Image)sender).Source = (ImageSource)s.ConvertFromString(primary[i]); 

        }


    }
}
