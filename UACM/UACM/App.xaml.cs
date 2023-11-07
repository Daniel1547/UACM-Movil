using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UACM
{
    public partial class App : Application
    {
        public App()
        {
           // InitializeComponent();
<<<<<<< HEAD

            MainPage = new NavigationPage ( new MainPage());
=======
<<<<<<< HEAD

            MainPage = new NavigationPage ( new MainPage());
=======
           //Iniia la aplicasión con la caratula (principal)
            MainPage = new NavigationPage ( new Caratula());
>>>>>>> 3ccac9d (Se agrego menu desplegable)
>>>>>>> 6522435 (tercer commit)
        }
        public static readonly Xamarin.Forms.BindableProperty BarBackgroundColorProperty;
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
