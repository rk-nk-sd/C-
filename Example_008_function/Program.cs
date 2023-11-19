int Max(int arg1, int arg2, int arg3) {
    int result = arg1;
    if(result < arg2) result = arg2;
    if(result < arg3) result = arg3;
    return result;
}

int a1 = 12;
int a2 = 62;
int a3 = 34;

int b1 = 25;
int b2 = 74;
int b3 = 52;

int c1 = 63;
int c2 = 93;
int c3 = 37;

int max = Max(
    Max(a1, a2, a3),
    Max(b1, b2, b3),
    Max(c1, c2, c3)
);
Console.WriteLine(max);
