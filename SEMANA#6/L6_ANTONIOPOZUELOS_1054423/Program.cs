class Laboratorio6
{
    static void Main(string[] args)
    {
        //EJERCICIO NO.1
        Console.WriteLine("EJERCICIO NO.1 \nOPERACIONES ARITMÉTICAS");

        double n1 = 0;
        double n2 = 0;

        //SOLICITAR EL INGRESO DE DOS NÚMEROS
        Console.WriteLine("\nFavor ingresar un número:");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nFavor ingresar otro número:");
        n2 = Convert.ToDouble(Console.ReadLine());

        //OPERAR LOS DOS NÚMEROS
        double sum = 0;
        double res = 0;
        double mul = 0;
        double divi = 0;
        double mod = 0;
        int div = 0;

        sum = n1 + n2;
        res = n1 - n2;
        mul = n1 * n2;
        divi = n1 / n2;
        mod = n1 % n2;
        div = (int)(n1 / n2);

        //MOSTRAR EL RESULTADO DE LAS OPERACIONES
        Console.WriteLine("\nRESULTADO SUMA: " + n1 + "+" + n2 + "=" + sum);
        Console.WriteLine("RESULTADO RESTA: " + n1 + "-" + n2 + "=" + res);
        Console.WriteLine("RESULTADO MULTIPLICACIÓN: " + n1 + "x" + n2 + "=" + mul);
        Console.WriteLine("RESULTADO DIVISIÓN: " + n1 + "÷" + n2 + "=" + divi);
        Console.WriteLine("RESULTADO MOD: " + n1 + "%" + n2 + "=" + mod);
        Console.WriteLine("RESULTADO DIV: " + n1 + "÷" + n2 + "=" + div);

        Console.ReadKey();

        //EJERCICIO NO.2
        Console.WriteLine("\nEJERCICIO NO.2 \nOPERACIONES BOOLEANAS");

        //MOSTRAR RESULTADOS DE LAS OPERACIONES BOOLEANAS
        if (n1 > n2)
        {
            Console.WriteLine();
            Console.WriteLine("RESULTADO: " + n1 + " es mayor que " + n2);
        }
        else if (n1 == n2)
        {
            Console.WriteLine();
            Console.WriteLine("RESULTADO: " + n1 + " es igual que " + n2);
        }
        else 
        {
            Console.WriteLine();
            Console.WriteLine("RESULTADO: " + n1 + " es menor que " + n2);
        }

        Console.ReadKey();
        Console.Clear();

        //EJERCICIO NO.3
        Console.WriteLine("EJERCICIO NO.3 \nJERARQUÍA DE OPERACIONES");

        double a = 0;
        double b = 0;
        double c = 0;

        //SOLICITAR EL INGRESO DE TRES NÚMEROS
        Console.WriteLine("\nFavor ingresar un número A:");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nFavor ingresar un número B:");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nFavor ingresar un número C:");
        c = Convert.ToDouble(Console.ReadLine());

        double op = 0;
        double op1 = 0;
        double op2 = 0;
        double op3 = 0;

        //OPERAR LOS TRES NÚMEROS
        op = a * b + c;
        op1 = a * (b + c);
        op2 = a / (b * c);
        op3 = (3 * a + 2 * b) / Math.Pow(c, 2);

        //MOSTRAR EL RESULTADO DE LAS OPERACIONES
        Console.WriteLine("\nEL RESULTADO DE 'A * B + C' ES IGUAL A: " + op);
        Console.WriteLine("EL RESULTADO DE 'A * (B + C)' ES IGUAL A: " + op1);
        Console.WriteLine("EL RESULTADO DE 'A / B * C' ES IGUAL A: " + op2);
        Console.WriteLine("EL RESULTADO DE '3A + 2B / C^2' ES IGUAL A: " + op3);

        Console.ReadKey();

        //EJERCICIO NO.4
        Console.WriteLine();
        Console.WriteLine("EJERCICIO NO.4 \nEXPRESIÓN CUADRÁTICA");

        double x1 = 0;
        double x2 = 0;
        double discriminante = 0;

        //OPERAR EL VALOR DENTRO DE LA RAÍZ
        discriminante = Math.Pow(b, 2) - (4 * a * c);

        if (a != 0 && discriminante >= 0)
        {
            x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);

            Console.WriteLine();
            Console.WriteLine("RESULTADO x1 ES IGUAL A: " + x1);
            Console.WriteLine("RESULTADO x2 ES IGUAL A: " + x2);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("ERROR: Los valores ingresados no permiten el cálculo de una expresión cuadrática.");
        }

        Console.ReadKey();
        Console.Clear();
    }
}
