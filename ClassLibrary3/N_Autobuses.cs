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
    public class N_Autobuses
    {
        D_Autobuses ObjDatos_A = new D_Autobuses();

        public void Guardando_N()
        {
            ObjDatos_A.Guardar_D();
        }

        public DataTable Buscando_N()
        {
            return ObjDatos_A.Buscar_D();
        }
        public DataTable Mostrando_N()
        {
            return ObjDatos_A.Mostrar_D();
        }

        public void Editando_N()
        {
            ObjDatos_A.Editar_D();
        }

        public void Borrando_N()
        {
            ObjDatos_A.Borrar_D();
        }
    }
}
