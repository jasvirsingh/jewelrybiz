
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace JewelryBiz.UI
{

using System;
    using System.Collections.Generic;
    
public partial class Order
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Order()
    {

        this.Order_Products = new HashSet<Order_Products>();

    }


    public int OrderID { get; set; }

    public System.DateTime OrderDate { get; set; }

    public System.DateTime DeliveryDate { get; set; }

    public int CID { get; set; }



    public virtual Customer Customer { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Order_Products> Order_Products { get; set; }

}

}
