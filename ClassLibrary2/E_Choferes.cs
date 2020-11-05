using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public static class E_Choferes
    {
        private static int ID;
        private static string Nombre;
        private static string Apellido;
        private static string Cedula;
        private static DateTime FechaNacimiento;

        public static int ID1 { get => ID; set => ID = value; }
        public static string Nombre1 { get => Nombre; set => Nombre = value; }
        public static string Apellido1 { get => Apellido; set => Apellido = value; }
        public static string Cedula1 { get => Cedula; set => Cedula = value; }
        public static DateTime FechaNacimiento1 { get => FechaNacimiento; set => FechaNacimiento = value; }
    }
}
