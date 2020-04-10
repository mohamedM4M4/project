namespace Clinic.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Permissions
    {
    
        public int Id { get; set; }
        public string Premission { get; set; }
        public int UserId { get; set; }
        public string PermissionPnl { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
