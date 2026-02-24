# ScoreTracker

과목별 점수를 관리하는 `ScoreTracker` 클래스를 구현하세요.

**요구사항**

- `ScoreTracker` 클래스에 다음 필드를 정의:
  - 최대 점수 (상수, 값 100)
  - 최소 점수 (상수, 값 0)
  - 과목명 (읽기 전용, 생성자에서 설정)
  - 현재 점수 (private, 초기값 0)
  - 보너스 적용 횟수 (private, 초기값 0)

- 생성자에서 과목명을 받아 초기화

- 다음 메서드를 구현:
  - `SetScore(int score)`: 점수 설정. 0~100 범위가 아니면 오류 메시지 출력
  - `AddBonus(int bonus)`: 보너스 점수 추가. 최대 점수 초과 시 최대 점수로 설정. 보너스 횟수 증가
  - `ShowScore()`: 과목명, 현재 점수, 최대 점수, 보너스 횟수 출력

## 예상 실행 결과

```
=== 수학 ===
점수: 0 / 100
보너스 적용 횟수: 0

점수를 85점으로 설정했습니다.
10점 보너스 적용! 현재 점수: 95점
20점 보너스 적용! 현재 점수: 100점 (최대 점수 도달)
점수는 0~100 사이여야 합니다.

=== 수학 ===
점수: 100 / 100
보너스 적용 횟수: 2
```
ScoreTracker math = new ScoreTracker("수학");
math.ShowScore();
Console.WriteLine();

math.SetScore(85);
math.AddBonus(10);
math.AddBonus(20);
math.SetScore(-10);
Console.WriteLine();

math.ShowScore();
