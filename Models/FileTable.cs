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
    
    public partial class FileTable
    {
        public int FileId { get; set; }
        public string FileName { get; set; }
        public int SenderId { get; set; }
        public int GrpId { get; set; }
        public System.DateTime Date { get; set; }
        public System.TimeSpan Time { get; set; }
        public string FilePath { get; set; }
        public string FileType { get; set; }
    
        public virtual GroupMemberTable GroupMemberTable { get; set; }
        public virtual GroupTable GroupTable { get; set; }
    }
}
