using Microsoft.EntityFrameworkCore;
using PrometheusData.Models;
using System;

namespace PrometheusData
{
    public interface IPrometeusContext : IDisposable
    {
        DbSet<Person> People { get; set; }

        void SaveChanges();
        void EnsureCreated();
    }
}