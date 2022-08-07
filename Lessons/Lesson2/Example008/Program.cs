int a1 = 23,
    b1 = 24,
    c1 = 53,
    a2 = 34,
    b2 = 56,
    c2 = 31,
    a3 = 11,
    b3 = 54,
    c3 = 65;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;
if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;
if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);
