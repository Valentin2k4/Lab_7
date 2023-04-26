namespace Lab_7;

public class Number_2
{
     public static void Main()
    {
        Category[] sportsmens = new Category[8];
        sportsmens[0] = new Category("Гоша", "м", 2.5);
        sportsmens[1] = new Category("Соня", "ж", 3.1);
        sportsmens[2] = new Category("Витя", "м", 2.6);
        sportsmens[3] = new Category("Вова", "м", 4.3);
        sportsmens[4] = new Category("Маша", "ж", 2.1);
        sportsmens[5] = new Category("Даня", "м", 5.4);
        sportsmens[6] = new Category("Саша", "ж", 2.9);
        sportsmens[7] = new Category("Геля", "ж", 3.2);

        sportsmens = Sort(sportsmens);

        Console.WriteLine("Фамилия Пол Результат Норматив");
        for (int i = 0; i < sportsmens.Length; i++)
        {
            sportsmens[i].Print();
        }

        Console.ReadKey();
    }

    static Category[] Sort(Category[] categories)
    {
        for (int i = 0; i < categories.Length; i++)
        {
            for (int j = i + 1; j < categories.Length; j++)
            {
                if (categories[i].Result > categories[j].Result)
                {
                    (categories[i], categories[j]) = (categories[j], categories[i]);
                }
            }
        }

        return categories;
    }
}

class Sport
    {
        public string Surname;
        public string Gender;
        public double Result;

        public Sport(string Surname, string Gender, double Result)
        {
            this.Surname = Surname;
            this.Gender = Gender;
            this.Result = Result;
        }
    }
    class Category : Sport
    {
        public string norm;
        public Category(string Surname, string Gender, double Result) : base(Surname, Gender, Result)
        {
            this.Surname = Surname;
            this.Result = Result;
            this.Gender = Gender;
            if (Gender == "ж")
            {
                if (Result < 3.2) norm = "Выполнен";
                else norm = "Не выполнен";
               
            }
            else
            {
                if (Result < 2.5) norm = "Выполнен";
                else norm = "Не выполнен";
            }
        }
        public void Print()
        {
            Console.WriteLine($"{Surname}     {Gender}   {Result}       {norm}");
        }
    }

