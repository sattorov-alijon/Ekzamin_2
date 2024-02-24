namespace Tasc7;

public class Math
{

public double Abs(double value)
{
    if (value>=0)
    {
        
    return value;
    }
    else return (-1)*value;
}

public float Abs(float value)
{
    if (value>=0)
    {
        
    return value;
    }
    else return (-1)*value;
}

public int Abs(int value)
{
    if (value>=0)
    {
        
    return value;
    }
    else return (-1)*value;
}


public double Pow(double x,double y)
{
    double pow=1;
    for (int i = 1; i <= y; i++)
    {
        pow=pow*x;
    }
    return pow;
}

public double Sqrt(int d)
{
        int a=0;
    for (int i = 1; i <= d; i++)
    {
        if(i*i==d)
   a=i;
    }
    return a;
}

public int Max(int val1,int val2)
{
int max=0;
max=val1+val2+Abs(val1-val2);
return max/2;
}

public int Min(int val1,int val2)
{
int min=0;
min=val1+val2-Abs(val1-val2);
return min/2;
}

public const double PI=3.14;
public const double E=2.71;





}
