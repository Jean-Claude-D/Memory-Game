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
    public class GenerateArray
    {
        

        public string[] loadImageToArray(string path)
        {
            // Load all the files name + their path (ending in .jpg)
            string[] imageArray = System.IO.Directory.GetFiles(path, "*.jpg");
            //ArrayList arrayList = new ArrayList();
            // Convert to arrayList
            //arrayList.AddRange(imageArray);

            return imageArray; // bare in mind, I haven't fix enum after
        }

        public string[] randomizeImagePosition(Theme theme)
        {

            ArrayList imageList = new ArrayList();

            // imageList = loadImageToArray(ThemeUtil.getPath(theme));

            imageList.AddRange(loadImageToArray(ThemeUtil.getPath(theme)));

            imageList.AddRange(loadImageToArray(ThemeUtil.getPath(theme)));

            ArrayList randomize = new ArrayList();

            Random rng = new Random();

            int randomIndex = 0;

            int listSize = imageList.Count;

            //Randomize Stuff
            while(imageList.Count > 0)
            {
                randomIndex = rng.Next(0, imageList.Count);
                randomize.Add(imageList[randomIndex]);
                imageList.RemoveAt(randomIndex);
            }
            return randomize.ToArray(typeof(string)) as string[];

        }

    }
}