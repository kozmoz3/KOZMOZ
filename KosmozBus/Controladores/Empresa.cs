using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using DataModel;
using Vistas;
using System.Windows.Forms;


namespace Controladores
{
    public class Empresa
    {
        public void  insert(empresaoperadoraDto dta)
        {
            try { 
                using(kosmozbusEntities db = new kosmozbusEntities())
                {
                    
                    
                   /// MessageBox.Show(""+fechaHoy);
                    int a;

                   // DateTime fechaConversion = DateTime.Parse(this.lbFecha.Text);
                }
            
            }catch(Exception e){
                MessageBox.Show("Error al insertar empresa operadora ->"+e);
            }

        }
    }
}
