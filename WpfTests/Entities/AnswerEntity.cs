using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WpfTests.Entities;

[Table("Answers")] //таблиця в якій будуть відповіді на питання
public class AnswerEntity
{
    [Key] //ключ
    public int Id { get; set; } //унікальний ідентифікатор відповіді

    [Required, StringLength(1000)] //обмеження на довжину тексту відповіді
    public string Text { get; set; } = string.Empty; //текст відповіді

    public bool IsCorrect { get; set; } //перевіряє чи є відповідь правильною

    [Required] //вказує на обов'язковість поля
    [ForeignKey(nameof(Question))] //зовнішній ключ який зв'язує відповідь з питанням
    public int QuestionId { get; set; } //ID питання до якого належить відповідь

    public QuestionEntity? Question { get; set; } //посилання на об'єкт, де знаходиться відповідь
}
