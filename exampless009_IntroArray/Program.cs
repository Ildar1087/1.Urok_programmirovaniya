
// все тоже самое, но опишем с помощью функций
Console.Clear();
int Max(int arg1, int arg2, int arg3)
{
  int result = arg1;
  if (arg2 > result) result = arg2;
  if (arg3 > result) result = arg3;
  return result; // и нам нужно чтобы result возвращал результат
}
//               0   1   2   3   4   5   6   7   8
int[] array = { 111, 21, 31, 34, 52, 46, 75, 35, 18 };

int max = Max(
Max(array[0], array[1], array[2]),
Max(array[3], array[4], array[5]),
Max(array[6], array[7], array[8]));
Console.WriteLine(max);


//int max1 = Max (a1, b1, c1); // результатом работы функции Мах будет а1,в1,с1
//int max2 = Max (a2, b2, c2); // результатом работы функции Мах будет а2,в2,с2
//int max3 = Max (a3, b3, c3); // результатом работы функции Мах будет а3,в3,с3
//int max = Max (max1, max2, max3);
//int max = Max(
//Max (a1, b1, c1), 
//Max (a2, b2, c2), 
//Max (a3, b3, c3));
//Console.WriteLine(max);