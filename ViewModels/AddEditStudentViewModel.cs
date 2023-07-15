using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Assignment_UI.Models;
using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace Assignment_UI.ViewModels
{
    public partial class AddEditStudentViewModel : ObservableObject
    {
        public Student Student { get; set; }

        [ObservableProperty] 
        public double gpa;

        [ObservableProperty]
        public string firstname;


        [ObservableProperty]
        public string lastname;

        [ObservableProperty]
        public int age;

        [ObservableProperty]
        public string dateofbirth;

       /* [ObservableProperty]
        public double gpa;*/

        public RelayCommand SaveCommand { get; }
        public RelayCommand CancelCommand { get; }

        public Action<bool> CloseAction { get; set; }
        public List<string> ImageList { get; set; }
        //public string SelectedImage { get; set; }
        [ObservableProperty]
        public BitmapImage selectedImage;

        public AddEditStudentViewModel(Student student)
        {
            Student = student;

            SaveCommand = new RelayCommand(Save);
            CancelCommand = new RelayCommand(Cancel);
        }

        public AddEditStudentViewModel()
        {
          /*  ImageList = new List<string>
            {
         "C:\\Users\\visal Adikari\\OneDrive\\Desktop\\Employee\\Desktop UI Sachi\\Images\\1.png",
        "C:\\Users\\visal Adikari\\OneDrive\\Desktop\\Employee\\Assignment_UI\\Images\\10.png",
        "C:\\Users\\visal Adikari\\OneDrive\\Desktop\\Employee\\Assignment_UI\\Images\\2.png",
        "C:\\Users\\visal Adikari\\OneDrive\\Desktop\\Employee\\Assignment_UI\\Images\\3.png",
        "C:\\Users\\visal Adikari\\OneDrive\\Desktop\\Employee\\Assignment_UI\\Images\\4.png",
        "C:\\Users\\visal Adikari\\OneDrive\\Desktop\\Employee\\Assignment_UI\\Images\\5.png",
        "C:\\Users\\visal Adikari\\OneDrive\\Desktop\\Employee\\Assignment_UI\\Images\\6.png",
        "C:\\Users\\visal Adikari\\OneDrive\\Desktop\\Employee\\Assignment_UI\\Images\\7.png",
        "C:\\Users\\visal Adikari\\OneDrive\\Desktop\\Employee\\Assignment_UI\\Images\\8.png",
        "C:\\Users\\visal Adikari\\OneDrive\\Desktop\\Employee\\Assignment_UI\\Images\\9.png"
            };*/
        }


 /*   private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // set SelectedImage to the selected image path
            SelectedImage = (string)((ListBox)sender).SelectedItem;
        }*/

        private void Save()
        {
            if (gpa is<0or>4)
            {
                MessageBox.Show("Gpa must be between 0 and 4", "Error");
                return;
            }
            // Save the changes to the database or other storage
            // ...
            

            if (Student.FirstName != null)
            {

                CloseAction?.Invoke(true);
                Application.Current.MainWindow.Show();
            }
            // Close the window and set the DialogResult to true
            //CloseAction?.Invoke(true);
        }
          [RelayCommand]
        public void SelectPhoto()
        {
            Microsoft.Win32.OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.bmp; *.png; *.jpg";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == true)
            {
                selectedImage = new BitmapImage(new Uri(dialog.FileName));

                MessageBox.Show("Imgae successfuly uploded!", "successfull");
            }
        }

        private void Cancel()
        {
            // Close the window and set the DialogResult to false
            CloseAction?.Invoke(false);
        }

    }
}

