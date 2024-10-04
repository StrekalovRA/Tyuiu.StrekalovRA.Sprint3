
double s0 = 0;
double s1 = 0;
int x = 2;
for (int j = 1; j <= 3; j++)
{
    for(int k = 1; k<=3; k++)
    {
        s0 = 2 * k-x;
        s1 += s0;
    }
}
Console.WriteLine(s1);
/*
90 54 45 54 108 90
36 9 36 18
*/