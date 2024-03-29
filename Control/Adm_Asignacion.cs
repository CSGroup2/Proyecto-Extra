﻿using Datos;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control {
    public class Adm_Asignacion {

        /*
            Aplicar el patron de diseño Singleton:
            1. Crear 1 atributo estático y privado de la misma clase.
            2. Cambiar el constructor de public a private.
            3.1. Crear un getter del atributo estático del tipo de la clase.
            3.2.Verificar si atributo es null, si es así, crearlo.
        */

        private static Adm_Asignacion adm = null;   // 1.


        /*---------------Parametros en null para llamarlos en getadm------------*/
        Validacion v = null;
        Peticion p = null;
        Cliente cl = null;

        Conductor co = null;
        Ambulancia a = null;
        Asignacion_Detalle ad = null;
        Asignacion_Cabecera ac = null;
        Secretaria s = null;

        List<Asignacion_Cabecera> listaC = null;
        List<Asignacion_Detalle> listaD = null;


        Adm_Login admL = Adm_Login.GetAdm();

        Adm_Peticion admP = Adm_Peticion.GetAdm();
        Adm_Ambulancia admA = Adm_Ambulancia.GetAdm();
        Adm_Conductor admCo = Adm_Conductor.GetAdm();

        //Getters y Setters de las listas cabecera y detalle
        public List<Asignacion_Cabecera> ListaC { get => listaC; set => listaC = value; }

        public List<Asignacion_Detalle> ListaD { get => listaD; set => listaD = value; }

        //constructor adm asignacion
        private Adm_Asignacion() 
        {
            v = new Validacion();
            p = new Peticion();
            cl = new Cliente();
            co = new Conductor();
            a = new Ambulancia();
            ad = new Asignacion_Detalle();
            ac = new Asignacion_Cabecera();
            s = new Secretaria();

            listaC = new List<Asignacion_Cabecera>();
            listaD = new List<Asignacion_Detalle>();
        }

        public static Adm_Asignacion GetAdm() //getadm para aplicar singleton
        {
            if (adm == null)                    //3.2
            {
                adm = new Adm_Asignacion();
            }
            return adm;
        }

        /*--------------------------Frm_Asignacion_Registrar-------------------------------*/

        //Llena dgv con las peticiones "En Progreso"
        public void llenarTablaPeticion(DataGridView dgvPeticion)
        {
            dgvPeticion.Refresh();
            admP.llenarTablaPeticion(dgvPeticion);
        }


        /*--------------------------Frm_Asignar_Ambulancia-------------------------------*/

        //Llena dgv con las ambulancias "disponibles"
        public void llenarTablaAmbulanciaAsignar(DataGridView dgvAmbulancia)
        {
            admA.ListarAmbulanciasDisponibles(dgvAmbulancia);
        }

        //Llena dgv con los conductores "disponibles"
        public void llenarTablaConductorAsignar(DataGridView dgvConductores)
        {
            admCo.ConductorListarDisponibles(dgvConductores);
        }

        //Llena La lista de asignacion detalle y la muestra en un dgv
        public void enlistarCond_AmbAsignados(string id_peticion, string id_conductor, string id_ambulancia, DataGridView dgvAmb_Cond, Label lbl_cantAmbulancia, Label lblAmb_Restantes)
        {
            int id_P = v.AEntero(id_peticion), id_C=v.AEntero(id_conductor), id_A=v.AEntero(id_ambulancia);

            p = new Peticion();
            p.Id_peticion = id_P;

            co = new Conductor();
            co.Id_conductor = id_C;

            a = new Ambulancia();
            a.Id_ambulancia = id_A;

            ad = new Asignacion_Detalle(p, co, a);
            ListaD.Add(ad);
            llenarDgvCA(dgvAmb_Cond,ListaD);  //llena el dgv
            calcularAmbRestantes(lbl_cantAmbulancia, lblAmb_Restantes,ListaD,id_P); //calcula las ambulancias restantes para completar la asignacion
        }

        //limpia todo lo que el usuario haya ingresado
        public void LimpiarTodo(Label lblAmb_Restantes, Label lblCliente, Label lblIdPeticion, Label lbl_cantAmbulancia, Label lbl_conductor, Label lbl_id_ambulancia, Label lbl_id_conductor, Label lbl_Placa, Label lbl_TipoAmbulancia, DataGridView dgvAmb_Cond)
        {
            limpiarListas(ListaD, ListaC);
            dgvAmb_Cond.Rows.Clear();
            lblAmb_Restantes.Text = "";
            lblCliente.Text = "";
            lblIdPeticion.Text = "";
            lbl_cantAmbulancia.Text = "";
            lbl_conductor.Text = "";
            lbl_id_ambulancia.Text = "";
            lbl_id_conductor.Text = "";
            lbl_Placa.Text = "";
            lbl_TipoAmbulancia.Text = "";
        }

        //cambia el label de las ambulancias restantes para conocer
        //cuantas ambulancias faltan para completar la asignacion
        private void calcularAmbRestantes(Label lbl_cantAmbulancia, Label lblAmb_Restantes, List<Asignacion_Detalle> listaD, int id_P)
        {
            int i = 0;
            int r = 0;
            int Ca = v.AEntero(lbl_cantAmbulancia.Text);
            int Ar = v.AEntero(lblAmb_Restantes.Text);

            foreach (Asignacion_Detalle x in listaD) 
            {
                if (x.Peticion.Id_peticion == id_P) 
                {
                    i++;
                }
            }
            if (i > 0) 
            {
                r = Ca - i;
                lblAmb_Restantes.Text = r.ToString(); ;
            }
        }

        //llena el dgv de los conductores y ambulancias asignadas
        private void llenarDgvCA(DataGridView dgvAmb_Cond, List<Asignacion_Detalle> listaD)
        {
            dgvAmb_Cond.Rows.Clear();
            foreach (Asignacion_Detalle x in listaD) 
            {
                dgvAmb_Cond.Rows.Add(x.Peticion.Id_peticion, x.Conductor.Id_conductor, x.Ambulancia.Id_ambulancia);
            }
        }

        //guarda asignacion cabecera en lista y manda toda la asignacion a la base de datos
        public void guardarAsignacion(string id_peticion)
        {
            int id_S = admL.IdUsuario();
            int id_P = v.AEntero(id_peticion);

            p = new Peticion();
            p.Id_peticion = id_P;

            s = new Secretaria();
            s.Id_secretaria = id_S;

            ac = new Asignacion_Cabecera(p, s, "En Progreso", ListaD);
            
            ListaC.Add(ac);
            if (guardarAsignacionBD(ListaC, ListaD) == "1") 
            {
                limpiarListas(ListaD,ListaC);
            }
        }

        //Clear de las listas para limpiarlas
        private void limpiarListas(List<Asignacion_Detalle> listaD, List<Asignacion_Cabecera> listaC)
        {
            listaD.Clear();
            listaC.Clear();
        }

        //limpia los labels del frm
        public void LimpiarLabelsCA(Label lbl_id_ambulancia, Label lbl_id_conductor, Label lbl_conductor, Label lbl_Placa)
        {
            lbl_conductor.Text = "";
            lbl_id_ambulancia.Text = "";
            lbl_id_conductor.Text = "";
            lbl_Placa.Text = "";
        }

        Datos_Asignacion datosAsignacion = new Datos_Asignacion(); //objeto para interactuar con el proyecto Datos

        //guarda asignacion en base de datos
        public string guardarAsignacionBD(List<Asignacion_Cabecera> ac,List<Asignacion_Detalle> ad)
        {
            string mensaje = "";
            mensaje = datosAsignacion.insetarAsignacion(ac,ad);
            if (mensaje[0] == '1')
            {
                MessageBox.Show("La Asignación fue ingresada correctamente.");
            }
            else 
            {
                mensaje = "No se pudo insertar";
                MessageBox.Show("Error." + mensaje);
            }
            return mensaje;
        }

        /*--------------------------Frm_Asignacion_Consultar-------------------------------*/
        public void LlenarTablaAsignaciones(DataGridView dgvAsignaciones)
        {
            dgvAsignaciones.Refresh();
            dgvAsignaciones.DataSource = datosAsignacion.LlenarTablaAsignaciones(admL.IdUsuario());
        }

        public void LimpiarCamposConsulta(TextBox txt_Cedula,RadioButton rdbCumplida, RadioButton rdbProgreso)
        {
            txt_Cedula.Text = "";
            rdbCumplida.Checked = false;
            rdbProgreso.Checked = false;
        }

        public void FiltarAsignaciones(DataGridView dgvAsignaciones, TextBox txt_Cedula, RadioButton rdbCumplida, RadioButton rdbProgreso)
        {
            string ced = txt_Cedula.Text,
                condicion = v.VerificarCondicion(rdbProgreso, rdbCumplida);
            dgvAsignaciones.DataSource=null;
            dgvAsignaciones.DataSource = datosAsignacion.FiltrarAsignaciones(admL.IdUsuario(), ced, condicion);
        }

        /*--------------------------Frm_Asignacion_Editar-------------------------------*/
        public void LlenarCamposAsignacionEditar(int idAs, Label lblCliente, Label lbl_TipoAmbulancia, Label lbl_cantAmbulancia, Label lblOrigen, Label lblDestino)
        {
            ac = datosAsignacion.ConsultarAsignacionXId(idAs);
            lblCliente.Text = ac.Peticion.Cliente.Nombre_1 + " " + ac.Peticion.Cliente.Apellido_1;
            lbl_TipoAmbulancia.Text = ac.Ambulancia;
            lbl_cantAmbulancia.Text = ac.Peticion.N_ambulancia.ToString();
            lblOrigen.Text = ac.Peticion.Punto_origen.ToString();
            lblDestino.Text = ac.Peticion.Punto_destino.ToString();
        }

        public void LlenarCombos(ComboBox cmbConductores, ComboBox cmbAmbulancias)
        {
            cmbAmbulancias.DataSource = null;
            cmbAmbulancias.DataSource = datosAsignacion.LlenarComboAmbulancia();
            cmbAmbulancias.ValueMember = "CODAMBULANCIA";
            cmbAmbulancias.DisplayMember = "NOMBRE";

            cmbConductores.DataSource = null;
            cmbConductores.DataSource = datosAsignacion.LlenarComboConductores();
            cmbConductores.ValueMember = "CODCONDUCTOR";
            cmbConductores.DisplayMember = "NOMBRE";
        }

        public void LimpiarCmbs(ComboBox cmbAmbulancias, ComboBox cmbConductores)
        {
            LlenarCombos(cmbConductores, cmbAmbulancias);
        }

        public string EditarAsignacionDetalle(int id_detalle, int id_conductor, int id_ambulancia)
        {
            string mensaje = "", msj = "";
            mensaje = datosAsignacion.editarAsignacion(id_detalle, id_conductor, id_ambulancia);  //editar la asignacion en la base de datos

            if (mensaje[0] == '1')
                msj = "1";
            else
                msj = "Error: " + mensaje;
            //msj = "Error no se pudo ingresar la petición."; //solo para el TEST
            return msj;
        }

        public void LlenarDgvEditar(int idAs, DataGridView dgvAmb_Cond)
        {
            dgvAmb_Cond.DataSource = null;
            dgvAmb_Cond.DataSource = datosAsignacion.consultarAsigDetallexIdAs(idAs);
        }

        public void CumplirAsignacion(int idAs)
        {
            string mensaje = datosAsignacion.CumplirAsignacion(idAs);  //editar la asignacion en la base de datos

            if (mensaje[0] == '1')
                MessageBox.Show("Se ha cumplido la peticion.");
            else
                MessageBox.Show("error al cumplir petición.");
        }

        /*--------------------------Frm_Asignacion_Eliminar-------------------------------*/
        public void LlenarTablaAsignacionesAntiguas(DataGridView dgvAsignaciones)
        {
            dgvAsignaciones.Refresh();
            dgvAsignaciones.DataSource = datosAsignacion.ListarAsignacionesAntiguas(admL.IdUsuario());
        }

        public string EliminarAsignacion(int id)
        {
            string msj = "";
            msj = datosAsignacion.EliminarAsignacion(id);
            return msj;
        }
    }
}
