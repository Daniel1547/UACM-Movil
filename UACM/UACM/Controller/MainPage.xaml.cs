using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UACM.View;
using Xamarin.Forms;

namespace UACM
{
<<<<<<< HEAD
    public partial class MainPage : ContentPage
=======
<<<<<<< HEAD
    public partial class MainPage : ContentPage
=======
    public partial class MainPage : FlyoutPage
>>>>>>> 3ccac9d (Se agrego menu desplegable)
>>>>>>> 6522435 (tercer commit)
    {

        public MainPage()
        {
            InitializeComponent();

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 6522435 (tercer commit)
            //Para navegavilidad
            btnInicioSesion.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new InisioSesion());
            };
<<<<<<< HEAD
=======
=======
            //MENU DE HAMBURGUESA
            flyout.listview.ItemSelected += OnSelectedItem;



            //Para navegavilidad
          /*****  btnInicioSesion.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new InisioSesion());
            };*/
>>>>>>> 3ccac9d (Se agrego menu desplegable)
>>>>>>> 6522435 (tercer commit)

           /* Btn_Registro.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Registro());
            };*/


        }
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 6522435 (tercer commit)
        private void Btn_Registro(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Registro());
        }
<<<<<<< HEAD
=======
=======

        //Metodo Para el menu de hamburguesa
        private void OnSelectedItem(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as FlyoutItemPage;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetPage));
                flyout.listview.SelectedItem = null;
                IsPresented = false;
            }
        }


        /***** private void Btn_Registro(object sender, EventArgs e)
{
    this.Navigation.PushAsync(new Registro());
}*/
>>>>>>> 3ccac9d (Se agrego menu desplegable)
>>>>>>> 6522435 (tercer commit)
    }


}
