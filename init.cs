namespace app;

public class init
{
    static void Main()
    {
        bool r1 = true, r2 = true;
        Console.WriteLine(r1 ^ r2); //Xor
        bool isVar = true;
        var x = 10;
        var y = 20;
        var sum = x + y;
        Console.WriteLine(sum);
        var name ="moawed";
        Console.WriteLine($"Hello, {name}");
        var input = 20;
        var total = 200;
        var discount = input > total ? 0.5 : 0.2;
        Console.WriteLine($"Discount: {discount * 100}%");
    }
}