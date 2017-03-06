
using System;
using Android.Views;
using Android.Widget;
using Android.App;
using System.Collections.Generic;
using System.IO;
using Android.Graphics.Drawables;

namespace _03InstructorList
{
    public class InstructorAdapter : BaseAdapter<Instructor>
    {
        private Activity _context;
        private List<Instructor> _instructors;
        public InstructorAdapter(Activity context, List<Instructor> instructors)
        {
            _context = context;
            _instructors = instructors;
        }

        public override Instructor this[int position]
        {
            get
            {
                return _instructors[position];

            }
        }

        public override int Count
        {
            get
            {
                return _instructors.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = _context.LayoutInflater.Inflate(Resource.Layout.InstructorRow, parent, false);
            var photo = view.FindViewById<ImageView>(Resource.Id.photoImageView);
            var name = view.FindViewById<TextView>(Resource.Id.nameTextView);
            var speciality = view.FindViewById<TextView>(Resource.Id.specialtyTextView);

            Stream stream = _context.Assets.Open(_instructors[position].ImageUrl);
            Drawable drawable = Drawable.CreateFromStream(stream, null);
            photo.SetImageDrawable(drawable);

            name.Text = _instructors[position].Name;
            speciality.Text = _instructors[position].Specialtiy;

            return view;
        }
    }
}