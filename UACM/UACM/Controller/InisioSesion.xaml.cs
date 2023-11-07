using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UACM.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InisioSesion : ContentPage
	{
		public InisioSesion ()
		{
			InitializeComponent ();


        }


        private void Btn_AceptarInicioSesion(object sender, EventArgs e)
        {
<<<<<<< HEAD
           this.Navigation.PushModalAsync(new Principal());
=======
<<<<<<< HEAD
           this.Navigation.PushModalAsync(new Principal());
=======
            //Se redireciona a MainPage Ya que aquí se implementa el menu en la pagina Principal
           this.Navigation.PushModalAsync(new MainPage());
>>>>>>> 3ccac9d (Se agrego menu desplegable)
>>>>>>> 6522435 (tercer commit)

        }
    }

}