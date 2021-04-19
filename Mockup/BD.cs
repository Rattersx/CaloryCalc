using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
//using System.Data.Entity;

namespace Mockup
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } //название
        public string Description { get; set; } //описание

        [Required]
        public double Kcal { get; set; } //кол-во калорий

        [Required]
        public double Ffat { get; set; } //кол-во жиров

        [Required]
        public double Carbohydrate { get; set; } //кол-во углеводов

        [Required]
        public double Protein { get; set; } //кол-во белка

        [Required]
        public bool IsAlergic { get; set; } //Аллерген ли

        [Required]
        public double Density { get; set; } //Плотность

        public virtual ICollection<DishItem> DishItems { get; set; }
    }

    public class Dish
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } //название
        public string Description { get; set; } //описание

        public virtual ICollection<DishItem> DishItems { get; set; }
    }

    public class DishItem
    {
        [Required]
        public double Value { get; set; } //количество чегото)

        [ForeignKey(nameof(MeasurementUnit))]
        public int MeasurementUnitId { get; set; }
        public MeasurementUnit MeasurementUnits { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        [ForeignKey(nameof(Dish))]
        public int DishId { get; set; }
        public virtual Dish Dish { get; set; }
    }

    public class MeasurementUnit
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } //название измерения
        public double? InGramm { get; set; } //в граммах
        public double? Volume { get; set; } //обьем

        public virtual ICollection<DishItem> DishItems { get; set; }
    }

    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base(@"Server=(localdb)\mssqllocaldb;Database=CalcOfCalories;Trusted_Connection=True;")
        {
            Database.CreateIfNotExists();
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<DishItem> DishItems { get; set; }
        public DbSet<MeasurementUnit> MeasurementUnits { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<DishItem>()
                .HasKey(di => new { di.ProductId, di.DishId });
        }
    }
}


