//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoccerManagerV1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Huella
    {
        public int Id { get; set; }
        public int RutJugador { get; set; }
        public byte[] Huella1 { get; set; }
    
        public virtual Jugador Jugador { get; set; }
    }
}
