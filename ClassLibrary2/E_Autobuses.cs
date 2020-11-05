using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public static class E_Autobuses
    {
        private static int ID;
        private static int ID_Chofer;
        private static string Marca;
        private static string Modelo;
        private static string Placa;
        private static string Color;
        private static DateTime Año;

        public static int ID1 { get => ID; set => ID = value; }
        public static int ID_Chofer1 { get => ID_Chofer; set => ID_Chofer = value; }
        public static string Marca1 { get => Marca; set => Marca = value; }
        public static string Modelo1 { get => Modelo; set => Modelo = value; }
        public static string Placa1 { get => Placa; set => Placa = value; }
        public static string Color1 { get => Color; set => Color = value; }
        public static DateTime Año1 { get => Año; set => Año = value; }
    }
}
