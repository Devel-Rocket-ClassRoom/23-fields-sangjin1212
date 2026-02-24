# ClassroomManager

교실의 학생 명단을 관리하는 `ClassroomManager` 클래스를 구현하세요.

**요구사항**

- `ClassroomManager` 클래스를 만들고 다음 필드를 포함:
  - 최대 학생 수 (상수, 값 5)
  - 반 이름 (읽기 전용, 생성자에서 설정)
  - 학생 이름 배열 (private)
  - 현재 학생 수 (private, 초기값 0)
  - 총 교실 수를 추적하는 정적 필드 (private)

- 생성자에서 반 이름을 받아 초기화하고, 학생 배열을 생성하고, 총 교실 수를 1 증가시키세요

- 다음 메서드를 구현:
  - `AddStudent(string name)`: 학생 추가. 정원 초과 시 오류 메시지 출력
  - `ShowStudents()`: 반 이름과 학생 목록 출력
  - `ShowTotalClassrooms()` (정적 메서드): 총 교실 수 출력

## 예상 실행 결과

```
=== 1반 학생 목록 (3/5) ===
1. 홍길동
2. 김철수
3. 이영희

=== 2반 학생 목록 (2/5) ===
1. 박민수
2. 정수진

전체 교실 수: 2
```

ClassroomManager class1 = new ClassroomManager("1반");
class1.AddStudent("홍길동");
class1.AddStudent("김철수");
class1.AddStudent("이영희");
class1.ShowStudents();
Console.WriteLine();

ClassroomManager class2 = new ClassroomManager("2반");
class2.AddStudent("박민수");
class2.AddStudent("정수진");
class2.ShowStudents();
Console.WriteLine();

ClassroomManager.ShowTotalClassrooms();