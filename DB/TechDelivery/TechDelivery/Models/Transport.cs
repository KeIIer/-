//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechDelivery.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transport()
        {
            this.Carriage = new HashSet<Carriage>();
        }
    
        public int TransportId { get; set; }
        public string TransportType { get; set; }
        public Nullable<int> TransportExpluatationCost { get; set; }
        public Nullable<int> LeasingCompanyReference { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Carriage> Carriage { get; set; }
        public virtual LeasingCompany LeasingCompany { get; set; }
    }
}
