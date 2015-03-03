using System;


namespace AppAgendaUTB.Modelo
{
    public class Personas
    {
        # region "Atributos"
        private string id;        
        private string nombre;        
        private string apellido;        
        private string emailP;        
        private string emailW;        
        private string telefonoP;        
        private string telefonoW;        
        # endregion

        #region"Propiedades"
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string EmailP
        {
            get { return emailP; }
            set { emailP = value; }
        }

        public string EmailW
        {
            get { return emailW; }
            set { emailW = value; }
        }

        public string TelefonoP
        {
            get { return telefonoP; }
            set { telefonoP = value; }
        }

        public string TelefonoW
        {
            get { return telefonoW; }
            set { telefonoW = value; }
        }
        #endregion

        #region"Constructor"
        public Personas()
        {
            ///<summary>
            ///Contructor de clase Personas
            ///</summary>
            this.id = "XXX000";
            this.nombre = "Nombre Persona";
            this.apellido = "Apellido Persona";
            this.emailP = "e-mailP@dominio.com";
            this.emailW = "e-mailW@dominio.com";
            this.telefonoP = "6000000";
            this.telefonoW = "6600000";
        }
        ///<summary>
        ///Contructor de inicialización de Personas
        ///</summary>
        ///
        public Personas(string id, string nombre, string apellido, string emailP, string emailW, string telefonoP,string telefonoW)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.emailP = emailP;
            this.emailW = emailW;
            this.telefonoP = telefonoP;
            this.telefonoW = telefonoW;

        }

        #endregion

        #region"Metodos Sobre Escritos"
        public override string ToString()
        {
            return   "Id:  " + this.id + "\n" +
                     "Nombre" + this.nombre + "\n" +
                     "Apellido: " + this.apellido + "\n" +
                     "e-Mail P" + this.emailP + "\n" +
                     "e-Mail W" + this.emailW + "\n" + 
                     "Telefono P" + this.telefonoP + "\n" + 
                     "Telefono W" + this.telefonoW;
        }

        public override bool Equals(object obj)
        {
            Personas p = (Personas)obj;
            bool result = false;
            if ((this.id == p.id) &&
                (this.nombre == p.nombre) &&
                (this.apellido == p.apellido) &&
                (this.emailP == p.emailP) &&
                (this.emailW == p.emailW) &&
                (this.telefonoP == p.telefonoP) &&
                (this.telefonoW == p.telefonoW))

                result = true;
            return result;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        #endregion


    }
}