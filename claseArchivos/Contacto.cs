using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactosPlus.claseArchivo
{
    internal class Contacto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public int telefono { get; set; }
        public int extencion { get; set; }
        public string puesto { get; set; }
        public string empresa { get; set; }
        public string correo { get; set; }
        public string observaciones { get; set; }
        public bool estatus { get; set; }

        public Contacto(int id, string nombre, string apellidos, int telefono, int extencion, string puesto, string empresa,string correo, string observaciones)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.extencion = extencion;
            this.puesto = puesto;
            this.empresa = empresa;
            this.correo = correo;
            this.observaciones = observaciones;
            this.estatus = true;

        }

        public override string ToString()
        {
            return $"ID:{this.id}|Nombre:{this.nombre}|Apellidos{this.apellidos}|Telefono{this.telefono}|Extension{this.extencion}|Puesto{this.puesto}|Empresa{this.empresa}|Correo{this.correo} |Observaciones{this.observaciones}|Estatus{this.estatus}";
        }

     }
 }