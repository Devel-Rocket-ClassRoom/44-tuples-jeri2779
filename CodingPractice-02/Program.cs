using System;

// README.md를 읽고 코드를 작성하세요.
{
    Console.WriteLine("## 1. 기본 튜플 반환");

    var t = Tally();
    Console.WriteLine($"합계: {t.Item1}, 개수: {t.Item2}");

    static (int, int) Tally()
    {
        var result = (12, 3);
        return result;
    }
}
Console.WriteLine();
{
    Console.WriteLine("## 2. 반환 튜플에 이름 지정");
    var result = Calculate();
    Console.WriteLine($"합계: {result.sum}, 개수: {result.count}");

    static(int sum, int count) Calculate()
    {
        return (45, 6);
    }
}
Console.WriteLine();
{
    Console.WriteLine("## 3. 표현식 본문으로 간결하게 작성");
    var result = GetPair();
    Console.WriteLine($"{result.first},{result.second}");

    static (int first, int second) GetPair() => (100, 200);
}
Console.WriteLine();
{
    Console.WriteLine("## 4. 최솟값과 최댓값 반환");

    int[] numbers = { 5, 2, 8, 1, 9, 3 };

    var res = FindMinMax(numbers);
    Console.WriteLine($"최솟값: {res.min}, 최댓값: {res.max}");

    static(int min, int max) FindMinMax(int[] nums)
    {
        int min = nums[0];
        int max = nums[0];
        foreach(int num in nums)
        {
            if(num < min) { min = num;}
            if(num > max) { max = num;}
        }
        return (min, max);
    }
}
Console.WriteLine();
{
    Console.WriteLine("## 5. 기본값 반환");
    static (int, int) ZeroZero() => default;
    var zero = ZeroZero();
    Console.WriteLine($"{zero.Item1}, {zero.Item2}");
}
Console.WriteLine();
{
    Console.WriteLine("## 6. 분해 기본");
    var tp6 = (Name: "Bob", Age: 23);
    var (name, age) = tp6;
    Console.WriteLine($"이름: {name}");
    Console.WriteLine($"나이: {age}");
}
Console.WriteLine();
{
    Console.WriteLine("## 7. var를 사용한 분해");
    var (sum, count) = Tally();
    var tp7 = (sum: 12, count: 3);

    static (int,int) Tally() => (12, 3);
}
Console.WriteLine();
{
    Console.WriteLine("## 8. 기존 변수에 분해");
    string firstName = "";
    int userAge = 0;

    var person = ("Alice", 30);
    (firstName, userAge) = person;

    Console.WriteLine($"{firstName},{userAge}");
}
Console.WriteLine();
{
    Console.WriteLine("## 9. 무시 패턴 (`_`)");
    var (_, age, _) = GetPerson();
    Console.WriteLine($"나이: {age}");
    
    static (string name ,int age,char gender) GetPerson() =>
        ("Bob", 23, 'M');

}