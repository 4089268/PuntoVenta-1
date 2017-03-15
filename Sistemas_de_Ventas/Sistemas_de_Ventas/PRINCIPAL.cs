using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using ClasesSistemaVentas;

namespace Sistemas_de_Ventas
{
    public partial class Principal : Form{
        private clUsuario usuario;
        private INGRESO_SISTEMA login;

        public Principal(){
            InitializeComponent();

            msOpciones.Items[0].Enabled = false;
            msOpciones.Items[1].Enabled = false;
            msOpciones.Items[2].Enabled = false;

            msOpciones.Items[0].Visible = false;
            msOpciones.Items[1].Visible = false;
            msOpciones.Items[2].Visible = false;
            
            login = new INGRESO_SISTEMA(this);
            login.Show();
            login.MdiParent = this;
        }
        public void activarOpciones(clUsuario user){
            this.usuario = user;

            if (usuario.Tipo == "administrador"){
                msOpciones.Items[0].Enabled = true;
                msOpciones.Items[1].Enabled = true;
                msOpciones.Items[2].Enabled = true;

                msOpciones.Items[0].Visible = true;
                msOpciones.Items[1].Visible = true;
                msOpciones.Items[2].Visible = true;
            }
            else{
                msOpciones.Items[1].Enabled = true;
                msOpciones.Items[2].Enabled = true;

                msOpciones.Items[1].Visible = true;
                msOpciones.Items[2].Visible = true;
                
            }
        }



        /* ***Funciones barra de opciones *** */
        private void Salir_Click(object sender, EventArgs e){
            this.Close();
        }

        private void admUsuarios_Click(object sender, EventArgs e){
            USUARIOS usuarios = new USUARIOS();
            usuarios.Visible = true;
        }

        private void admProductos_Click(object sender, EventArgs e){
            Productos productos = new Productos();
            productos.Visible = true;
        }

        private void Caja_Click(object sender, EventArgs e){
            CAJA caja = new CAJA(usuario);
            caja.Visible = true;
            caja.MdiParent = this;
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e){
            REPORTE_VENTAS reporte = new REPORTE_VENTAS();
            reporte.Visible = true;
        }

        private void porTurnoToolStripMenuItem_Click(object sender, EventArgs e){
            REPORTEPORTURNO reporte = new REPORTEPORTURNO();
            reporte.Visible = true;
        }

        private void porCajeroToolStripMenuItem_Click(object sender, EventArgs e){
            REPORTE_CAJERO reporte = new REPORTE_CAJERO();
            reporte.Visible = true;
        }
        /* ******************************** */




        /* ***Funciones sobre log In*** */
        private void Principal_FormClosed(object sender, FormClosedEventArgs e){
            login.Visible = true;
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e) {
            var window = MessageBox.Show("¿Desea salir del Sistema?", "Saliendo...", MessageBoxButtons.YesNo);
            e.Cancel = (window == DialogResult.No);
        }

        private void btn_Iniciar_Click(object sender, EventArgs e){
            login = new INGRESO_SISTEMA(this);
            login.Show();
            login.MdiParent = this;
        }

        /* **************************** */
        
    }
}
