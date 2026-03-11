using System;
using System.Collections.Generic;

// README.md를 읽고 아래에 코드를 작성하세요.
List <(string name, int quantity, int price)> inventory = new();
Console.WriteLine("=== 아이템 인벤토리 ===");
AddItem("체력 포션", 3, 500);
AddItem("마나 포션", 5, 800);
AddItem("해독제",2, 300);
AddItem("엘릭서", 1, 5000);
Console.WriteLine("=== 가장 비싼 아이템 ===");
FindMostExpensive();
Console.WriteLine("=== 인벤토리 합산 ===");
CalculateTotal();




void AddItem(string name, int quantity, int price)
{
    inventory.Add((name, quantity, price));
    Console.WriteLine($"{name} - 수량: {quantity}개, 단가: {price}원");

}
void FindMostExpensive()
{
    int maxPrice = 0;
    (string name,int price) mostExpensiveItem = ("", 0);
    foreach (var item in inventory)
    {
        if (item.price > maxPrice)
        {
            maxPrice = item.price;
            mostExpensiveItem = (item.name, item.price);
        }
    }
    Console.WriteLine($"이름: {mostExpensiveItem.name}, 단가: {mostExpensiveItem.price}원");

}

void CalculateTotal()
{
    int totalValue = 0;
    int totalCount = 0;
    foreach (var item in inventory)
    {
        totalValue += item.quantity * item.price;//총 가치 계산
        totalCount += item.quantity;//총 수량 계산
    }
    Console.WriteLine($"총 가치: {totalCount}개\n총 아이템 수: {totalValue}원");
}
