//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnityTalk.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GroupImgTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GroupImgTable()
        {
            this.GroupTables = new HashSet<GroupTable>();
        }
    
        public int GrpImgId { get; set; }
        public string GrpImgPath { get; set; }
        public string ImgName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GroupTable> GroupTables { get; set; }
    }
}
