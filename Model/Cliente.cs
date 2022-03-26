using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Cliente : Persona
    {
        //Nota: Clase creada para luego poder recoger todos los datos que se competen en un objeto de este tipo de clase


        //Variables o campos de la clase persona
        private int id_cliente;
        private int id_hospital;
        private int id_estado; 
        private Usuario usuario;

        //constructor por defecto
        public Cliente() : base()
        {
            this.id_hospital = 0; 
            this.usuario = new Usuario(); 
        }

        //constructor parametrizado
        public Cliente(int id_hospital, Usuario usuario, int id_estado, int id_persona, string cedula, string nombre_1, string nombre_2, string apellido_1, string apellido_2, string sexo, DateTime fecha_nac, string telefono, string estado) : base (id_persona, cedula, nombre_1, nombre_2, apellido_1, apellido_2, sexo, fecha_nac, telefono)
        {
            this.id_hospital = id_hospital;
            this.usuario = usuario;
            this.id_estado = id_estado;
        }

        public Cliente(int idcliente, int id_hospital, Usuario usuario, int id_estado, int id_persona, string cedula, string nombre_1, string nombre_2, string apellido_1, string apellido_2, string sexo, DateTime fecha_nac, string telefono, string estado) : base(id_persona, cedula, nombre_1, nombre_2, apellido_1, apellido_2, sexo, fecha_nac, telefono)
        {
            this.id_cliente = idcliente; 
            this.id_hospital = id_hospital;
            this.usuario = usuario;
            this.id_estado = id_estado;
        }


        //Getters and setters
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Id_hospital { get => id_hospital; set => id_hospital = value; }
        public int Id_estado { get => id_estado; set => id_estado = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }

        public override string ToString()
        {
            return base.ToString()+ "\r\n hospital" + Id_hospital + "\r\n idcliente" + Id_cliente + "\r\n estado" + Id_estado + "\r\n correo" + Usuario.Correo + "\r\n nmbreuse" + Usuario.Nombre_usuario + "\r\n contra" + Usuario.Contrasenia;
        }
    }

}
