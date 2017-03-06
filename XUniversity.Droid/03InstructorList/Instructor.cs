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
    public class Instructor
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Specialtiy { get; set; }
        public string Biography { get; set; }

        public override string ToString()
        {
            return $"{Name} {Specialtiy}";
        }
    }
}