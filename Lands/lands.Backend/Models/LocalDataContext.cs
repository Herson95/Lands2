﻿
namespace lands.Backend.Models
{
    using Domain;
    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<User> Users { get; set; }
    }
}