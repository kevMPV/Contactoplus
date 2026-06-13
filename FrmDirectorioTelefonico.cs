

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ContactosPlus
{
    public partial class FrmDirectorioTelefonico : Form
    {
        public FrmDirectorioTelefonico()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        List<TextBox> componentes = new List<TextBox>();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (TextBox componente in componentes)
                validarTextbox(componente, "campo obligatorio");




            /*
            validarTextbox(txtNombre, "vrerificar tu nombre");
            validarTextbox(txtApellidos, "verifica tus apellidos");
            validarTextbox(txtTelefono, "verificar tu telefono");
            validarTextbox(txtExtension, "verifica tu extencion");
            validarTextbox(txtCargo, "verifica tu cargo");
            validarTextbox(txtEmpresa, "verifica tu empresa");
            validarTextbox(txtCorreo, "verfica tu correo");
            */

            /*  
              Directorio obj = new Directorio();
              int id= Convert.ToInt32(txtId.Text);

              obj.add(id, nombre, apellidos, ...);
              obj.show();
               MessageBox.Show("Texto");
           */
        }

        private void validarTextbox(TextBox txtcomp, string msgError)
        {
            string cuadritos = txtcomp.Text.Trim();
            if (cuadritos.Length > 0)
                error.SetError(txtcomp, "");
            else
                error.SetError(txtcomp, msgError);


        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Registro actualizado.",
                "Directorio Telefónico",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea eliminar el registro?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show(
                    "Registro eliminado.",
                    "Directorio Telefónico",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Implementar búsqueda.",
                "Directorio Telefónico",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtExtension.Clear();
            txtCargo.Clear();
            txtEmpresa.Clear();
            txtCorreo.Clear();
            txtObservaciones.Clear();

            chkActivo.Checked = true;

            txtNombre.Focus();
        }

        private void FrmDirectorioTelefonico_Load(object sender, EventArgs e)
        {
            componentes.Add(txtNombre);
            componentes.Add(txtApellidos);
            componentes.Add(txtTelefono);
            componentes.Add(txtExtension);
            componentes.Add(txtCargo);
            componentes.Add(txtEmpresa);
            componentes.Add(txtCorreo);
            componentes.Add(txtId);
        }

        private void FrmDirectorioTelefonico_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("¡Noooo:/! me mori :(");
        }
    }
}
