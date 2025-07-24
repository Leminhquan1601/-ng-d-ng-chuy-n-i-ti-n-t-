public class Program
{
    public static void Main(string[] args)
    {
        const int rate = 23000;
        Console.WriteLine("Nhap gia tien do");
        double USD = Convert.ToDouble(Console.ReadLine());
        double VND = USD * rate;
        Console.WriteLine(VND);
    }
}