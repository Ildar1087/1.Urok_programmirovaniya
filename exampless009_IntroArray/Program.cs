
// все тоже самое, но опишем с помощью функций
Console.Clear();
int Max (int arg1, int arg2, int arg3)
{
  int result = arg1;
  if (arg2 > result) result = arg2;
  if (arg3 > result) result = arg3;
  return result; // и нам нужно чтобы result возвращал результат
}

int a1 = 23;
int b1 = 32;
int c1 = 14;
int a2 = 33;
int b2 = 05;
int c2 = 09;
int a3 = 99;
int b3 = 41;
int c3 = 73;

//int max1 = Max (a1, b1, c1); // результатом работы функции Мах будет а1,в1,с1
//int max2 = Max (a2, b2, c2); // результатом работы функции Мах будет а2,в2,с2
//int max3 = Max (a3, b3, c3); // результатом работы функции Мах будет а3,в3,с3
//int max = Max (max1, max2, max3);
int max = Max(
  Max (a1, b1, c1), 
  Max (a2, b2, c2), 
  Max (a3, b3, c3));
Console.WriteLine(max);