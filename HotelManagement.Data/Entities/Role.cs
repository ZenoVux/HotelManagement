﻿using Microsoft.AspNetCore.Identity;

namespace HotelManagement.Data.Entities
{
    public class Role : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
