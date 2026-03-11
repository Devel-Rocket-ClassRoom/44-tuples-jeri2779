using System;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.

{
    Console.WriteLine("## 1. Equals 메서드");
    var t1 = ("one", 1);
    var t2 = ("one", 1);
    var t3 = ("two", 2);

    Console.WriteLine(t1.Equals(t2));
    Console.WriteLine(t1.Equals(t3));
}
Console.WriteLine();
{
    var ti = ("one", 1);
    var tt = ("one", 1);

    Console.WriteLine(ti == tt);
    Console.WriteLine(ti != tt);
}
Console.WriteLine();
{
    Console.WriteLine("## 3. 타입 호환성 - 기본");
    (string name, int age) person1 = ("Alice", 25);
    (string x, int y) person2 = person1;

    Console.WriteLine($"{person2.x}, {person2.y}");
}
Console.WriteLine();
{
    Console.WriteLine("## 4. 타입 호환성 - 주의사항");
    (string name, int age, char sex) bob1 = ("Bob", 23, 'M');
    (string age, int sex, char name) bob2 = bob1;

    Console.WriteLine(bob2.age);
    Console.WriteLine(bob2.sex);
    Console.WriteLine(bob2.name);
}
Console.WriteLine();
{
    Console.WriteLine("## 5. 제네릭과 튜플 - 리스트");

    List<(string name, int age)> people = new()
    {
        ("Alice", 25),
        ("Bob", 30),
        ("Charlie", 35)
    };
    foreach (var person in people)
    {
        Console.WriteLine($"{person.name}: {person.age}세");
    }
}
Console.WriteLine();
{
    Console.WriteLine("## 6. 딕셔너리의 키로 튜플 사용");

    Dictionary<(int x, int y), string> locations = new()
    {
        [(0, 0)] = "원점",
        [(1, 0)] = "오른쪽"
    };
    foreach (var location in locations)
    {
        Console.WriteLine(location.Value);
    }
}
Console.WriteLine();
{
    Console.WriteLine("## 7. System.Tuple 클래스");

    var tuple1 = Tuple.Create("Bob", 23);
    var tuple2 = Tuple.Create("Alice", 25);

    Console.WriteLine($"{tuple1.Item1}, {tuple1.Item2}");
    Console.WriteLine($"{tuple2.Item1}, {tuple2.Item2}");
}