//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class TasksEntity
    {
        public TasksEntity()
        {
            this.UsersEntity = new HashSet<UsersEntity>();
        }
    
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public short Status { get; set; }
    
        public virtual ICollection<UsersEntity> UsersEntity { get; set; }
    }
}
