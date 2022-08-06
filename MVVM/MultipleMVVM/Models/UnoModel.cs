using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace MultipleMVVM.Models
{
    public partial class UnoModel
    {
        private string name;

        private BitmapImage runImage;

        private BitmapImage jumpImage;

        private BitmapImage standImage;

        private string commandAction;

        public UnoModel(String name)
        {
            this.Name = name;
        }
        private void InitImage()
        {
            if(name != "Uno" && name != "NoUno") { return; }
            CreateBitmap(ref runImage, "C:/Users/sales/Desktop/tempImage/"+name +"/run.png");
            CreateBitmap(ref jumpImage, "C:/Users/sales/Desktop/tempImage/" + name + "/jump.png");
            CreateBitmap(ref standImage, "C:/Users/sales/Desktop/tempImage/" + name + "/stand.png");
        }

        public String Name
        {
            get { return name; }
            set { 
                name = value;
                InitImage();
            }
        }

        public BitmapImage RunImage
        {
            get
            {
                return runImage;
            }
            set
            {
                runImage = value;
            }
        }

        public BitmapImage JumpImage
        {
            get
            {
                return jumpImage;
            }
            set
            {
                jumpImage = value;

            }
        }
        public BitmapImage StandImage
        {
            get
            {
                return standImage;
            }
            set
            {
                standImage = value;
            }
        }

        public string CommandAction
        {
            get
            {
                return commandAction;
            }
            set
            {
                commandAction = value;
            }
        }
        private void CreateBitmap(ref BitmapImage img, string filePath)
        {
            img = new BitmapImage();
            img.BeginInit();
            img.UriSource = new Uri(filePath, UriKind.Absolute);
            img.EndInit();
        }
    }
}
