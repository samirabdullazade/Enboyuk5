Console.WriteLine(Methods.EnBoyukEded(1,15,77,787,9));

public static class Methods
{
    public static int EnBoyukEded(int eded1, int eded2, int eded3)
    {
        int max = 0;
        if (eded1 > eded2)
        {
            max = eded1;
        }
        else
        {
            max = eded2;
        }
        if (max < eded3)
        {
            return eded3;
        }
        return max;
    }
   public static int EnBoyukEded(int a, int b, int c, int d)
    {
        int max = EnBoyukEded(a, b, c);
        if (max > d)
        {
            return max;
        }
        return d;
    }
   public static int EnBoyukEded(int a, int b, int c, int d, int e)
    {
        int max = EnBoyukEded(a, b, c, d);
        if (e>max)
        {
            return e;
        }
        return max;
    }

}