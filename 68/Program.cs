Console.Write("Введите n = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите m = ");
int m = Convert.ToInt32(Console.ReadLine());
int Akkerman(int m, int n)
    {
        if (m == 0)
        {
            return n+1;
        }
        else if (n == 0 && m > 0)
        {
            return Akkerman(m-1, 1);
        }
        else
        {
            return Akkerman(m-1, Akkerman(m, n-1));
        }
    }
    int Ack(int m, int n)
    {
        if (m == 0)
        {
            return n+1;
        }
        else if (n == 0)
        {
            return Ack(m-1, 1);
        }
        else
        {
            return Ack(m-1, Ack(m, n-1));
        }
    }
Console.Write(Akkerman(m,n));
Console.WriteLine(); 


 
