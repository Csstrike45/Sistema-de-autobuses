using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_AUTOBUS
    {
        CD_AUTOBUS cd_Autobus = new CD_AUTOBUS();

        //chofer-----------------------------------------------------------
        public List<CE_AUTOBUS> ListChofer(string buscar)
        {
            return cd_Autobus.Listado_Chofer(buscar);
        }

        public void InsertChofer(CE_AUTOBUS ce_Autobus)
        {
            cd_Autobus.InsertadoChofer(ce_Autobus);
        }

        public void EditChofer(CE_AUTOBUS ce_Autobus)
        {
            cd_Autobus.EditadoChofer(ce_Autobus);
        }

        public void DeleteChofer(CE_AUTOBUS ce_Autobus)
        {
            cd_Autobus.EliminadoChofer(ce_Autobus);
        }

        public DataTable cbxChofer()
        {
            return cd_Autobus.cbxChofer();
        }

        public void AvailableChofer(CE_AUTOBUS ce_Autobus)
        {
            cd_Autobus.DisponChofer(ce_Autobus);
        }

        public void AvailableChoferV(CE_AUTOBUS ce_Autobus)
        {
            cd_Autobus.DisponChoferV(ce_Autobus);
        }

        //autobus----------------------------------------------------------
        public List<CE_AUTOBUS> ListAutobus(string buscar)
        {
            return cd_Autobus.Listado_Autobus(buscar);
        }

        public void InsertAutobus(CE_AUTOBUS ce_Autobus)
        {
            cd_Autobus.InsertadoAutobus(ce_Autobus);
        }

        public void EditAutobus(CE_AUTOBUS ce_Autobus)
        {
            cd_Autobus.EditadoAutobus(ce_Autobus);
        }

        public void DeleteAutobus(CE_AUTOBUS ce_Autobus)
        {
            cd_Autobus.EliminadoAutobus(ce_Autobus);
        }

        public DataTable cbxAutobus()
        {
            return cd_Autobus.cbxAutobus();
        }

        public void AvailableAutobus(CE_AUTOBUS ce_Autobus)
        {
            cd_Autobus.DisponAutobus(ce_Autobus);
        }

        public void AvailableAutobusV(CE_AUTOBUS ce_Autobus)
        {
            cd_Autobus.DisponAutobusV(ce_Autobus);
        }

        //Ruta------------------------------------------------------------
        public List<CE_AUTOBUS> ListRutas(string buscar)
        {
            return cd_Autobus.Listado_Rutas(buscar);
        }

        public void InsertRuta(CE_AUTOBUS ce_Autobus)
        {
            cd_Autobus.InsertadoRuta(ce_Autobus);
        }

        public void EditRuta(CE_AUTOBUS ce_Autobus)
        {
            cd_Autobus.EditadoRuta(ce_Autobus);
        }

        public void DeleteRuta(CE_AUTOBUS ce_Autobus)
        {
            cd_Autobus.EliminadoRuta(ce_Autobus);
        }

        public DataTable cbxRuta()
        {
            return cd_Autobus.cbxRuta();
        }

        public void AvailableRuta(CE_AUTOBUS ce_Autobus)
        {
            cd_Autobus.DisponRuta(ce_Autobus);
        }

        public void AvailableRutaV(CE_AUTOBUS ce_Autobus)
        {
            cd_Autobus.DisponRutaV(ce_Autobus);
        }

        //Viajes--------------------------------------------------------------
        public List<CE_AUTOBUS> ListViaje(string buscar)
        {
            return cd_Autobus.ListarViajes(buscar);
        }

        public void InsertViaje(CE_AUTOBUS ce_Autobus)
        {
            cd_Autobus.InsertadoViaje(ce_Autobus);
        }

        public void FinishedViaje(CE_AUTOBUS ce_Autobus)
        {
            cd_Autobus.EliminadoViaje(ce_Autobus);
        }


    }
}
