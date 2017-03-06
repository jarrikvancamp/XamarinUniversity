using Android.App;
using Android.Widget;
using Android.OS;

namespace _02GroceryList
{
    [Activity(Label = "_02GroceryList", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button btnItems, btnAddItem, btnAbout;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            btnItems = FindViewById<Button>(Resource.Id.btnItems);
            btnAddItem = FindViewById<Button>(Resource.Id.btnAddItem);
            btnAbout = FindViewById<Button>(Resource.Id.btnAbout);

            btnItems.Click += OnClickGoToItems;
            btnAddItem.Click += OnClickGoToAddItem;
            btnAbout.Click += OnClickGoToAbout;
        }

        private void OnClickGoToAbout(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnClickGoToAddItem(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnClickGoToItems(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}

