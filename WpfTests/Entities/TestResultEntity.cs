using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WpfTests.Entities;

[Table("TestResultEntity")] //таблиця результатів тестів
public class TestResultEntity
{
    [Key]
    public int Id { get; set; } //унікальний ідентифікатор результату тесту

    [Required,ForeignKey(nameof(Test))] //обов'язковість та зовнішній ключ до таблиці тестів
    public int TestId { get; set; } //ідентифікатор тесту, до якого належить результат
    public TestEntity Test { get; set; } = null!; //посилання на тест, до якого належить результат

    [Required,StringLength(100)] //обов'язковість та обмеження на довжину поля
    public string LastName { get; set; } = null!; //прізвище користувача, який проходив тест

    [Required,StringLength(100)] //обов'язковість та обмеження на довжину поля
    public string FirstName { get; set; } = null!; //ім'я користувача, який проходив тест

    [StringLength(100)] //обов'язковість та обмеження на довжину поля
    public string? MiddleName { get; set; } //по батькові користувача, який проходив тест

    public int CorrectAnswersCount { get; set; } //кількість правильних відповідей користувача
    public int WrongAnswersCount { get; set; } //кількість неправильних відповідей користувача

    [Required]//обов'язковість поля
    public DateTime StartAt { get; set; }

    [Required]//обов'язковість поля
    public DateTime FinishAt { get; set; } = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc); //дата та час завершення тесту
}
