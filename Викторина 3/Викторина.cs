QuizElements[] quizItems =
    [new() { Question = "Столица РБ?", Answer = "Минск" },
    new() { Question = "Лучший город на свете это ...?", Answer = "Слоним" },
    new() { Question = "Сколько месяцев в году?", Answer = "12" },
    new() { Question = "Первый месяц лета?", Answer = "Июнь" }];

int counter = 0;
for (int i = 0; i < quizItems.Length; i++)
{
    QuizConclusion(quizItems[i], ref counter);
}

if (counter < 0)
    Console.WriteLine("Вы проиграли!!");
else
    Console.WriteLine("Вы выиграли!!!");

static void QuizConclusion(QuizElements q, ref int c)
{
    if (c < 0)
        return;

    Console.WriteLine(q.Question);
    if (Console.ReadLine() == q.Answer)
    {
        Console.WriteLine("Верно\n");
        c++;
    }
    else
    {
        Console.WriteLine("Неверно\n");
        c--;
    }
}

struct QuizElements
{
    public string Question;
    public string Answer;
}
