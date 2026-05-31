using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactosPlus
{
    internal class MisFunciones
    {
        //el modificador de acceso static se utiliza para ivocar
        //un metodo sin necesidad de instacias la clase
        public static void MensajeAlerta(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
