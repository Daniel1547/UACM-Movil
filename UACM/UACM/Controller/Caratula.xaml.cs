using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UACM.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UACM
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Caratula : ContentPage
	{
		public Caratula ()
		{
			InitializeComponent ();

            //Para navegavilidad por medio del boton nombrado
            btnInicioSesion.Clicked += (sender, e) =>
              {
                  Navigation.PushAsync(new InisioSesion());
              };

        }

        //Funcion para navegar con el boton 
        private void Btn_Registro(object sender, EventArgs e)
        {
         this.Navigation.PushAsync(new Registro());
        }
    }
}