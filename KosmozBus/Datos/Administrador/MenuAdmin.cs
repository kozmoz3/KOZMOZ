using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos.Administrador
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }
        AltaEmpresaOperadora empresaoperadora = null;

        private void button1_Click(object sender, EventArgs e)
        {
          
            Prueba p = new Prueba();
            p.MdiParent = this;
            p.Show();


        }

        private void pATIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prueba p = new Prueba();
           // p.MdiParent = this;
            p.Show();

        }

        private void aDMINISTRADORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(empresaoperadora == null){
                empresaoperadora = new AltaEmpresaOperadora();
                empresaoperadora.MdiParent = this;
                empresaoperadora.Show();
            }
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
