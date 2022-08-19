// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Enter the number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number B: ");
int b = Convert.ToInt32(Console.ReadLine());

int AtoBDegree(int ac, int bc)
{
    int result = 1;
    for (int i = 0; i < bc; i++)
    {
        result = result * ac;
    }
    return result;
}

int aToBDegree = AtoBDegree(a, b);

Console.WriteLine($"{a} to the power of {b} equals {aToBDegree}.");