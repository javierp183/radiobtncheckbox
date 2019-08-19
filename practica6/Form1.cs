using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Deshabilito el boton ok.
            btnOK.Enabled = false;
        }

        private void ValidarOk()
        {
            //Habilitar el boton, Siempre y cuando txtNombre tenga datos.
            btnOK.Enabled = (txtNombre.BackColor != Color.Red);
           
        }

        private void txtNombre_Validating(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if(tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                ValidarOk();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //No valido datos que si el Boton esta habilitado.
            //es por que paso el Evento Validating del Nombre.
            String salida; // Declaro una variable string para resguardar
                           // la salida

            salida = "Nombre: " + txtNombre.Text + "\r\n";
            salida += "Ocupacion: " + (string)(chkBox1.Checked ? "Programador" : "No es programador") + "\r\n";
            salida += "Sexo: " + (string)(rBtn1.Checked ? "Hombre" : "Mujer") + "\r\n";

            //Vuelco la salida al Textbox Salida.
            txtBox2.Text = salida;

        }

        private void rBtn1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
