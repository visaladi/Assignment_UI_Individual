using Assignment_UI.Models;
using Assignment_UI.ViewModels;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment_UI.Views
{
    /// <summary>
    /// Interaction logic for AddEditStudentView.xaml
    /// </summary>
    public partial class AddEditStudentView : Window
    {

        
        public AddEditStudentView(Student student)
        {
            InitializeComponent();
            var viewModel = new AddEditStudentViewModel(student);
            viewModel.CloseAction = (bool result) =>
            {
                DialogResult = result;
                Close();
            };
            DataContext = viewModel;
        }

       /* private  void btnLoad_Click(object sender, RoutedEventArgs e, Image image)
        {
            
                OpenFileDialog op = new OpenFileDialog();
                op.Title = "Select a picture";
                op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                  "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                  "Portable Network Graphic (*.png)|*.png";
                if (op.ShowDialog() == true)
                {
                    image.Source = new BitmapImage(new Uri(op.FileName));

                }

            
        }*/

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                image.Source = new BitmapImage(new Uri(op.FileName));
                MessageBox.Show("Image successfuly uploded!", "successfull");
            }
            
            

        }

        private void btnLoad1_Click(object sender, RoutedEventArgs e)
        {
            Uri resourceUri = new Uri("C:\\Users\\visal Adikari\\OneDrive\\Desktop\\Employee\\Assignment_UI\\Images\\1.png", UriKind.Relative);
            image.Source=new BitmapImage(resourceUri);
        }
    }
}
