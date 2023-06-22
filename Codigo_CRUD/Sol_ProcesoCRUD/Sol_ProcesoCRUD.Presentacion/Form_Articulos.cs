using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_ProcesoCRUD.Presentacion
{
    public partial class Form_Articulos : Form
    {
        public Form_Articulos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        #region Variables

        int codArticulo = 0;
        int codCategoria = 0;
        int codMedida = 0;
        int estadoGuarda = 0;

        #endregion

        #region MisMetodos

        private void Estado_texto(bool lEstado) 
        {
            txtArticuloAlta.ReadOnly = !lEstado;
            txtMarca.ReadOnly = !lEstado;
        }

        private void Estado_botones(bool lEstado) 
        {
            btnGuardar.Visible = lEstado;
            btnCancelar.Visible = lEstado;
            btnCatgoria.Visible = lEstado;
            btnMedida.Visible = lEstado;

            btnBuscar.Enabled = !lEstado;
            txtArticulo.Enabled = !lEstado;
            dtgArticulos.Enabled = !lEstado;
        }

        private void EstadoBotonesPrincipales(bool lEstado)
        {
            btnNuevo.Enabled = lEstado;
            btnEditar.Enabled = lEstado;
            btnReporte.Enabled = lEstado;
            btnEliminar.Enabled = lEstado;
            btnSalir.Enabled = lEstado;
        }

        private void Limpia_texto() 
        {
            txtArticuloAlta.Clear();
            txtMarca.Clear();
            txtMedida.Clear();
            txtCategoria.Clear();
        }

        private void ListadoArticulos() 
        {
            Logica.L_Articulos cargaArticulos = new Logica.L_Articulos();
            dtgArticulos.DataSource = cargaArticulos.ListadoArticulos();
            
        }

        #endregion

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Cuando esta variable esta en 1 sinifica que es registro nuevo
            estadoGuarda = 1;
            this.Estado_texto(true);
            this.Estado_botones(true);
            this.EstadoBotonesPrincipales(false);
            txtArticuloAlta.Focus();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.EstadoBotonesPrincipales(true);
            this.Estado_botones(false);
            this.Estado_texto(false);
            this.Limpia_texto();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Cuando esta variable esta en 0 sinifica que es actualizacion de registro
            estadoGuarda = 0;
        }

        private void Form_Articulos_Load(object sender, EventArgs e)
        {
            ListadoArticulos();
        }
    }
}
