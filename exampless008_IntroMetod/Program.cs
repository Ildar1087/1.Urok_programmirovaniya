Console.Clear();
int a1 = 23;
int b1 = 32;
int c1 = 714;
int a2 = 33;
int b2 = 05;
int c2 = 39;
int a3 = 99;
int b3 = 41;
int c3 = 73;

int max = a1;

if (b1 > max) max = a1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;


Console.Write("max = ");
Console.WriteLine(max);

