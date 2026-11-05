using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WpfTests.Entities;

public class QuestionEntity
{
    [Key] //ключ
    public int Id { get; set; } //унікальний ідентифікатор питання

    [Required, StringLength(1000)] //обмеження на довжину тексту питання
    public string Text { get; set; } = null!; //текст питання

    [Required, ForeignKey(nameof(Test))] //вказує на те що поле обов'язкове і є зовнішнім ключем
    public int TestId { get; set; } //ID тесту до якого належить питання
    public TestEntity Test { get; set; } = null!; //посилання на об'єкт, де знаходиться питання

    public ICollection<AnswerEntity> Answers { get; set; } = null!; //колекція відповідей на питання
}
