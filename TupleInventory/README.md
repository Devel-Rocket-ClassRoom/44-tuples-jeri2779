# 아이템 인벤토리

아이템 인벤토리를 튜플 리스트로 관리하는 프로그램을 작성하시오.

다음 기능을 구현해야 함:

1. **인벤토리 리스트**: `List<(string name, int quantity, int price)>` 타입으로 선언

2. **AddItem 메서드**: 아이템 이름, 수량, 단가를 받아서 튜플을 생성하고 리스트에 추가
   - 매개변수: `List<(string name, int quantity, int price)> inventory, string name, int quantity, int price`

3. **FindMostExpensive 메서드**: 인벤토리에서 단가가 가장 비싼 아이템을 찾아 반환
   - 반환 타입: `(string name, int price)`

4. **CalculateTotal 메서드**: 인벤토리 전체의 총 가치(수량 x 단가 합산)와 총 아이템 수를 반환
   - 반환 타입: `(int totalValue, int totalCount)`

5. **Main**:
   - 인벤토리에 아이템 4개 추가: 체력 포션(3개, 500원), 마나 포션(5개, 800원), 해독제(2개, 300원), 엘릭서(1개, 5000원)
   - 전체 아이템 목록 출력
   - FindMostExpensive 결과를 분해하여 출력
   - CalculateTotal 결과를 분해하여 출력

## 예상 실행 결과

```
=== 아이템 인벤토리 ===
체력 포션 - 수량: 3개, 단가: 500원
마나 포션 - 수량: 5개, 단가: 800원
해독제 - 수량: 2개, 단가: 300원
엘릭서 - 수량: 1개, 단가: 5,000원

=== 가장 비싼 아이템 ===
이름: 엘릭서, 단가: 5,000원

=== 인벤토리 합산 ===
총 가치: 11,100원
총 아이템 수: 11개
```
