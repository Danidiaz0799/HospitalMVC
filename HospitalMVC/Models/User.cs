﻿using System;
using System.Collections.Generic;

namespace HospitalMVC.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Token { get; set; }

    public string? Role { get; set; }

    public string? Email { get; set; }
}
