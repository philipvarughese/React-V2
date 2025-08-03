using System;
using System.Net;
using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Data;


 public class StoreContext(DbContextOptions options) : DbContext(options)
 {
    public DbSet<Product> Products { get; set; }
    

 }

