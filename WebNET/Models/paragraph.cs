//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebNET.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class paragraph
    {
        public string paragraph_id { get; set; }
        public string paragraph_title { get; set; }
        public string paragraph_content { get; set; }
        public string paragraph_blogsId { get; set; }
    
        public virtual blog blog { get; set; }
    }
}