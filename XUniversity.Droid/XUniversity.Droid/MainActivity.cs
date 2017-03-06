using Android.App;
using Android.Widget;
using Android.OS;

namespace XUniversity.Droid
{
    [Activity(Label = "Tip calculator", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        EditText txtOriginalBill;
        Button btnCalculate;
        TextView lblTotal, lblCalculate;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            txtOriginalBill = FindViewById<EditText>(Resource.Id.txtOriginalBill);
            btnCalculate = FindViewById<Button>(Resource.Id.btnCalculate);
            lblCalculate = FindViewById<TextView>(Resource.Id.lblCalculate);
            lblTotal = FindViewById<TextView>(Resource.Id.lblTotal);

            btnCalculate.Click += OnClick;
        }

        private void OnClick(object sender, System.EventArgs e)
        {
            var s = txtOriginalBill.Text;
            var bill = double.Parse(s);

            var tip = bill * 0.15;
            var total = bill + tip;

            lblCalculate.Text = $"{tip}";
            lblTotal.Text = $"{total}";
        }
    }
}

