//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Plano_operaciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Plano_operaciones()
        {
            this.Cotas_planos = new HashSet<Cotas_planos>();
        }
    
        public int id_op { get; set; }
        public int id_plano { get; set; }
        public int tipo_op { get; set; }
        public byte[] img { get; set; }
        public Nullable<int> id_Insumosnec { get; set; }
        public Nullable<System.DateTime> Fecha_fin { get; set; }
        public string Obs { get; set; }
        public Nullable<int> id_usuario { get; set; }
        public Nullable<int> is_usuarioAprobo { get; set; }
        public Nullable<bool> op_finished { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotas_planos> Cotas_planos { get; set; }
        public virtual Diccionario_odfm Diccionario_odfm { get; set; }
        public virtual odfm_insumos odfm_insumos { get; set; }
        public virtual Plano Plano { get; set; }
        public virtual USUARIOS USUARIOS { get; set; }
        public virtual USUARIOS USUARIOS1 { get; set; }
    }
}
