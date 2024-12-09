﻿namespace OnlineShop.Domain.Entities.Users;

public class User
{
    public long Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public ICollection<UserInRole> UserInRoles { get; set; }

}