﻿using SQLite;
using SQLiteNetExtensions.Attributes;
namespace Aruncutean_Serban_7.Models
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        [OneToMany]
        public List<ListProduct> ListProducts { get; set; }
    }
}
