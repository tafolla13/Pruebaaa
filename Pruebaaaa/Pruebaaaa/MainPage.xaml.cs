using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pruebaaaa
{
   
    public partial class MainPage : ContentPage
    {
        ArrayList datos = new ArrayList();
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnAgregar_Clicked(object sender, EventArgs e)
        {
            String nombred = txtnombre.Text;
            int horasd = Convert.ToInt32(txtHoras.Text);
            int sueldod = Convert.ToInt32(txtHoras.Text);
            Persona pers = new Persona(nombred, sueldod, horasd);
            datos.Add(pers);
            txtnombre.Text = null;
            txtHoras.Text = null;
            txtSueldo.Text = null;

        }

        private void btnlimpiar_Clicked(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Clicked(object sender, EventArgs e)
        {

        }
    }
}
