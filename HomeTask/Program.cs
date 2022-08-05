// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите 5 тизначное число: ");
int num = int.Parse(Console.ReadLine());
if (num > 99999)
{
    Console.WriteLine("ERROR");
    return;
}

string numInString = num.ToString();
char firstDigit = numInString[0];
char secondDigit = numInString[1];
char thirdDigit = numInString[2];
char fourthDigit = numInString[3];
char fifthDigit = numInString[4];
if(numInString[0] == numInString[3] || numInString[1] == numInString[3])
{
    Console.WriteLine(numInString + "да");
}
else
{
    Console.WriteLine(numInString + "нет");
}

