using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WpfTests.Entities;

namespace WpfTests;

public class MyDataContext : DbContext
{
    public DbSet<TestEntity> Tests { get; set; } //назва таблиці, де будуть зберігатися тести
    public DbSet<QuestionEntity> Questions { get; set; } //назва таблиці, де будуть зберігатися питання
    public DbSet<AnswerEntity> Answers { get; set; } //назва таблиці, де будуть зберігатися відповіді

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //Назва файлу, де зберігаються користувачі
        optionsBuilder.UseSqlite("Data Source=MyDatabase.db");
    }
}
