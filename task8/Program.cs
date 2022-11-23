Console.Clear();

Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());

int number = 1;
int temp = 0;

if (n > 0)

  while (number < n)
  {
      if (number % 2 == 0)  
       Console.WriteLine(number);
  number ++;
  }

if (n < 0)   
  
  while (number < -n)
      {
      if (number % 2 == 0) Console.WriteLine(temp = number * -1);
      number ++;
    }
