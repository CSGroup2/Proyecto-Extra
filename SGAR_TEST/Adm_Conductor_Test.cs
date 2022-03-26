using Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace SGAR_TEST {
    [TestClass]
    public class Adm_Conductor_Test {

        #region Test Methods: Registrar
        
        [TestMethod]
        public void ConductorTestRegistrarExistente () {
            Adm_Conductor admConductor = Adm_Conductor.GetAdm ();
            string
                mensaje = "",
                cedula = "0992015890",
                nombre1 = "Renan",
                nombre2 = "Oswaldo",
                apellido1 = "Perez",
                apellido2 = "Balladares",
                telefono = "0992015890",
                sexo = "Masculino";
            DateTime
                fechaNacimiento = new DateTime (2022, 02, 20),
                fechaContrato = new DateTime (2022, 02, 20);
            mensaje = admConductor.ConductorRegistrar (cedula, nombre1, nombre2, apellido1, apellido2, telefono, sexo, fechaNacimiento, fechaContrato);
            Assert.AreEqual ("¡CÉDULA YA EXISTE!", mensaje);
        }
        
        /*
        [TestMethod]
        public void ConductorTestRegistrarNuevo () {
            Adm_Conductor admConductor = Adm_Conductor.GetAdm ();
            string
                mensaje = "",
                cedula = "1313131313",
                nombre1 = "Alberto",
                nombre2 = "Juan",
                apellido1 = "Ramos",
                apellido2 = "Santos",
                telefono = "0912121212",
                sexo = "Masculino";
            DateTime
                fechaNacimiento = new DateTime (2022, 02, 20),
                fechaContrato = new DateTime (2022, 02, 20);
            mensaje = admConductor.ConductorRegistrar (cedula, nombre1, nombre2, apellido1, apellido2, telefono, sexo, fechaNacimiento, fechaContrato);
            Assert.AreEqual ("DATOS GUARDADOS CORRECTAMENTE.", mensaje);
        }
        */
        #endregion
        
        #region Test Methods: Consultar
        /*
        [TestMethod]
        public void ConsultarAmbulancia_NoExistenRegistros () {
            var admA = new Adm_Ambulancia ();
            DataTable dt = new DataTable ();
            int tipoA = 1, disponibilidad = 1, buscarOb = 1, buscarOp = 2;
            string dato = "RFG", msj = "";

            dt = admA.ConsultarAmbulancias (dato, tipoA, disponibilidad, buscarOb, buscarOp);

            msj = dt.Rows.Count.ToString ();

            Assert.AreEqual ("0", msj);
        }

        [TestMethod]
        public void ConsultarAmbulancia_ExistenRegistros () {
            var admA = new Adm_Ambulancia ();
            DataTable dt = new DataTable ();
            int tipoA = 1, disponibilidad = 1, buscarOb = 1, buscarOp = 2;
            string dato = "ABC", msj = "";

            dt = admA.ConsultarAmbulancias (dato, tipoA, disponibilidad, buscarOb, buscarOp);
            if (dt.Rows.Count > 0) {
                msj = "Se encontraron los registros";
            }

            Assert.AreEqual ("Se encontraron los registros", msj);
        }
        */
        #endregion

    }
}
