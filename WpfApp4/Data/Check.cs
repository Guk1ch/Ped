//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp4.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Check
    {
        public int Id { get; set; }
        public Nullable<int> id_arenda { get; set; }
        public Nullable<int> id_film { get; set; }
    
        public virtual Arenda Arenda { get; set; }
        public virtual Film Film { get; set; }
    }
}
