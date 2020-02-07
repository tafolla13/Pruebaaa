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
            int sueldod = Convert.ToInt32(txtSueldo.Text);
            Persona pers = new Persona(nombred, sueldod, horasd);
            datos.Add(pers);
            txtnombre.Text = null;
            txtHoras.Text = null;
            txtSueldo.Text = null;

        }

        private void btnlimpiar_Clicked(object sender, EventArgs e)
        {
            datos.Clear();
            txtnombre.Text = null;
            txtHoras.Text = null;
            txtSueldo.Text = null;
        }

        private void btnBuscar_Clicked(object sender, EventArgs e)
        {
            String buscar = txtnombre.Text;
            bool encontrado = false;
            foreach(Persona dato in datos)
                if (dato.Nombre.Equals(buscar))
                {
                    txtHoras.Text = dato.Horas.ToString();
                    txtSueldo.Text = dato.Sueldo.ToString();
                    DisplayAlert("Tu sueldo", (dato.Sueldo * dato.Horas). ToString(), "Aceptar");


                }
        }
    }
}
