using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PresentacionWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Clinica clinica = new Clinica(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un nombre de clinica"),
                                          Microsoft.VisualBasic.Interaction.InputBox("Ingrese un domicilio de clinica"),
                                          Microsoft.VisualBasic.Interaction.InputBox("Ingrese un email de clinica"),
                                          Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un telefono de clinica")));
            Habitacion habitacion = new Habitacion(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un nombre de habitacion"),
                                                   Microsoft.VisualBasic.Interaction.InputBox("Ingrese un estado de habitacion"));

            


            lstClinicasYHabitaciones.Items.Add(clinica.Nombre + " " + habitacion.Nombre +" "+ habitacion.Estado);
        }
    }
}
