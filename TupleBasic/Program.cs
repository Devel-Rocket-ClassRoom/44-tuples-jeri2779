using System;

// README.md를 읽고 코드를 작성하세요.

(string name, int age, int grade) CreateStudent(string name, int age, int grade)
{
    return (name, age, grade);
}

//PrintStudent 메서드
void PrintStudent((string name, int age, int grade) student )
{
    Console.WriteLine($"이름: {student.name}\n나이: {student.age}\n학년: {student.grade}");
}

{
    Console.WriteLine("=== 학생 정보 출력 ===");
    var student = CreateStudent("철수", 16, 1);
    Console.WriteLine($"이름: {student.name}, 나이: {student.age}세, 학년: {student.grade}학년");

    var student2 = CreateStudent("영희", 17, 2);  
    Console.WriteLine($"이름: {student2.name}, 나이: {student2.age}세, 학년: {student2.grade}학년");

    var student3 = CreateStudent("민수", 18, 3);
    Console.WriteLine($"이름: {student3.name}, 나이: {student3.age}, 학년: {student3.grade}");
    Console.WriteLine();
    Console.WriteLine("=== 첫 번째 학생 분해 ===");
    PrintStudent(student);


}