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
        ArrayList primary = new ArrayList();
        string[] secondary;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Easy_Copy_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Shape_Click(object sender, RoutedEventArgs e)
        {
            GenerateArray instantiate = new GenerateArray();
            ImageSourceConverter s = new ImageSourceConverter();

            //primary = instantiate.randomizeImagePosition(Theme.SHAPE);

            //img1.Source = (ImageSource)s.ConvertFromString(@"C:\Users\Crusader2142\Desktop\Assignments\C#\MemoryGame\MemoryGame\MemoryGame\1.jpg");
            //img2.Source = (ImageSource)s.ConvertFromString(@"C:\Users\Crusader2142\Desktop\Assignments\C#\MemoryGame\MemoryGame\MemoryGame\2.jpg");
            //for (int i = 0; i < primary.Count; i++)
            //{
            //    Console.WriteLine(primary[i]);
            //}
            //Console.WriteLine(primary.Count);


            //for (int i = 0; i < primary.Count; i++)
            //{
            //    img1.Source = (ImageSource)s.ConvertFromString(primary[i].ToString());
            //}

            //TRY OUT CODE

            //img3.Source = (ImageSource)s.ConvertFromString(primary[3].ToString());
            //img4.Source = (ImageSource)s.ConvertFromString(primary[4].ToString());
            //img5.Source = (ImageSource)s.ConvertFromString(primary[5].ToString());

            //secondary = instantiate.loadImageToArray(@"C:\Users\Crusader2142\Desktop\Assignments\C#\MemoryGame\MemoryGame\MemoryGame");

            primary = instantiate.randomizeImagePosition(@"C:\Users\Crusader2142\Desktop\Assignments\C#\MemoryGame\MemoryGame\MemoryGame");

            //primary.AddRange(secondary);
            //primary.AddRange(secondary);

            //Console.WriteLine(secondary.Length);
            //for (int i = 0; i < secondary.Length; i++)
            //{
            //    Console.WriteLine(secondary[i]);
            //}

            Console.WriteLine("======================================");
            Console.WriteLine(primary.Count);
            for (int i = 0; i < primary.Count; i++)
            {
                Console.WriteLine(primary[i]);
            }



        }
    }
}
