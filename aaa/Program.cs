
int[] a = new int[] { 8, 8, 3, 0, 8, 6 };
int p = 0;
for(int i =0; i < a.Length; i++)
{
    if (a[i]%2!=0)
    {
        p += a[i];
    }
}

Console.WriteLine(p + " " + ((-7)%2));
/*
!29 3 -15 15 2 32 4 18 4 4
3 10 -16 12 4 6 3 3 2  2

24 22 20 4 8 -6 -4 4 -12 18
*/