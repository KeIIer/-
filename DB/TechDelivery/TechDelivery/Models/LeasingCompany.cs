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
    
    public partial class LeasingCompany
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LeasingCompany()
        {
            this.Transport = new HashSet<Transport>();
        }
    
        public int LeasingCompanyId { get; set; }
        public string LeasingCompanyName { get; set; }
        public string LeasingCompanyContactInfo { get; set; }
        public Nullable<int> LeasingCompanyTransportType { get; set; }
        public Nullable<int> LeasingCompanyRentCost { get; set; }
        public Nullable<int> LeasingCompanyRentTime { get; set; }
    
        public virtual LeasingCompanyTransportTable LeasingCompanyTransportTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transport> Transport { get; set; }
    }
}
