Console.WriteLine("Данная программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.Write("Введите любое пятизначное число-палиндром: ");
string? number = Console.ReadLine();

void CheckingNumber(string num){
  if (number[0] == number[4] || number[1] == number[3]){
    Console.WriteLine($"Ведённое число: {number} - является палиндромом.");
  }
  else Console.WriteLine($"Ведённое число: {number} - не является палиндромом.");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Вы ввели не пятизначное число-палиндром!");