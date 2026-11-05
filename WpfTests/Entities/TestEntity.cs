using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WpfTests.Entities;

[Table("Tests")] //таблиця тестів

public class TestEntity
{
    [Key] //ключ 
    public int Id { get; set; } //унікальний ідентифікатор тесту

    [Required, StringLength(200)] //обов'язковість та обмеження довижини тексту

    public string Title { get; set; } = null; //назва тесту

    [StringLength (1000)] //обмеження довжини тексту
    public string? Description { get; set; } //опис тесту

    [Required] //обов'язковість поля
    public DateTime CreatedAt { get; set; } = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc); //дата створення тесту

    [Range(1,60)] //обмеження на значення від 1 до 60 хвилин
    public int? TimeLimitMinutes { get; set; } //час на проходження тесту в хвилинах

    public ICollection<QuestionEntity> Questions { get; set; } = null!; //колекція питань, які належать до тесту
}
