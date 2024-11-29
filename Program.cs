string Decision(string choice)
{
    bool correct = false;
    
    while (correct != true)
    {
        choice = Console.ReadLine();
        correct = CheckCorrcet(choice);
        if (correct == false)
        {
            Console.WriteLine("Молю тебя, введи ты нормальное число(");
            Console.Write("Введи значение снова - ");
        }
    }
    return choice;
}

bool CheckCorrcet(string input)
{
    bool isit = default;
    if (input == "1" || input == "2" || input == "3")
    {
        isit = true;
    }
    else
    {
        isit = false;
    }
    return isit;
}

bool CheckWin(string choiceFirst, string choiceSecond)
{
    if (choiceFirst == "1" && choiceSecond == "2") return true;
    if (choiceFirst == "2" && choiceSecond == "3") return true;
    if (choiceFirst == "3" && choiceSecond == "1") return true;
    return false;
}

string FirstChoice = default;
string SecondChoice = default;
bool Draw = false;
bool FirstFlag = false;
bool SecondFlag = false;

Console.WriteLine("Привет! Предлагаю тебе сыграть в камень, ножницы, бумагу.");
Console.WriteLine("Тебе нужно ввести число, озночающее твой выбор, где:");
Console.WriteLine("1 - Камень");
Console.WriteLine("2 - Ножницы");
Console.WriteLine("3 - Бумага");
Console.WriteLine();
Console.Write("Первый игрок, твой выбор.. - ");
FirstChoice = Decision(FirstChoice);
Console.Write("Второй игрок, твой выбор. - ");
SecondChoice = Decision(SecondChoice);

if(FirstChoice == SecondChoice) Draw = true;
FirstFlag = CheckWin(FirstChoice, SecondChoice);
SecondFlag = CheckWin(SecondChoice, FirstChoice);

if (Draw == true) Console.WriteLine("Поздравляю, у вас НИЧЬЯ ");
if (FirstFlag == true) Console.WriteLine("Поздравляю, ПЕРВЫЙ победил ");
if (SecondFlag == true) Console.WriteLine("Поздравляю, ВТОРОЙ победил ");