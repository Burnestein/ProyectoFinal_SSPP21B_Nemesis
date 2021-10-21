using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_SSPP21B_Nemesis
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            MenuPrincipal VentanaPF;

            VentanaPF = new MenuPrincipal();
            VentanaPF.Show();
            //Hide();
        }
    }
}
