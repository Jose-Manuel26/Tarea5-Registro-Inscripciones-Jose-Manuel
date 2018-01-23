using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro_Inscripciones.BLL;

namespace Registro_Inscripciones.Consultas
{
    public partial class cInscripciones : Form
    {
        public cInscripciones()
        {
            InitializeComponent();
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            //if(filterCombobox.SelectedIndex == 0)
               // dataGridView1.DataSource = InscripcionesBLL.GetList(i => i.InscripcionID == int.Parse(txValor.Text));

            switch (filterCombobox.SelectedIndex)
            {
                case 0:
                    dataGridView1.DataSource = InscripcionesBLL.GetList(i => i.InscripcionID == int.Parse(txValor.Text));
                    break;

                case 1:

                    break;

                case 2:
                    dataGridView1.DataSource = InscripcionesBLL.GetList(i => i.EstudianteId == int.Parse(txValor.Text));
                    break;


                case 3:
                    dataGridView1.DataSource = InscripcionesBLL.GetList(i => i.Monto == int.Parse(txValor.Text));
                    break;

                case 4:
                    dataGridView1.DataSource = InscripcionesBLL.GetList(i => i.Balance == int.Parse(txValor.Text));
                    break;

                case 5:
                    dataGridView1.DataSource = InscripcionesBLL.GetList(i => i.Observaciones.Contains(txValor.Text));
                    break;
            }
        }

        
    }
}
