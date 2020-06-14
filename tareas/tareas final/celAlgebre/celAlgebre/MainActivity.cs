using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace celAlgebre
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
       

        protected override void OnCreate(Bundle savedInstanceState)

        {
            RadioGroup RTipo = FindViewById<RadioGroup>(Resource.Id.radioAritmetica);
            
            Button BIngresa = FindViewById<Button>(Resource.Id.bResolver);



            BIngresa.Click += (sender, e) =>
            {

                int seleccionadoTipoID = RTipo.CheckedRadioButtonId;
                RadioButton seleccionadoTipo = FindViewById<RadioButton>(seleccionadoTipoID);
                Aritmetica tipo;
                string strTipo = seleccionadoTipo.Text;
                Enum.TryParse(strTipo, out tipo);


            };
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}