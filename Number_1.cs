 namespace Lab_7;

public class Number_1
{
    public static void Main()
    {
        Grant[] students_1 = new Grant[3];
        students_1[0] = new Grant(1, new int[] { 4, 5, 5, 5, 5 });
        students_1[1] = new Grant(2, new int[] { 3, 4, 4, 3, 3 });
        students_1[2] = new Grant(3, new int[] { 3, 4, 4, 3, 5 });
        Grant[] students_2 = new Grant[3];
        students_2[0] = new Grant(4, new int[] { 2, 4, 3, 3, 4 });
        students_2[1] = new Grant(5, new int[] { 4, 4, 4, 4, 5 });
        students_2[2] = new Grant(6, new int[] { 5, 4, 4, 4, 5 });

        StudSort(students_1);
        StudSort(students_2);

        Grant[] array;
        // объединяем два массива
        array = (Grant[])students_1.Concat(students_2).ToArray();
        array = (Grant[])StudSort(array);

        Console.WriteLine("Фамилия Сред.балл Стипендия");
        for (int i = 0; i < array.Length; i++)
        {
            array[i].ShowGrant();
        }

        Console.ReadKey();
    }
    static Grant[] StudSort(Grant[] students)
    {
        for (int i = 0; i < students.Length; i++)
        {
            for (int j = i + 1; j < students.Length; j++)
            {
                if (students[i].averageMark < students[j].averageMark)
                {
                    (students[i], students[j]) = (students[j], students[i]);
                }
            }
        }
        return students;
    }
}
class Student
{
    public int Surname;
    public double averageMark;
    public int[] marks;
    public Student(int Surname, int[] marks)
    {
        this.Surname = Surname;
        this.marks = marks;
        for (int i = 0; i < marks.Length; i++)
        {
            averageMark += marks[i];
        }
        averageMark /= marks.Length;
    }
}

class Grant : Student
{
    public int money;
    public Grant(int Surname, int[] marks) : base(Surname, marks)
    {
        this.Surname = Surname;
        this.marks = marks;
        money = 0;
        for (int i = 0; i < marks.Length; i++)
        {
            if (marks[i] > 3) money = 1700;
            if (marks[i] <= 3) { money = 0; break; }
        }
    }
    public void ShowGrant()
    {
        Console.WriteLine($"{Surname}    {averageMark}       {money} руб");
    }
}
