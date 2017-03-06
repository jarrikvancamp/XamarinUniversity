using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace _03InstructorList
{
    public class InstructorData
    {
        static InstructorData()
        {
            var temp = new List<Instructor>();
            AddInstructors(temp);

            Instructors = temp.OrderBy(i => i.Name).ToList();
        }

        public static List<Instructor> Instructors { get; set; }

        private static void AddInstructors(List<Instructor> instructors)
        {
            instructors.Add(new Instructor
            {
                Name = "Berten",
                Biography = " foizefoiezfjoizeofji",
                ImageUrl = "images/berten.jpg",
                Specialtiy = "ETC"
            });
            instructors.Add(new Instructor
            {
                Name = "Jarrik",
                Biography = " foizefoiezfjoizeofji",
                ImageUrl = "images/jarrik.jpg",
                Specialtiy = "Digipolice"
            });
            instructors.Add(new Instructor
            {
                Name = "arne",
                Biography = " foizefoiezfjoizeofji",
                ImageUrl = "images/arne.jpg",
                Specialtiy = "Digipolis"
            });
            instructors.Add(new Instructor
            {
                Name = "Wouter I",
                Biography = " foizefoiezfjoizeofji",
                ImageUrl = "images/wouterI.jpg",
                Specialtiy = "Ordina"
            });
        }
    }
}