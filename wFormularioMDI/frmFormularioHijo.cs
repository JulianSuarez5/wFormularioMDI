using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wFormularioMDI
{
    public partial class frmFormularioHijo : Form
    {
        public frmFormularioHijo()
        {
            InitializeComponent();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK))
                {
                    Stream strGuardar = saveFileDialog1.OpenFile();
                    StreamWriter wtrGuardar = new StreamWriter(strGuardar);
                    foreach (string linea in txtTexto.Lines)
                    {
                        wtrGuardar.WriteLine(linea);
                    }
                    wtrGuardar.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
