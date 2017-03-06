using Android.App;
using Android.Widget;
using Android.OS;

namespace _03InstructorList
{
    [Activity(Label = "Instructors", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        ListView lstInstructors;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            lstInstructors = FindViewById<ListView>(Resource.Id.lstInstructors);
            var adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, InstructorData.Instructors);

            lstInstructors.ItemClick += OnListItemClick;

            var instructorAdapter = new InstructorAdapter(this, InstructorData.Instructors);
            lstInstructors.Adapter = instructorAdapter;

           // lstInstructors.Adapter = adapter;
        }

        private void OnListItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var instructor = InstructorData.Instructors[e.Position];

            var dialog = new AlertDialog.Builder(this);
            dialog.SetMessage(instructor.Name);
            dialog.SetNeutralButton("ok", delegate
            {
            });
            dialog.Show();
        }
    }
}

