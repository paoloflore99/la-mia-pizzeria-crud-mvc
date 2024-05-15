﻿
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace la_mia_pizzeria_static.Models;

    public class PizzeCintest : DbContext
    {
        public DbSet<Pizze> Pizze {  get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Pizze;" +
        "Integrated Security=True;TrustServerCertificate=True");
    }

    }


