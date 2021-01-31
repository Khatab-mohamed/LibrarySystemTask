﻿using System;

namespace LibrarySystem.Domain.Entities
{
    public class Book
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MainCategory { get; set; }
        public string SubCategory { get; set; }
        public Author Author { get; set; }
        public Guid AuthorId { get; set; }
    }
}
