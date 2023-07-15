using Assignment_UI.ViewModels;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using System;
using System.Windows.Controls;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Media.Imaging;
using Image = System.Windows.Controls.Image;

namespace Assignment_UI.Views
{
    /// <summary>
    /// Interaction logic for StudentsView.xaml
    /// </summary>
    public partial class StudentsView : UserControl
    {
        public string Imageadd { get; private set; }

        //public string Image { get; private set; }

        [RelayCommand]
        public void Load()
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|.jpg;.jpeg;*.png|" +
              "JPEG (.jpg;.jpeg)|.jpg;.jpeg|" +
              "Portable Network Graphic (.png)|.png";
            if (op.ShowDialog() == true)
            {
                //Image = op.FileName;
                //Image = new BitmapImage(new Uri(op.FileName));
                {
                    Imageadd=op.FileName;
                    BitmapImage bitmap = new BitmapImage(new Uri(op.FileName));
                    //Imageadd.Source = bitmap;
                    

                }
            }
        }
        private BitmapImage _imageSource = new BitmapImage(new Uri("/Images/1.png", UriKind.Relative));
        private readonly OpenFileDialog _openFileDialog;
        public BitmapImage ImageSource
        {
            get { return _imageSource; }
            set
            {
                if (_imageSource != value)
                {
                    _imageSource = value;
                    //OnPropertyChanged(nameof(ImageSource));
                }
            }
        }
        public StudentsView()
        {
            InitializeComponent();
        }
    }
}
