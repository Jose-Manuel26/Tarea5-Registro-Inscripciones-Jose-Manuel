using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro_Inscripciones.Consultas;
using Registro_Inscripciones.BLL;
using Registro_Inscripciones.Entidades;

namespace Registro_Inscripciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            new cInscripciones().Show();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (!CampoVacio())
            {
                if (InscripcionesBLL.Guardar(crearInscripcion()))
                    MessageBox.Show("SE ARCHIVO LA INSCRIPCION");
            }

            LimpiarTextBox();
   
        }


        private void btBuscar_Click(object sender, EventArgs e)
        {
            Inscripciones ins = InscripcionesBLL.Buscar(int.Parse(txInscripcionID.Text));

            if (ins != null)
            {
                txEstudianteID.Text = ins.EstudianteId.ToString();
                dateTimePicker1.Value = DateTime.Parse(ins.Fecha);
                txMonto.Text = ins.Monto.ToString();
                txBalance.Text = ins.Balance.ToString();
                txObservacion.Text = ins.Observaciones;
            }
            else
                MessageBox.Show("INSCRIPCIONID INVALIDA");
            
        }



        private void txMonto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(txMonto.Text);
                errpNumerico.Clear();

                if (txMonto.Text != "")
                    errpCampoVacio.SetError(txMonto, "");

            }
            catch (Exception)
            {
                errpNumerico.SetError(txMonto, "No es una valor numerico");
            }
        }



        private void txBalance_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(txBalance.Text);
                errpNumerico.Clear();

                if (txBalance.Text != "")
                    errpCampoVacio.SetError(txBalance, "");

            }
            catch (Exception)
            {
                errpNumerico.SetError(txBalance, "No es una valor numerico");
            }
        }



        private void txEstudianteID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(txEstudianteID.Text);
                errpNumerico.Clear();

                if (txEstudianteID.Text != "")
                    errpCampoVacio.SetError(txEstudianteID, "");
                    

            }
            catch (Exception)
            {
                errpNumerico.SetError(txEstudianteID, "No es una valor numerico");
            }
        }



        private void txObservacion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txObservacion.Text != "")
                    errpCampoVacio.SetError(txObservacion, "");
            }
            catch (Exception)
            {

            }
        }


        private bool CampoVacio()
        {
            bool flag = false;

            if (txEstudianteID.Text == "")
            {
                errpCampoVacio.SetError(txEstudianteID, "Campo vacio");
                flag = true;
            }

            if (txMonto.Text == "")
            {
                errpCampoVacio.SetError(txMonto, "Campo vacio");
                flag = true;
            }

            if (txBalance.Text == "")
            {
                errpCampoVacio.SetError(txBalance, "Campo vacio");
                flag = true;
            }

            if (txObservacion.Text == "")
            {
                errpCampoVacio.SetError(txObservacion, "Campo vacio");
                flag = true;
            }

            if (txEstudianteID.Text != "" && txMonto.Text != "" &&
                txBalance.Text != "" && txObservacion.Text != "")
            {
                errpCampoVacio.Clear();
                flag = false;
            }

            return flag;

        }


        private void btEliminar_Click(object sender, EventArgs e)
        {

            if (InscripcionesBLL.Eliminar(int.Parse(txInscripcionID.Text)))
                MessageBox.Show("SE ELIMINO LA INSCRIPCION");

            LimpiarTextBox();
        }


        private void btModificar_Click(object sender, EventArgs e)
        {
            if(InscripcionesBLL.Modificar(crearInscripcion()))
                MessageBox.Show("SE MODIFICO LA INSCRIPCION");

            LimpiarTextBox();
        }



        private Inscripciones crearInscripcion()
        {
            return new Inscripciones(
                0,
                dateTimePicker1.Value.ToString(),
                int.Parse(txEstudianteID.Text),
                float.Parse(txMonto.Text),
                float.Parse(txBalance.Text),
                txObservacion.Text
                );
        }


        private void LimpiarTextBox()
        {
            txInscripcionID.Clear();
            dateTimePicker1.Value = DateTime.Now;
            txEstudianteID.Clear();
            txMonto.Clear();
            txBalance.Clear();
            txObservacion.Clear();
        }
    }
}
