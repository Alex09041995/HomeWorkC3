Console.WriteLine("Данная программа принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
Console.Write("Введите любое число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube){
  int counter = 1;
  int length = cube.Length;
  while (counter <  length){
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArray(int[] collection){
  int count = collection.Length;
  int index = 1;
  Console.Write($"Таблица кубов введённого числа следующая: ");
  while(index < count){
    Console.Write(collection[index]+ ", ");
    index++;
  }
} 

int[] array = new int[cube+1];
Cube(array);
PrintArray(array);