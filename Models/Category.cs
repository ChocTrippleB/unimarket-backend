﻿namespace unimarket_backend.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<SubCategory> Subcategory { get; set; }
    }
}
