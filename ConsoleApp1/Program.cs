#region Task 1

int numberOne = Convert.ToInt32 (Console.ReadLine());
int numberTwo = Convert.ToInt32(Console.ReadLine());
char method = Convert.ToChar(Console.ReadLine());

int result = Calculate(numberOne, numberTwo, method);

Console.WriteLine(result);


static int Calculate(int numberOne, int numberTwo, char method)
{
    int result = method switch
    {
        '+' => numberOne + numberTwo,
        '-' => numberOne - numberTwo,
        '*' => numberOne * numberTwo,
        '/' => numberOne / numberTwo,
    };
    return result;
}

#endregion

#region Task 2

string sentence = "Lorem ipsum dolor sit amet";
char wantedChar = 'c';

static int CountChar(string sentence, char wantedChar)
{
    int count= 0;
    foreach (char item in sentence)
    {
        if (wantedChar == item)
        {
            count++;
        }
    }
    return count;
}

#endregion

#region Task 3

Console.WriteLine(sentence.Split(' ').Length);

#endregion

#region Task 4

int num = 456;
string stringNum = num.ToString();
int sum = 0;
for (int i = 0; i < stringNum.Length; i++)
{
    sum += Convert.ToInt32(stringNum[i]);
}

Console.WriteLine(sum);

#endregion

#region Task 5

int number = 5;
int power = 3;
int multi = 1;
for (int i = 0; i < power; i++)
{
    multi *= number;
}

Console.WriteLine(multi);

#endregion

#region Task 6

int[] numbers = { 4, 8, -5, 1, -5, 1 };
MakePositive(numbers);
foreach (int item in numbers)
{
    Console.WriteLine(item);
}

static void MakePositive(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = numbers[i] < 0 ? -numbers[i] : numbers[i];
    }
}

#endregion

#region Task 7

Console.WriteLine(string.Join("", "salam".ToCharArray().Reverse()));

#endregion