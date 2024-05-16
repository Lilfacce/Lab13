using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel.DataAnnotations;

namespace Lab13
{
    public class General
    {
        [Required(ErrorMessage = "El Nombre es Requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Codigo es Requerido")]
        public int Codigo { get; set; }

        public string Descripcion { get; set; }
        public int P_Compra { get; set; }
        public int P_Venta { get; set; }


        public General()
        {
            Nombre = string.Empty;
            Descripcion = string.Empty;
        }
    }
}
