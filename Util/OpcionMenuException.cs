using System;
namespace CentralTelefonica.Util
{
    public class OpcionMenuException : Exception
    {        
        private string message = "Error, debe de ingresar una opción válida";
        public override string Message
        {
            get { return message;}
        }        
    }
}