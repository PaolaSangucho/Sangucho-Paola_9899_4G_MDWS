//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo.Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class FACTURA
    {
        public long FACT_CODIGO { get; set; }
        public long CLI_CODIGO { get; set; }
        public string FACT_NUMERO { get; set; }
        public System.DateTime FACT_FECHA { get; set; }
        public decimal FACT_MONTOTOTAL { get; set; }
        public bool FACT_BORRADO { get; set; }
        public long FACT_CANTIDAD { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
    }
}
