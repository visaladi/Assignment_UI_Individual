using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Assignment_UI.Models;
using Assignment_UI.Views;
using System;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;
using System.Collections.Generic;
using System.Windows.Media;

namespace Assignment_UI.ViewModels
{
    public class StudentsViewModel : ObservableObject
    {
        private Student? _selectedStudent;

        public ObservableCollection<Student> Students { get; set; }

        public Student SelectedStudent
        {
            get { return _selectedStudent; }
            set
            {
                SetProperty(ref _selectedStudent, value);
                EditStudentCommand.NotifyCanExecuteChanged();
                DeleteStudentCommand.NotifyCanExecuteChanged();
            }
        }

        public RelayCommand AddStudentCommand { get; }
        public RelayCommand EditStudentCommand { get; }
        public RelayCommand DeleteStudentCommand { get; }

        //public List<string> Image { get; set; }

        public string SelectedImage { get; set; }

        /*public MyViewModel()
        {
            // set ImageList to a list of image paths
      
        }*/
        public StudentsViewModel()
        {

            /* Image = new List<string>
             {
         "C:\\Users\visal Adikari\\OneDrive\\Desktop\\Employee\\Assignment_UI\\Images\\1.png",

     };*/
            // Initialize the collection with some dummy data
/*            BitmapImage image1 = new BitmapImage(new Uri("/Images/1.png", UriKind.Relative));
            BitmapImage image2 = new BitmapImage(new Uri("/Images/2.png", UriKind.Relative));
            BitmapImage image3 = new BitmapImage(new Uri("/Images/3.png", UriKind.Relative));
            BitmapImage image4 = new BitmapImage(new Uri("/Images/4.png", UriKind.Relative));
            BitmapImage image5 = new BitmapImage(new Uri("/Images/5.png", UriKind.Relative));*/
            Students = new ObservableCollection<Student>
            {
                new Student
                {
                    FirstName = "phllip",
                    LastName = "Dean",
                   Image = $"/Images/1.png" ,
                    DateOfBirth = new DateTime(2000, 1, 1),
                    GPA = 3.5
                },
                new Student
                {
                    FirstName = "Adam",
                    LastName = "Blake",
                    Image = $"/Images/10.png",
                    DateOfBirth = new DateTime(2001, 2, 2),
                    GPA = 3.8
                },
                new Student
                {
                    FirstName = "James",
                    LastName = "Leo",
                    Image = $"/Images/2.png",
                    //new BitmapImage(new Uri("C:\\Users\\visal Adikari\\OneDrive\\Desktop\\database\\Desktop01\\Desktop01\\Model\\Images\\1.png"),
                                          //  UriKind.Relative) ,
                    DateOfBirth = new DateTime(2001, 2, 2),
                    GPA = 3.2
                }
            };

            AddStudentCommand = new RelayCommand(AddStudent);
            EditStudentCommand = new RelayCommand(EditStudent, () => SelectedStudent != null);
            DeleteStudentCommand = new RelayCommand(DeleteStudent, () => SelectedStudent != null);
        }

        private void AddStudent()
        {
            // Create a new student object
            var newStudent = new Student();

            // Show the Add/Edit Student window
            var addEditWindow = new AddEditStudentView(newStudent);
            var result = addEditWindow.ShowDialog();

            // Add the new student to the collection if the user clicked "Save" and entered a first name
            if (result.HasValue && result.Value && !string.IsNullOrWhiteSpace(newStudent.FirstName))
            {
                Students.Add(newStudent);
            }
            

        }


        private void EditStudent()
        {
            // Show the Add/Edit Student window with the selected student's data
            var addEditWindow = new AddEditStudentView(SelectedStudent);
            addEditWindow.ShowDialog();
        }

        private void DeleteStudent()
        {
            // Remove the selected student from the collection
            Students.Remove(SelectedStudent);
        }
    }
}
