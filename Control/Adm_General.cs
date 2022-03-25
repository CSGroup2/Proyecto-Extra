using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Control {
    public class Adm_General {

        /*
           Aplicar el patron de diseño Singleton:
           1. Crear 1 atributo estático y privado de la misma clase.
           2. Cambiar el constructor de public a private.
           3.1. Crear un getter del atributo estático del tipo de la clase.
           3.2.Verificar si atributo es null, si es así, crearlo.
       */

        private static Adm_General adm_General = null;    // 1.
        Datos_General Datos_General = null;
        //Persona Persona = null;

        //public Usuario_Cache UsuarioCache { get => usuarioCache; set => usuarioCache = value; }

        // Constructor: Adm_Login
        private Adm_General () {                  // 2.
            Datos_General = new Datos_General ();
        }

        // Getter: GetAdm
        public static Adm_General GetAdm () {     // 3.1.
            if (adm_General == null) {                  //3.2
                adm_General = new Adm_General ();
            }
            return adm_General;
        }

        /*------------------------------ Llenar Combo ------------------------------*/

        public DataTable DisponibilidadLlenarCombo () {
            return Datos_General.DisponibilidadLlenarComboDatos ();
        }

        public DataTable EstadoLlenarCombo () {
            //return Datos_General.listarEstados();
            return Datos_General.EstadoLlenarComboDatos ();
        }

        public DataTable HospitalLlenarCombo () {
            return Datos_General.HospitalLlenarComboDatos ();
        }



    }
}
