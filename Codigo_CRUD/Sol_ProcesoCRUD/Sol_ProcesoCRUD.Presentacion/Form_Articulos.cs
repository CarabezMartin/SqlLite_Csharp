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
        }

        private void Bloquear_botones(bool lEstado)
        {
            btnEditar.Visible = lEstado;
            btnReporte.Visible = lEstado;
            btnEliminar.Visible = lEstado;
            btnSalir.Visible = lEstado;
        }

        private void Limpia_texto() 
        {
            txtArticuloAlta.Clear();
            txtMarca.Clear();
            txtMedida.Clear();
            txtCategoria.Clear();
        }

        #endregion

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Estado_texto(true);
            this.Estado_botones(true);
            this.Bloquear_botones(false);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Bloquear_botones(true);
            this.Estado_botones(false);
            this.Estado_texto(false);
            this.Limpia_texto();
        }
    }
}
