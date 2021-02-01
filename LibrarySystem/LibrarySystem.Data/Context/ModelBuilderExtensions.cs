using System;
using System.Collections.Generic;
using System.Text;
using LibrarySystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Data.Context
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Author>().HasData(
                new List<Author>
                {
                    new Author()
                    {
                        Id = Guid.Parse("c123b30a-bb3b-4415-9208-feb89a70fd28"),
                        FirstName = "William",
                        LastName = "Shakespeare",
                        DateOfBirth = DateTimeOffset.Parse("1964, 2, 10")
                    },
                    new Author()
                    {
                        Id = Guid.Parse("19d3c6be-ddf5-4aa6-8448-30cd55a6ac0a"),
                        FirstName = "John",
                        LastName = "Doe",
                        DateOfBirth = DateTimeOffset.Parse("1973, 10,12")
                    },
                    new Author()
                    {
                        Id = Guid.Parse("296ae62d-959d-42c4-ba9f-5b2713b03d5e"),
                        FirstName = "Agatha",
                        LastName = "Christie",
                        DateOfBirth = DateTimeOffset.Parse("1890, 9, 15")
                    }
                }


            );

            modelBuilder.Entity<Book>().HasData(
                new List<Book>
                {

                    new Book
                    {
                        Id = Guid.Parse("f9787b4e-8ee5-4b6a-b19c-f8bba5624d10"),
                        AuthorId = Guid.Parse("c123b30a-bb3b-4415-9208-feb89a70fd28"),
                        Name = "Hamlet",
                        Description = "In this guide, I’ll walk you through how to write a book .....",
                        MainCategory = "Poetry",
                        SubCategory = "novels"
                    },
                    new Book
                    {
                        Id = Guid.Parse("633212b6-f6de-4c98-a6ec-16e742643ef2"),
                        AuthorId = Guid.Parse("19d3c6be-ddf5-4aa6-8448-30cd55a6ac0a"),
                        Name = "Hamlet",
                        Description = "In this guide, I’ll walk you through how to write a book .....",
                        MainCategory = "History",
                        SubCategory = "Movies"
                    },
                    new Book
                    {
                        Id = Guid.Parse("790874ac-3910-4c4b-9287-a50a2b8f27b6"),
                        AuthorId = Guid.Parse("296ae62d-959d-42c4-ba9f-5b2713b03d5e"),
                        Name = "Hamlet",
                        Description = "In this guide, I’ll walk you through how to write a book .....",
                        MainCategory = "novels",
                        SubCategory = "Police novels"
                    }



                });

        }
    }
}
