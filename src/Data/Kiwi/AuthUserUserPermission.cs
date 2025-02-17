﻿using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class AuthUserUserPermission
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PermissionId { get; set; }

        public virtual AuthPermission Permission { get; set; }
        public virtual AuthUser User { get; set; }
    }
}
