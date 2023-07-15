using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Assignment_UI.Models
{
    public class Student
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public BitmapImage Imageadd { get; set; }
        public string Image { get;set; }=string.Empty;
        public DateTime DateOfBirth { get; set; }
        public double GPA { get; set; }
       // public BitmapImage? image { get;  set; }

        public Student()
        {
        }


        public string ImagePath
        {
            get { return $"/Images/{Image}"; }
        }




        public Student(string firstName, string lastName,string  image, DateTime dateOfBirth, double gpa,BitmapImage imageadd)
        {

            FirstName = firstName;
            LastName = lastName;
            Image = image;
            DateOfBirth = dateOfBirth;
            GPA = gpa;
            Imageadd=imageadd;
        }
    }
}
