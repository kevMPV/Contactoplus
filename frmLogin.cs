namespace ContactosPlus
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (usuario.Length > 0)
            {
                if (password.Length > 0)
                {
                    if (usuario == "eve" && password == "1406")
                    {
                        //Abrimos la sigiente ventana (FmrDirectorioTelefonico)
                        // MisFunciones.MensajeAlerta("Bienvenido al sistema");
                        FrmDirectorioTelefonico obj = new FrmDirectorioTelefonico();

                        this.Hide();//ocultar
                        obj.Show();//mostrar contactos
                        obj.FormClosed += (s, args) => this.Show();
                    }
                    else
                    {
                        MisFunciones.MensajeAlerta("verifica tus datos");
                        txtUsuario.Text = "";
                        txtPassword.Text = "";
                        txtUsuario.Focus();
                        ;
                    }
                }
                else
                {
                    MisFunciones.MensajeAlerta("Escribe tu contraseña");
                    txtPassword.Focus();
                }

            }
            else
            {
                MisFunciones.MensajeAlerta("Agrga tu usuario");
                txtUsuario.Focus();
            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
