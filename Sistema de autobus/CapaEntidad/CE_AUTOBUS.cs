using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_AUTOBUS
    {
        //ATRIBUTOS DE CHOFER
        private int _ID_CHOFER;
        private string _NOMBRE;
        private string _APELLIDO;
        private DateTime _FECHA;
        private string _CEDULA;
        private string _DISPON;

        //ATRIBUTOS PARA AUTOBUS
        private int _ID_AUTOBUS;
        private string _MARCA;
        private string _MODELO;
        private string _PLACA;
        private string _COLOR;
        private string _ANIO;

        //ATRIBUTOS PARA RUTA
        private int _ID_RUTA;
        private string _NOMBRE_RUTA;

        //ATRIBUTOS PARA VIAJES
        private int _ID_VIAJE;
        private string _CHOFER;
        private string _AUTOBUS;
        private string _RUTA;

        //PROPIEDADES DE CHOFER

        public int ID_CHOFER { get => _ID_CHOFER; set => _ID_CHOFER = value; }
        public string NOMBRE { get => _NOMBRE; set => _NOMBRE = value; }
        public string APELLIDO { get => _APELLIDO; set => _APELLIDO = value; }
        public DateTime FECHA { get => _FECHA; set => _FECHA = value; }
        public string CEDULA { get => _CEDULA; set => _CEDULA = value; }
        public string DISPON { get => _DISPON; set => _DISPON = value; }

        //PROPIEDADES DE AUTOBUS

        public int ID_AUTOBUS { get => _ID_AUTOBUS; set => _ID_AUTOBUS = value; }
        public string MARCA { get => _MARCA; set => _MARCA = value; }
        public string MODELO { get => _MODELO; set => _MODELO = value; }
        public string PLACA { get => _PLACA; set => _PLACA = value; }
        public string COLOR { get => _COLOR; set => _COLOR = value; }
        public string ANIO { get => _ANIO; set => _ANIO = value; }

        //PROPIEDADES DE RUTA
        public int ID_RUTA { get => _ID_RUTA; set => _ID_RUTA = value; }
        public string NOMBRE_RUTA { get => _NOMBRE_RUTA; set => _NOMBRE_RUTA = value; }

        //PROPIEDADES VIAJES 
        public int ID_VIAJE { get => _ID_VIAJE; set => _ID_VIAJE = value; }
        public string CHOFER { get => _CHOFER; set => _CHOFER = value; }
        public string AUTOBUS { get => _AUTOBUS; set => _AUTOBUS = value; }
        public string RUTA { get => _RUTA; set => _RUTA = value; }
    }
}
