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
    
    public partial class OrderTable
    {
        public int OrderId { get; set; }
        public string OrderItems { get; set; }
        public Nullable<int> OrderCost { get; set; }
        public Nullable<int> ClientReference { get; set; }
        public Nullable<int> StorageReference { get; set; }
        public Nullable<int> OrderDuration { get; set; }
        public Nullable<int> EmployeeReference { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Employees Employees { get; set; }
        public virtual Storage Storage { get; set; }
    }
}