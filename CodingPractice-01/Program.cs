using System;

// README.md를 읽고 코드를 작성하세요.

{
    Console.WriteLine("## 1. 튜플 리터럴");

    (string, int) tp1 = ("Bob", 23);
    Console.WriteLine($"{tp1.Item1}");
    Console.WriteLine($"{tp1.Item2}");
}
Console.WriteLine();
{
    Console.WriteLine("### 2-1. 같은 타입의 튜플");
    var nums = (12, 34, 56);
    Console.WriteLine($"{nums.Item1}, {nums.Item2}, {nums.Item3}");
}
Console.WriteLine();
{
    Console.WriteLine("### 2-2. 서로 다른 타입의 튜플");
    var mix = ("Hello", 100, true, 3.14);
    Console.WriteLine($"{mix.Item1}, {mix.Item2}, {mix.Item3}, {mix.Item4}");

}
Console.WriteLine();
{
    Console.WriteLine("### 3-1. 기본 명시적 타입");
    (string, int) tp2 = ("Alice", 25);
    Console.WriteLine($"{tp2.Item1}, {tp2.Item2}");

}
Console.WriteLine();
{
    Console.WriteLine("### 3-2. 이름이 있는 명시적 타입");
    (ushort Width, ushort Height) tp3 = (1920, 1080);
    Console.WriteLine($"해상도: {tp3.Width} x {tp3.Height}");
}
Console.WriteLine();
{
    Console.WriteLine("## 4. 튜플의 값 타입 특성");
    var origin = ("Bob", 23);
    var copy = origin;
    copy.Item1 = "Joe";
    Console.WriteLine($"원본: ({origin.Item1}, {origin.Item2})");
    Console.WriteLine($"복사본: ({copy.Item1}, {copy.Item2})");
}
Console.WriteLine();
{
    Console.WriteLine("## 5. 생성 시 이름 지정");
    var ps1 = (Name: "Bob", Age: 23);
    Console.WriteLine(ps1.Name);
    Console.WriteLine(ps1.Age);

    Console.WriteLine(ps1.Item1);
    Console.WriteLine(ps1.Item2);
}
Console.WriteLine();
{
    Console.WriteLine("## 6. 요소 이름 지정 예제");
    var student = (name: "철수", IsStudent: true, OrderPrice: 1_000);
    Console.WriteLine($"{student.name}(학생: {student.IsStudent}) - 주문: {student.OrderPrice:N0}원");

}
Console.WriteLine();
{
    Console.WriteLine("## 7. 타입 선언에서 이름 지정");
    (string name, int age, char gender) ps7 = ("Bob", 23, 'M');
    Console.WriteLine($"이름: {ps7.name} \n나이: {ps7.age} \n성별: {ps7.gender}");
}
Console.WriteLine( );
{
    Console.WriteLine();
    var now = DateTime.Now;
    var datetp = (now.Day,now.Month, now.Year);

    Console.WriteLine($"일: {datetp.Day}");
    Console.WriteLine($"월: {datetp.Month}");
    Console.WriteLine($"년: {datetp.Year}");
}
