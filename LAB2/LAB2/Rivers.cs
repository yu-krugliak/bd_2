//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LAB2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rivers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rivers()
        {
            this.Waterfalls = new HashSet<Waterfalls>();
        }
    
        public int RV_ID { get; set; }
        public string RV_NAME { get; set; }
        public int RV_COUNTRY_ID { get; set; }
    
        public virtual Countries Countries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Waterfalls> Waterfalls { get; set; }
    }
}
