using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using ClasesSistemaVentas;

namespace Sistemas_de_Ventas
{
    public partial class INGRESO_SISTEMA : Form{
        private Principal principal;
        
        public INGRESO_SISTEMA(Principal principal){
            this.principal = principal;
            InitializeComponent();
        }
        
        private void btAceptar_Click(object sender, EventArgs e){
            try{

                clUsuario usuario = new clUsuario(clConsultasUsuarios.ObtenerDatosUsuario(tb_username.Text));

                if (tbPassword.Text == usuario.Password){
                    principal.activarOpciones(usuario);

                    tbPassword.Text = null;
                    this.Close();
                }
                else{
                    MessageBox.Show("Usuario o Contraseña incorrectos!");
                }
            }
            catch { }
        }

        private void btCancelar_Click(object sender, EventArgs e){
            DialogResult dialogResult = MessageBox.Show("¿Desea salir?", "saliendo...", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                principal.Close();
            }
        }
            
        private void INGRESO_SISTEMA_Load(object sender, EventArgs e){
            principal.btn_Iniciar.Enabled = false;
            principal.btn_Iniciar.Visible = false;
        }

        private void INGRESO_SISTEMA_FormClosed(object sender, FormClosedEventArgs e){
            
            principal.btn_Iniciar.Enabled = true;
            principal.btn_Iniciar.Visible = true;
        }        
    }
}
