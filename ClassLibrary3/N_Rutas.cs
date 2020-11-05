using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidades;
using System.Data;

namespace Capa_Negocios
{
    public class N_Rutas
    {
        D_Rutas ObjDatos = new D_Rutas();

        public void Guardando_N()
        {
            ObjDatos.Guardar_D();
        }

        public DataTable Buscando_N()
        {
            return ObjDatos.Buscar_D();
        }
        public DataTable Mostrando_N()
        {
            return ObjDatos.Mostrar_D();
        }

        public void Editando_N()
        {
            ObjDatos.Editar_D();
        }

        public void Borrando_N()
        {
            ObjDatos.Borrar_D();
        }
    }
}
