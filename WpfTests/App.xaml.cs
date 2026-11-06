using System.Windows;
using WpfTests.Entities;

namespace WpfTests;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        MyDataContext fileData = new MyDataContext();
        fileData.Database.EnsureCreated(); // створюємо базу даних, якщо вона ще не існує

        if(fileData.Tests.Any() == false) //перевіряємо, чи є тести в базі даних
        {
            TestEntity test = new TestEntity();
            test.Title = "Основи C#";
            test.Description = "Перевіряє знання по рівню C# - Змінні, Оператори умови, Цикли";
            test.TimeLimitMinutes = 15;
            fileData.Tests.Add(test); //додаємо тест до бази даних
            fileData.SaveChanges(); //зберігаємо зміни в базі даних
        }

        int countTest = fileData.Tests.Count(); //отримуємо кількість тестів в базі даних
        MessageBox.Show($"Кількість тестів в БД: {countTest}", "Інформація", MessageBoxButton.OK, MessageBoxImage.Information); //виводимо повідомлення з кількістю тестів

        //додаємо питання та відповіді до тесту, якщо їх ще немає
        //питання 1
        if(fileData.Questions.Any(q => q.TestId == 1 && q.Text == "Який тип даних використовується для зберігання цілого числа?") == false)
        {
            QuestionEntity question = new QuestionEntity();
            question.TestId = 1;
            question.Text = "Який тип даних використовується для зберігання цілого числа?";
            fileData.Questions.Add(question);
            fileData.SaveChanges();

            AnswerEntity answer1 = new AnswerEntity();
            answer1.QuestionId = question.Id;
            answer1.Text = "int";
            answer1.IsCorrect = true;
            fileData.Answers.Add(answer1);

            AnswerEntity answer2 = new AnswerEntity();
            answer2.QuestionId = question.Id;
            answer2.Text = "string";
            answer2.IsCorrect = false;
            fileData.Answers.Add(answer2);

            AnswerEntity answer3 = new AnswerEntity();
            answer3.QuestionId = question.Id;
            answer3.Text = "bool";
            answer3.IsCorrect = false;
            fileData.Answers.Add(answer3);
            fileData.SaveChanges();
        }
        //питання 2
        if (fileData.Questions.Any(q => q.TestId == 1 && q.Text == "Який оператор використовується для порівняння значень?") == false)
        {
            QuestionEntity question = new QuestionEntity();
            question.TestId = 1;
            question.Text = "Який оператор використовується для порівняння значень?";
            fileData.Questions.Add(question);
            fileData.SaveChanges();

            AnswerEntity answer1 = new AnswerEntity();
            answer1.QuestionId = question.Id;
            answer1.Text = "==";
            answer1.IsCorrect = true;
            fileData.Answers.Add(answer1);

            AnswerEntity answer2 = new AnswerEntity();
            answer2.QuestionId = question.Id;
            answer2.Text = "=";
            answer2.IsCorrect = false;
            fileData.Answers.Add(answer2);

            AnswerEntity answer3 = new AnswerEntity();
            answer3.QuestionId = question.Id;
            answer3.Text = "!=";
            answer3.IsCorrect = false;
            fileData.Answers.Add(answer3);
            fileData.SaveChanges();
        }
        //питання 3
        if (fileData.Questions.Any(q => q.TestId == 1 && q.Text == "Який цикл використовується для повторення блоку коду певну кількість разів?") == false)
        {
            QuestionEntity question = new QuestionEntity();
            question.TestId = 1;
            question.Text = "Який цикл використовується для повторення блоку коду певну кількість разів?";
            fileData.Questions.Add(question);
            fileData.SaveChanges();

            AnswerEntity answer1 = new AnswerEntity();
            answer1.QuestionId = question.Id;
            answer1.Text = "for";
            answer1.IsCorrect = true;
            fileData.Answers.Add(answer1);

            AnswerEntity answer2 = new AnswerEntity();
            answer2.QuestionId = question.Id;
            answer2.Text = "while";
            answer2.IsCorrect = false;
            fileData.Answers.Add(answer2);

            AnswerEntity answer3 = new AnswerEntity();
            answer3.QuestionId = question.Id;
            answer3.Text = "do-while";
            answer3.IsCorrect = false;
            fileData.Answers.Add(answer3);
            fileData.SaveChanges();
        }
        //питання 4
        if (fileData.Questions.Any(q => q.TestId == 1 && q.Text == "Який тип даних використовується для зберігання логічного значення?") == false)
        {
            QuestionEntity question = new QuestionEntity();
            question.TestId = 1;
            question.Text = "Який тип даних використовується для зберігання логічного значення?";
            fileData.Questions.Add(question);
            fileData.SaveChanges();

            AnswerEntity answer1 = new AnswerEntity();
            answer1.QuestionId = question.Id;
            answer1.Text = "bool";
            answer1.IsCorrect = true;
            fileData.Answers.Add(answer1);

            AnswerEntity answer2 = new AnswerEntity();
            answer2.QuestionId = question.Id;
            answer2.Text = "int";
            answer2.IsCorrect = false;
            fileData.Answers.Add(answer2);

            AnswerEntity answer3 = new AnswerEntity();
            answer3.QuestionId = question.Id;
            answer3.Text = "string";
            answer3.IsCorrect = false;
            fileData.Answers.Add(answer3);
            fileData.SaveChanges();
        }
        //питання 5
        if (fileData.Questions.Any(q => q.TestId == 1 && q.Text == "Який оператор використовується для логічного 'І'?") == false)
        {
            QuestionEntity question = new QuestionEntity();
            question.TestId = 1;
            question.Text = "Який оператор використовується для логічного 'І'?";
            fileData.Questions.Add(question);
            fileData.SaveChanges();

            AnswerEntity answer1 = new AnswerEntity();
            answer1.QuestionId = question.Id;
            answer1.Text = "&&";
            answer1.IsCorrect = true;
            fileData.Answers.Add(answer1);

            AnswerEntity answer2 = new AnswerEntity();
            answer2.QuestionId = question.Id;
            answer2.Text = "||";
            answer2.IsCorrect = false;
            fileData.Answers.Add(answer2);

            AnswerEntity answer3 = new AnswerEntity();
            answer3.QuestionId = question.Id;
            answer3.Text = "!";
            answer3.IsCorrect = false;
            fileData.Answers.Add(answer3);
            fileData.SaveChanges();
        }
        //питання 6
        if (fileData.Questions.Any(q => q.TestId == 1 && q.Text == "Який оператор використовується для логічного 'АБО'?") == false)
        {
            QuestionEntity question = new QuestionEntity();
            question.TestId = 1;
            question.Text = "Який оператор використовується для логічного 'АБО'?";
            fileData.Questions.Add(question);
            fileData.SaveChanges();

            AnswerEntity answer1 = new AnswerEntity();
            answer1.QuestionId = question.Id;
            answer1.Text = "||";
            answer1.IsCorrect = true;
            fileData.Answers.Add(answer1);

            AnswerEntity answer2 = new AnswerEntity();
            answer2.QuestionId = question.Id;
            answer2.Text = "&&";
            answer2.IsCorrect = false;
            fileData.Answers.Add(answer2);

            AnswerEntity answer3 = new AnswerEntity();
            answer3.QuestionId = question.Id;
            answer3.Text = "!";
            answer3.IsCorrect = false;
            fileData.Answers.Add(answer3);
            fileData.SaveChanges();
        }
        //питання 7
        if (fileData.Questions.Any(q => q.TestId == 1 && q.Text == "Який оператор використовується для логічного 'НЕ'?") == false)
        {
            QuestionEntity question = new QuestionEntity();
            question.TestId = 1;
            question.Text = "Який оператор використовується для логічного 'НЕ'?";
            fileData.Questions.Add(question);
            fileData.SaveChanges();

            AnswerEntity answer1 = new AnswerEntity();
            answer1.QuestionId = question.Id;
            answer1.Text = "!";
            answer1.IsCorrect = true;
            fileData.Answers.Add(answer1);

            AnswerEntity answer2 = new AnswerEntity();
            answer2.QuestionId = question.Id;
            answer2.Text = "&&";
            answer2.IsCorrect = false;
            fileData.Answers.Add(answer2);

            AnswerEntity answer3 = new AnswerEntity();
            answer3.QuestionId = question.Id;
            answer3.Text = "||";
            answer3.IsCorrect = false;
            fileData.Answers.Add(answer3);
            fileData.SaveChanges();
        }
        //питання 8
        if (fileData.Questions.Any(q => q.TestId == 1 && q.Text == "Який тип даних використовується для зберігання дробових чисел?") == false)
        {
            QuestionEntity question = new QuestionEntity();
            question.TestId = 1;
            question.Text = "Який тип даних використовується для зберігання дробових чисел?";
            fileData.Questions.Add(question);
            fileData.SaveChanges();

            AnswerEntity answer1 = new AnswerEntity();
            answer1.QuestionId = question.Id;
            answer1.Text = "float";
            answer1.IsCorrect = true;
            fileData.Answers.Add(answer1);

            AnswerEntity answer2 = new AnswerEntity();
            answer2.QuestionId = question.Id;
            answer2.Text = "int";
            answer2.IsCorrect = false;
            fileData.Answers.Add(answer2);

            AnswerEntity answer3 = new AnswerEntity();
            answer3.QuestionId = question.Id;
            answer3.Text = "string";
            answer3.IsCorrect = false;
            fileData.Answers.Add(answer3);
            fileData.SaveChanges();
        }
        //питання 9
        if (fileData.Questions.Any(q => q.TestId == 1 && q.Text == "Який оператор використовується для присвоєння значення змінній?") == false)
        {
            QuestionEntity question = new QuestionEntity();
            question.TestId = 1;
            question.Text = "Який оператор використовується для присвоєння значення змінній?";
            fileData.Questions.Add(question);
            fileData.SaveChanges();

            AnswerEntity answer1 = new AnswerEntity();
            answer1.QuestionId = question.Id;
            answer1.Text = "=";
            answer1.IsCorrect = true;
            fileData.Answers.Add(answer1);

            AnswerEntity answer2 = new AnswerEntity();
            answer2.QuestionId = question.Id;
            answer2.Text = "==";
            answer2.IsCorrect = false;
            fileData.Answers.Add(answer2);

            AnswerEntity answer3 = new AnswerEntity();
            answer3.QuestionId = question.Id;
            answer3.Text = "!=";
            answer3.IsCorrect = false;
            fileData.Answers.Add(answer3);
            fileData.SaveChanges();
        }
        //питання 10
        if (fileData.Questions.Any(q => q.TestId == 1 && q.Text == "Який тип даних використовується для зберігання тексту?") == false)
        {
            QuestionEntity question = new QuestionEntity();
            question.TestId = 1;
            question.Text = "Який тип даних використовується для зберігання тексту?";
            fileData.Questions.Add(question);
            fileData.SaveChanges();

            AnswerEntity answer1 = new AnswerEntity();
            answer1.QuestionId = question.Id;
            answer1.Text = "string";
            answer1.IsCorrect = true;
            fileData.Answers.Add(answer1);

            AnswerEntity answer2 = new AnswerEntity();
            answer2.QuestionId = question.Id;
            answer2.Text = "int";
            answer2.IsCorrect = false;
            fileData.Answers.Add(answer2);

            AnswerEntity answer3 = new AnswerEntity();
            answer3.QuestionId = question.Id;
            answer3.Text = "bool";
            answer3.IsCorrect = false;
            fileData.Answers.Add(answer3);
            fileData.SaveChanges();
        }
        

        int countQuestions = fileData.Questions.Count();
        MessageBox.Show($"Кількість питань в БД: {countQuestions}", "Інформація", MessageBoxButton.OK, MessageBoxImage.Information);


        MainWindow window = new MainWindow();
        window.Show();
    }
}
