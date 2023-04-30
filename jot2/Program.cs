/*//SAMPLE 1
// Question 1 PrimeCount
class Prime
{
    static int PrimeCount(int start, int end)
    {
        int count = 0;
        for (int i = start; i <= end; i++)
        {
            bool isPrime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime && i > 1)
            {
                count++;
            }
        }
        return count;
    }
    static void Main()
    {
        int start, end;
        Console.WriteLine("Enter start:");
        start = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter end:");
        end = int.Parse(Console.ReadLine());
        int count = PrimeCount(start, end);
        if (count == 0)
        {
            Console.WriteLine("No prime numbers between {0} and {1}", start, end);
        }
        else
        {
            Console.WriteLine("There are {0} prime numbers between {1} and {2}", count, start, end);
        }
    }
}
// Question 1 Madhav array
class Madhav
{
    public static int isMadhavArray(int[] a)
    {
        bool madhav = true;
        for (int i = 0; i < a.Length; i++)
        {
            int expected = (a[i] * (a[i] + 1)) / 2;
            if (a[i] != expected)
            {
                madhav = false;
            }
            else
            {
                int sum = a[0];
                if (i == 0)
                {
                    sum = a[i];
                    i++;
                }
                else
                {
                    int groupsum = 0;
                    for (int j = i; j <= i + i && j < a.Length; j++)
                    {
                        groupsum += a[j];
                    }
                    if (groupsum != sum)
                    {
                        madhav = false;
                    }
                    sum = groupsum;
                    i += i + 1;
                }
                madhav = true;
            }
        }
        if (madhav == true)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("What is the size of the array?");
        int size = int.Parse(Console.ReadLine());
        int[] a = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Enter numbers:");
            a[i] = int.Parse(Console.ReadLine());
        }
        int answer = isMadhavArray(a);
        if (answer == 0)
        {
            Console.WriteLine("Not a madhav array");
        }
        else
        {
            Console.WriteLine("it is a madhav array");
        }
    }
}
// Question 1 Inertial
class In
{
    int isInertial(int[] a)
    {
        bool first = false;
        bool sec = false;
        int count = 0;
        int maxvalue = a[0];
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] % 2 != 0)
            {
                count++;
                if (count >= 1)
                {
                    first = true;
                }
            }
            if ((a[i] > maxvalue))
            {
                if (a[i] % 2 == 0)
                {
                    if (maxvalue % 2 == 0)
                    {
                        sec = true;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    a[i] = maxvalue;
                    sec = false;
                }
            }
        }
        if (first && sec)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("what is the array size:");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("Numbers:");
        int[] a = new int[size];
        for (int i = 0; i < size; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        In _in = new In();
        int ans = _in.isInertial(a);
        if (ans == 1)
        {
            Console.WriteLine("It is inertial");
        }
        else
        {
            Console.WriteLine("not inertial");
        }
    }
}
// Question 2 CountingSquarePairs
class Pairs
{
    int CountSquarePairs(int[] a)
    {
        int count = 0;
        double perfectsum;
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                if ((a[i] > 0) && (a[j] > 0))
                {
                    perfectsum = a[i] + a[j];
                    if ((int)Math.Sqrt(perfectsum) == Math.Sqrt(perfectsum))
                    {
                        count++;
                    }
                }
            }
        }
        return count;
    }
    static void Main()
    {
        Console.WriteLine("Size of array");
        int size = int.Parse(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine("Enter array of numbers");
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        Pairs pair = new Pairs();
        int result = pair.CountSquarePairs(a);
        if (result == 0)
        {
            Console.WriteLine("No square pair");
        }
        else
        {
            Console.WriteLine("There are {0} square pairs", result);
        }
    }
}
// Question 2 FindPorcupineNumber
class porcupine
{
    int FindPorcupineNumber(int n)
    {
        int primenumber = 0;
        bool porc = false;
        bool next_isprime = false;
        for (int i = n + 1; !porc; i++)
        {
            bool isprime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isprime = false;
                    break;
                }
            }
            if (isprime && i % 10 == 9)
            {
                primenumber = i;
                next_isprime = false;
                for (int j = primenumber + 1; !next_isprime; j++)
                {
                    next_isprime = true;
                    for (int k = 2; k <= Math.Sqrt(j); k++)
                    {
                        if (j % k == 0)
                        {
                            next_isprime = false;
                            break;
                        }
                    }
                    if (next_isprime && j % 10 == 9)
                    {
                        porc = true;
                    }
                }
            }
        }
        return primenumber;
    }
    static void Main()
    {
        Console.WriteLine("Number:");
        int num = int.Parse(Console.ReadLine());
        porcupine Porcupine = new porcupine();
        Console.WriteLine(Porcupine.FindPorcupineNumber(num));
    }
}
// Question 2 Guthrie Sequence
class Guth
{
    int isGuthrieSequence(int[] a)
    {
        bool first = false;
        if (a[a.Length - 1] != 1)
        {
            return 0;
        }
        for (int i = 0; i < a.Length - 1; i++)
        {
            if (a[i] % 2 == 0)
            {
                if (a[i + 1] == a[i] / 2)
                {
                    first = true;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (a[i + 1] == ((a[i] * 3) + 1))
                {
                    first = true;
                }
                else
                {
                    return 0;
                }
            }
        }
        if (first)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("Array Size");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("Numbers:");
        int[] num = new int[size];
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
        }
        Guth guth = new Guth();
        int ans = guth.isGuthrieSequence(num);
        if (ans == 1)
        {
            Console.WriteLine("This is the guthrie sequence for {0}", num[0]);
        }
        else
        {
            Console.WriteLine("This is not a guthrie sequence");
        }
    }
}
// Question 3 Stanton Measure
class Stanton
{
    int StantonMeasure(int[] a)
    {
        bool one = false;
        bool two = false;
        int count = 0;
        int count2 = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == 1)
            {
                count++;
                one = true;
            }
            if (!a.Contains(1))
            {
                count = 0;
                one = true;
            }
        }
        for (int i = 0; i < a.Length; i++)
        {
            if (one && (a[i] == count))
            {
                count2++;
                two = true;
            }
        }
        if (two)
        {
            return count2;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("Size of array");
        int size = int.Parse(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine("Enter array of numbers");
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        Stanton stanton = new Stanton();
        int result = stanton.StantonMeasure(a);
        if (result >= 0)
        {
            Console.WriteLine("Stanton measure of this array is {0}", result);
        }
    }
}
// Question 3 Sum Factor
class Factor
{
    int SumFactor(int[] a)
    {
        int count = 0;
        bool sum = false;
        int Arraysum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            Arraysum = Arraysum + a[i];
        }
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == Arraysum)
            {
                count++;
                sum = true;
            }
        }
        if (sum)
        {
            return count;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("Size of array");
        int size = int.Parse(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine("Enter array of numbers");
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        Factor factor = new Factor();
        int result = factor.SumFactor(a);
        if (result > 0)
        {
            Console.WriteLine("Sum Factor of this array is {0}", result);
        }
        else
        {
            Console.WriteLine("Sum Factor of this array is {0}", result);
        }
    }
}
// Question 3 Guthrie Index
class Index
{
    int guthrieIndex(int a)
    {
        int next;
        int count = 0;
        if (a <= 0)
        {
            return 0;
        }
        else
        {
            while (a != 1)
            {
                if (a % 2 == 0)
                {
                    next = a / 2;
                    a = next;
                }
                else if (a % 2 != 0)
                {
                    next = (a * 3) + 1;
                    a = next;
                }
                count++;
            }
        }
        return count;
    }
    static void Main()
    {
        Console.WriteLine("Number:");
        int num = int.Parse(Console.ReadLine());
        Index factor = new Index();
        int result = factor.guthrieIndex(num);
        if (result != 0)
        {
            Console.WriteLine("Guthrie index of {0} is {1} ", num, result);
        }
        else
        {
            Console.WriteLine("positive integers only");
        }
    }
}
// Question 4 Solve10
class fact
{
    public static int[] Solve10()
    {
        int fact10 = 3628800;
        int[] result = new int[2];
        for (int x = 0; x <= 10; x++)
        {
            int xfact = 1;
            for (int i = 1; i <= x; i++)
            {
                xfact = xfact * i;
            }
            for (int y = 0; y <= 10; y++)
            {
                int yfact = 1;
                for (int j = 1; j <= y; j++)
                {
                    yfact = yfact * j;
                }
                if (xfact + yfact == fact10)
                {
                    result[0] = x;
                    result[1] = y;
                    return result;
                }
            }
        }
        return null;
    }
    public static void Main()
    {
        int[] result = Solve10();
        if (result != null)
        {
            Console.WriteLine("x = {0}, y = {1}", result[0], result[1]);
            Console.WriteLine("{0}! + {1}! = 10!", result[0], result[1]);
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }
}
// Question 4 repsequal
public class array
{
    int repsEqual(int[] a, int n)
    {
        int num = 0;
        for (int i = 0; i < a.Length; i++)
        {
            num = num * 10 + a[i];
        }
        if (num == n)
        {
            return 1;
        }
        return 0;
    }
    public static void Main()
    {
        Console.WriteLine("Size of array");
        int size = int.Parse(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine("Array");
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("number");
        int num = int.Parse(Console.ReadLine());
        array arr = new array();
        int answer = arr.repsEqual(a, num);
        if (answer > 0)
        {
            Console.WriteLine("They are equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}
//Question 4: iscentred15
//Question 5:  Perfect numbers




//Question 5: Divisible
class div
{
    int isdivisible(int[] a, int divisor)
    {
        bool divisible = false;
        int count = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] % divisor == 0)
            {
                count++;
                if (count == a.Length)
                {
                    divisible = true;
                }
            }
        }
        if (divisible)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("Size of array:");
        int size = int.Parse(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine("Array");
        for (int i = 0; i < size; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Divisor:");
        int divs = int.Parse(Console.ReadLine());
        div Div = new div();
        int result = Div.isdivisible(a, divs);
        if (result != 0)
        {
            Console.WriteLine("Divisible :)");
        }
        else
        {
            Console.WriteLine("Not Divisible :(");
        }
    }
}
//Question 5: unique
class unique
{
    int Nunique(int[] a, int n)
    {
        bool uniq = false;
        int count = 0;
        int sum;
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                sum = a[i] + a[j];
                if (sum == n)
                {
                    count++;
                }
                else
                {
                    return 0;
                }
            }
        }
        if (count == 1)
        {
            uniq = true;
        }
        if (uniq)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("Size of array:");
        int size = int.Parse(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine("Array");
        for (int i = 0; i < size; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("N:");
        int N = int.Parse(Console.ReadLine());
        unique num = new unique();
        int result = num.Nunique(a, N);
        if (result == 1)
        {
            Console.WriteLine("It is {0}unique", N);
        }
        else
        {
            Console.WriteLine("It is not {0}unique", N);
        }
    }
}
//SAMPLE 2
//Question 1: Square
class sq
{
    int issquare(int x)
    {
        bool square = false;
        double div;
        for (int i = 1; i < x; i++)
        {
            div = x / i;
            if (((int)div == div) && (div == i))
            {
                square = true;
            }
        }
        if (square)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("Integer >>");
        int n = int.Parse(Console.ReadLine());
        sq SQ = new sq();
        int result = SQ.issquare(n);
        if (result == 1)
        {
            Console.WriteLine("It is the square of a  number");
        }
        else
        {
            Console.WriteLine("It is not the square of a  number");
        }
    }
}
//Question 1: Base number
class Legal
{
    int isLegalNumber(int[] x, int Base)
    {
        int count = 0;
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] < Base)
            {
                count++;
            }
        }
        if (count == x.Length)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("Size of array:");
        int size = int.Parse(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine("Array of digits:");
        for (int i = 0; i < size; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Base Number:");
        int N = int.Parse(Console.ReadLine());
        Legal legal = new Legal();
        int result = legal.isLegalNumber(a, N);
        if (result == 1)
        {
            Console.WriteLine("It is a legal base {0} number ", N);
        }
        else
        {
            Console.WriteLine("It is not a legal base {0} number ", N);
        }
    }
}
//Question 1: Convertto base10
class convertto10
{
    int isLegalNumber(int[] x, int Base)
    {
        int count = 0;
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] < Base)
            {
                count++;
            }
        }
        if (count == x.Length)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    double iConvertToBase10(int[] x, int Base)
    {
        double convert = 0;
        convertto10 leg = new convertto10();
        int result = leg.isLegalNumber(x, Base);
        if (result == 1)
        {
            for (int i = 0; i < x.Length; i++)
            {
                convert = convert + (x[i] * Math.Pow(Base, x.Length - i - 1));
            }
        }
        return convert;
    }
    static void Main()
    {
        Console.WriteLine("Size of array:");
        int size = int.Parse(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine("Array of digits:");
        for (int i = 0; i < size; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Base Number:");
        int N = int.Parse(Console.ReadLine());
        convertto10 ten = new convertto10();
        double result = ten.iConvertToBase10(a, N);
        if (result >= 0)
        {
            Console.WriteLine("The base 10 equivalent is {0} ", result);
        }
        else
        {
            Console.WriteLine("It is not a legal base {0} number ", N);
        }
    }
}
//Question 2: Pattern Matching
class pattern
{
    int matches(int[] A, int[] P)
    {
        bool condition1 = false;
        bool condition2 = false;
        int sum = 0;
        for (int j = 0; j < P.Length; j++)
        {
            sum = sum + Math.Abs(P[j]);
        }
        if (sum == A.Length)
        {
            condition1 = true;
        }
        for (int j = 0; j < P.Length; j++)
        {
            for (int i = 0; i < P[j]; i++)
            {
                if (((P[j] > 0) && (A[i] > 0)) || ((P[j] < 0) && (A[i] < 0)))
                {
                    condition2 = true;
                }
            }
        }
        if (condition1 && condition2)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("Size of array P:");
        int size = int.Parse(Console.ReadLine());
        int[] P = new int[size];
        Console.WriteLine("Array of digits:");
        for (int i = 0; i < size; i++)
        {
            P[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Size of array A:");
        int size2 = int.Parse(Console.ReadLine());
        int[] a = new int[size2];
        Console.WriteLine("Array of digits:");
        for (int i = 0; i < size2; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        pattern pat = new pattern();
        int result = pat.matches(a, P);
        if (result == 1)
        {
            Console.WriteLine("Array P matches Array A");
        }
        else
        {
            Console.WriteLine("Array P doesn't match Array A");
        }
    }
}
//Question 2: stacked or unstacked
class stack
{
    int IsStacked(int n)
    {
        bool stacked = false;
        int sum = 0;
        if (n == 1)
        {
            return 1;
        }
        for (int i = 0; i < n; i++)
        {
            sum = sum + i;
            if (sum == n)
            {
                stacked = true;
                break;
            }
        }
        if (stacked)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("Number>>");
        int n = int.Parse(Console.ReadLine());
        stack A = new stack();
        int result = A.IsStacked(n);
        if (result == 1)
        {
            Console.WriteLine("Stacked");
        }
        else
        {
            Console.WriteLine("Not Stacked");
        }
    }
}
//Question 2: Sum Safe
class safe
{
    int IsSumSafe(int[] n)
    {
        bool issafe = false;
        int sum = 0;
        for (int i = 0; i < n.Length; i++)
        {
            sum += n[i];
        }
        for (int i = 0; i < n.Length; i++)
        {
            if (!n.Contains(sum))
            {
                issafe = true;
            }
        }
        if (issafe)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("Size of array:");
        int size = int.Parse(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine("Array of digits:");
        for (int i = 0; i < size; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        safe Safe = new safe();
        int result = Safe.IsSumSafe(a);
        if (result == 1)
        {
            Console.WriteLine("This array is sum safe");
        }
        else
        {
            Console.WriteLine("This array is not sum safe");
        }
    }
}
//Question 3: Isolated
class Isolate
{
    static int isIsolated(long n)
    {
        bool isolated = true;
        double square = Math.Pow(n, 2);
        double cube = Math.Pow(n, 3);
        int[] squareArray = square.ToString().ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();
        int[] cubeArray = cube.ToString().ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();
        for (int i = 0; i < squareArray.Length; i++)
        {
            for (int j = 0; j < cubeArray.Length; j++)
            {
                if (squareArray[i] == cubeArray[j])
                {
                    isolated = false;
                    break;
                }
            }
        }
        if (isolated)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("Number:");
        int num = int.Parse(Console.ReadLine());
        int result = isIsolated(num);
        if (result == 1)
        {
            Console.WriteLine("Isolated");
        }
        else
        {
            Console.WriteLine(" Not Isolated");
        }
    }
}
//Question 3:Vanilla
class vanilla
{
    static int isVanilla(int[] n)
    {
        bool same = true;
        string New = string.Join("", n);
        for (int i = 0; i < New.Length; i++)
        {
            for (int j = i + 1; j < New.Length; j++)
            {
                if (New[i] != New[j])
                {
                    same = false;
                    break;
                }
            }
        }
        if (same)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("Size of array:");
        int size = int.Parse(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine("Array of digits:");
        for (int i = 0; i < size; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        int result = isVanilla(a);
        if (result == 1)
        {
            Console.WriteLine("Vanilla");
        }
        else
        {
            Console.WriteLine("Not Vanilla");
        }
    }
}
//Question 3:Trivalent
class Tri
{
    static int isTrivalent(int[] n)
    {
        int count = 0;
        for (int i = 0; i < n.Length; i++)
        {
            for (int j = i + 1; j < n.Length; j++)
            {
                if (n[j] != n[i])
                {
                    count++;
                }
            }
        }
        if (count == 3)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("Size of array:");
        int size = int.Parse(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine("Array of digits:");
        for (int i = 0; i < size; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        int result = isTrivalent(a);
        if (result == 1)
        {
            Console.WriteLine("Trivalent");
        }
        else
        {
            Console.WriteLine("Not Trivalent");
        }
    }
}
//Question 4:Representations
class reps
{
    static int countrepresentation(int numrupees)
    {
        int count = 0;
        for (int rupee20 = 0; rupee20 <= numrupees / 20; rupee20++)
        {
            for (int rupee10 = 0; rupee10 <= (numrupees - rupee20 * 20) / 10; rupee10++)
            {
                for (int rupee5 = 0; rupee5 <= (numrupees - rupee20 * 20 - rupee10 * 10) / 5; rupee5++)
                {
                    for (int rupee2 = 0; rupee2 <= (numrupees - rupee20 * 20 - rupee10 * 10 - rupee5 * 5) / 2; rupee2++)
                    {
                        for (int rupee1 = 0; rupee1 <= (numrupees - rupee20 * 20 - rupee10 * 10 - rupee5 * 5 - rupee2 * 2); rupee1++)
                        {
                            if (rupee20 * 20 + rupee10 * 10 + rupee5 * 5 + rupee2 * 2 + rupee1 == numrupees)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
        }
        return count;
    }
    static void Main()
    {
        Console.WriteLine("number:");
        int n = int.Parse(Console.ReadLine());
        int result = countrepresentation(n);
        Console.WriteLine(result + "ways");
    }
}
//Qustion 4:sequentially bounded
class seq
{
    static int issequentiallybounded(int[] n)
    {
        int count = 0;
        bool condition1 = true;
        for (int i = 0; i < n.Length - 1; i++)
        {
            if (n[i] > n[i + 1])
            {
                condition1 = false;
                break;
            }
        }
        if (condition1)
        {
            for (int i = 0; i < n.Length; i++)
            {
                int freq = 0;
                for (int j = 0; j < n.Length; j++)
                {
                    if (n[j] == n[i])
                    {
                        freq++;
                        if (freq > n[i])
                        {
                            return 0;
                        }
                    }
                }
            }
            return 1;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("Size of array:");
        int size = int.Parse(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine("Array of digits:");
        for (int i = 0; i < size; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        int result = issequentiallybounded(a);
        if (result == 1)
        {
            Console.WriteLine("The array is sequentially bound.");
        }
        else
        {
            Console.WriteLine("The array is not sequentially bound.");
        }
    }
}
//Question 4:minmax
class minmax
{
    static int isminmaxdisjoint(int[] n)
    {
        bool condition1 = true;
        bool condition2 = true;
        int min = n[0];
        int max = n[1];
        int countmax = 0;
        int countmin = 0;
        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] < min)
            {
                min = n[i];
            }
            if (n[i] > max)
            {
                max = n[i];
            }
        }
        if (max == min)
        {
            condition1 = false;
        }
        for (int i = 0; i < n.Length - 1; i++)
        {
            if (((max == n[i]) && (min == n[i + 1])) || ((min == n[i]) && (max == n[i + 1])))
            {
                condition2 = false;
                break;
            }
        }
        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] == max)
            {
                countmax++;
            }
            if (n[i] == min)
            {
                countmin++;
            }
        }
        if (condition1 && condition2 && countmax == 1 && countmin == 1)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("Size of array:");
        int size = int.Parse(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine("Array of digits:");
        for (int i = 0; i < size; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        int result = isminmaxdisjoint(a);
        if (result == 1)
        {
            Console.WriteLine("The array is minmaxdisjoint.");
        }
        else
        {
            Console.WriteLine("The array is not minmaxdisjoint.");
        }
    }
}
//Question 5: smallest
class small
{
    public static int Smallest(int n)
    {
        int i = 1;
        while (true)
        {
            bool hasDigit2 = true;
            int multiple = i;
            for (int j = 1; j <= n; j++)
            {
                while (multiple > 0)
                {
                    int digit = multiple % 10;
                    if (digit == 2)
                    {
                        break;
                    }
                    multiple /= 10;
                }
                if (multiple == 0)
                {
                    hasDigit2 = false;
                    break;
                }
                multiple = i * (j + 1);
            }
            if (hasDigit2)
            {
                return i;
            }
            i++;
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter the number of multiples:");
        int n = int.Parse(Console.ReadLine());
        int result = Smallest(n);
        Console.WriteLine("The smallest number with first {0} multiples containing digit 2 is {1}", n, result);
    }
}
//Question 5:Cluster Compression
//Question 5:rail road tie
class road
{
    static int isRailroadTie(int[] a)
    {
        int count = 0;
        int count2 = 0;
        int count3 = 0;
        bool railroad1 = false;
        bool railroad2 = false;
        for (int i = 0; i < a.Length; i++)
        {
            if ((a[i] > 0) || (a[i] < 0))
            {
                count++;
            }
            if (count > 0)
            {
                if (((a[i] > 0) || (a[i] < 0)))
                {
                    for (int j = i; j < a.Length; j++)
                    {
                        if (a[j] > 0)
                        {
                            count2++;
                            if (count2 == 1)
                            {
                                railroad1 = true;
                            }
                        }
                    }
                }
                if (a[i] == 0)
                {
                    for (int j = i; j < a.Length; j++)
                    {
                        if (a[j] > 0)
                        {
                            count3++;
                            if (count3 == 2)
                            {
                                railroad2 = true;
                            }
                        }
                    }
                }
            }
        }
        if (railroad1 && railroad2)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("Size of array:");
        int size = int.Parse(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine("Array of digits:");
        for (int i = 0; i < size; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        int result = isRailroadTie(a);
        if (result == 1)
        {
            Console.WriteLine("It is a railroad tie");
        }
        else
        {
            Console.WriteLine("not a railroad tie");
        }
    }
}
//Question 6: fullness
//Question 6: packed
class packed
{
    static int ispacked(int[] a)
    {
        int count = 0;
        bool pack = false;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] < 0)
            {
                return -1;
            }
            for (int j = 0; j < a.Length; j++)
            {
                if (a[i] == a[j])
                {
                    count++;
                    if (count == a[i])
                    {
                        for (int k = i; k < count; k++)
                        {
                            if (a[k] == a[i])
                            {
                                pack = true;
                            }
                        }
                    }
                }
            }
        }
        if (pack)
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }
    static void Main()
    {
        Console.WriteLine("Size of array:");
        int size = int.Parse(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine("Array of digits:");
        for (int i = 0; i < size; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        int result = ispacked(a);
        if (result == 1)
        {
            Console.WriteLine("Packed");
        }
        else
        {
            Console.WriteLine("Not Packed");
        }
    }
}
//Question 6: odd heavy



//Question 7:121

//Question 7:filterarray
//Question 8:Largest adjacent sum
class adj
{
    static int LargestAdjacentSum(int[] a)
    {
        if (a.Length == 1)
        {
            return a[0];
        }
        int max = a[0] + a[1];
        for (int i = 0; i < a.Length - 1; i++)
        {
            if ((a[i] + a[i + 1]) > max)
            {
                max = a[i] + a[i + 1];
            }
        }
        return max;
    }
    static void Main()
    {
        Console.WriteLine("Size of array:");
        int size = int.Parse(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine("Array of digits:");
        for (int i = 0; i < size; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        int result = LargestAdjacentSum(a);
        if (result > 0)
        {
            Console.WriteLine("{0} is the largest sum", result);
        }
    }
}
//Question 8:concat
//Question 8:m-n
class a
{
    static int isSequencedArray(int[] a, int m, int n)
    {
        bool b = true;
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = m; j <= n; j++)
            {
                if (!a.Contains(j))
                {
                    b = false;
                    break;
                }
            }
        }
        if (b)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("Size of array:");
        int size = int.Parse(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine("Array of digits:");
        for (int i = 0; i < size; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("M:");
        int M = int.Parse(Console.ReadLine());
        Console.WriteLine("N:");
        int N = int.Parse(Console.ReadLine());
        int result = isSequencedArray(a, M, N);
        if (result == 1)
        {
            Console.WriteLine("The array is a {0}-{1} sequence array", M, N);
        }
        else
        {
            Console.WriteLine("The array is not a {0}-{1} sequence array", M, N);
        }
    }
}
//Question 9:largest prime
//Question 10: Cube Powerful
class cube
{
    static int CubePowerful(int n)
    {
        double cubesum = 0;
        int[] cubeArray = n.ToString().ToCharArray().Select(Convert.ToInt32).ToArray();
        if (n <= 0)
        {
            return -1;
        }
        for (int i = 0; i < cubeArray.Length; i++)
        {
            cubesum += Math.Pow(cubeArray[i], 3);
        }
        if (cubesum == n)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("Integer:");
        int num = int.Parse(Console.ReadLine());
        int result = CubePowerful(num);
        if (result == 1)
        {
            Console.WriteLine("Cube Powerful");
        }
        else if (result == 0)
        {
            Console.WriteLine("Not Cube Powerful");
        }
        else
        {
            Console.WriteLine("Integer must be greater than 0");
        }
    }
}
//Sample 3
//part 1:
//Question 1:zero plentiful
class zero
{
    static int isZeroPlentiful(int[] a)
    {
        int count = 0;
        int zeroSeqCount = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == 0)
            {
                count++;
            }
            else
            {
                if (count >= 4)
                {
                    zeroSeqCount++;
                }
                count = 0;
            }
        }
        if (count >= 4)
        {
            zeroSeqCount++;
        }
        return zeroSeqCount;
    }
    static void Main()
    {
        Console.WriteLine("Size of array:");
        int size = int.Parse(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine(" Array:");
        for (int i = 0; i < size; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        int ans = isZeroPlentiful(a);

        Console.WriteLine("{0} sequences of zeroes ", ans);


    }
}
//Question 2:onion
class onion
{
    static int IsOnionArray(int[] n)
    {
        bool isonion = true;
        if (n.Length == 1 || n.Length == 0)
        {
            return 1;
        }
        int half = n.Length / 2;
        int i = 0;
        int j = n.Length - 1;
        if (n.Length % 2 == 0)
        {
            while (i != half + 1)
            {
                if ((n[i] < 0 || n[j] < 0) || (n[i] + n[j]) > 10)
                {
                    isonion = false;
                }
                i++;
                j--;
            }
        }
        else
        {
            while (i != j)
            {
                if ((n[i] < 0 || n[j] < 0) || (n[i] + n[j]) > 10)
                {
                    isonion = false;
                }
                i++;
                j--;
            }
        }
        if (isonion)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("Size of array:");
        int size = int.Parse(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine("Array of digits:");
        for (int i = 0; i < size; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        int result = IsOnionArray(a);
        if (result == 1)
        {
            Console.WriteLine("Onion Array");
        }
        else
        {
            Console.WriteLine("Not Onion Array");
        }
    }
}
//MUM entrance exam solutions
//Part 1
//Question 2:anagram
class anagram
{
    static int areAnagrams(char[] a, char[] b)
    {
        bool isanagram = true;
        if (a.Length != b.Length)
        {
            return 0;
        }
        Array.Sort(a);
        Array.Sort(b);
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i])
            {
                isanagram = false;
                break;
            }
        }
        if (isanagram)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("Size of First array:");
        int size = int.Parse(Console.ReadLine());
        char[] a = new char[size];
        Console.WriteLine("First Array:");
        for (int i = 0; i < size; i++)
        {
            a[i] = Convert.ToChar(Console.ReadLine());
        }
        Console.WriteLine("Size of Second array:");
        int size2 = int.Parse(Console.ReadLine());
        char[] b = new char[size2];
        Console.WriteLine("Second Array:");
        for (int i = 0; i < size2; i++)
        {
            b[i] = Convert.ToChar(Console.ReadLine());
        }
        int result = areAnagrams(a, b);
        if (result == 1)
        {
            Console.WriteLine("They are anagrams");
        }
        else
        {
            Console.WriteLine("They are not anagrams");
        }
    }
}
// Question 3:fibonacci
class fib
{
    static int closestFibonacci(int n)
    {
        int a = 0;
        int b = 1;
        int c = 1;
        while (c <= n)
        {
            a = b;
            b = c;
            c = a + b;
        }
        return b;
    }
    static void Main()
    {
        Console.WriteLine("Number:");
        int N = int.Parse(Console.ReadLine());

        int ans = closestFibonacci(N);
        Console.WriteLine(ans);
    }
}
//Part2
//Question 1:Vesuvian
class Vesuvian
{
    static int IsVesuvian(int n)
    {
        bool isves = false;
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (((Math.Sqrt(i) == (int)Math.Sqrt(i)) && (Math.Sqrt(j) == (int)Math.Sqrt(j))) && (i + j == n))
                {
                    isves = true;
                }
            }
        }
        if (isves)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("Number:");
        int num = Convert.ToInt32(Console.ReadLine());
        int result = IsVesuvian(num);
        if (result == 1)
        {
            Console.WriteLine("Is Vesuvian");
        }
        else
        {
            Console.WriteLine("Is not Vesuvian");
        }
    }
}
//Part 3
//Question 1:triangular
class tri
{
    static int istriangular(int n)
    {
        bool triangle = false;
        if (n == 1)
        {
            return 1;
        }
        int sum = 0;
        for (int i = 1; i < n; i++)
        {
            sum = sum + i;
            if (sum == n)
            {
                triangle = true;
                break;
            }
        }
        if (triangle)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("number:");
        int num = Convert.ToInt32(Console.ReadLine());
        int result = istriangular(num);
        if (result == 1)
        {
            Console.WriteLine("Is triangular");
        }
        else
        {
            Console.WriteLine("Not triangular");
        }
    }
}
//Question 2:Mercurial
class mercury
{
    static int isMercurial(int[] a)
    {
        bool foundOne = false;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == 1)
            {
                foundOne = true;
            }
            else if (a[i] == 3 && foundOne)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] == 1)
                    {
                        return 0;
                    }
                    else if (a[j] == 3)
                    {
                        break;
                    }
                }
            }
        }
        return 1;
    }
    static void Main()
    {
        Console.WriteLine("Size of array:");
        int size = int.Parse(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine(" Array:");
        for (int i = 0; i < size; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        int ans = isMercurial(a);
        if (ans == 1)
        {
            Console.WriteLine("It is mercurial");
        }
        else
        {
            Console.WriteLine("It is not mercurial");
        }
    }
}
//Question 3: 235 Array
class Is235
{
    static int Is235Array(int[] n)
    {
        int sum;
        int count2 = 0;
        int count3 = 0;
        int count5 = 0;
        int countnot = 0;
        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] % 2 == 0)
            {
                count2++;
            }
        }
        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] % 3 == 0)
            {
                count3++;
            }
        }
        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] % 5 == 0)
            {
                count5++;
            }
            if ((n[i] % 2 != 0) && (n[i] % 3 != 0) && (n[i] % 5 != 0))
            {
                countnot++;
            }
        }
        //Question 9:encode
        sum = count2 + count3 + count5 + countnot;
        if (sum == n.Length)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("Size of array:");
        int size = int.Parse(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine(" Array:");
        for (int i = 0; i < size; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        int result = Is235Array(a);
        if (result == 1)
        {
            Console.WriteLine("It is a 235 array");
        }
        else
        {
            Console.WriteLine("It is not a 235 array");
            //Question 9:pattern matching
        }
    }
}
//Part 4:
//Question 1:HMS
class hms
{
    static int[] ComputeHMS(int seconds)
    {
        int[] time = new int[3];
        time[0] = seconds / 3600;
        time[1] = (seconds % 3600) / 60;
        time[2] = seconds % 60;
        Console.WriteLine("The time is {0} hr {1} min {2} sec", time[0], time[1], time[2]);
        return time;
    }
    static void Main()
    {
        Console.WriteLine("Time in seconds:");
        int num = Convert.ToInt32(Console.ReadLine());
        ComputeHMS(num);
    }
}
//Question 2:Martian Array
class martian
{
    static int isMartian(int[] a)
    {
        int count = 0;
        int count2 = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == 1)
            {
                count++;
            }
            if (a[i] == 2)
            {
                count2++;
            }
            if (i < a.Length - 1 && a[i] == a[i + 1])
            {
                return 0;
            }
        }
        if (count > count2)
        {
            return 1;
        }
        else { return 0; }
    }
    static void Main()
    {
        Console.WriteLine("Size of array:");
        int size = int.Parse(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine(" Array:");
        for (int i = 0; i < size; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        int ans = isMartian(a);
        if (ans == 1)
        {
            Console.WriteLine("A martian array ");
        }
        else
        {
            Console.WriteLine("Not a martian array ");
        }
    }
}
//Question 3:Paired N
class pair
{
    static int ispairedN(int[] a, int n)
    {
        int sum;
        bool paired = false;
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = i + 1; j < a.Length - 1; j++)
            {
                if (a[j] != a[i])
                {
                    sum = a[j] + a[i];
                    if ((sum == n) && ((i + j) == n))
                    {
                        paired = true;
                    }
                }
            }
        }
        if (paired)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("Size of array:");
        int size = int.Parse(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine(" Array:");
        for (int i = 0; i < size; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("N:");
        int N = int.Parse(Console.ReadLine());
        int ans = ispairedN(a, N);
        if (ans == 1)
        {
            Console.WriteLine("A paired-N array ");
        }
        else
        {
            Console.WriteLine("Not a paired-N array ");
        }
    }
}


//Question 2:digit increasing

class pairs
{
    static int isdigitincreasing(int n)
    {
        int sum = 0;
        int curr = n;
        int mult = 1;

        while (curr > 0)
        {
            sum += curr;
            curr = n * (mult * 10 - 1) / 9;
            mult *= 10;
        }

        if (sum == n)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    static void Main()
    {
        Console.WriteLine("N:");
        int N = int.Parse(Console.ReadLine());
        int result = isdigitincreasing(N);
        if (result == 1)
        {
            Console.WriteLine("digit increasing");
        }
        else
        {
            Console.WriteLine("Not digit increasing");

        }

    }
}*/