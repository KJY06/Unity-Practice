# 코루틴

---

## 개념

---

- 함수 실행을 특정 시간동안 지연시키는 기능
- 원하는 기능을 원하는 타이밍에 한번씩만 실행시킬 수 있다.
- 인보크와 비슷하지만 유지보수에 더 효율적이다.

## 사용 예제

---

- 코루틴 사용 X

```csharp
using System.Collections;
using System.Collection.Generic;
using UnityEngine;

public class Item : MonoBehaniour
{
	private bool IsDelay;
	private float delaytime;
	private float currenttime;

	private void Start()
	{
		IsDelay = false;
		delaytime = 5;
		currenttime = 0;
	}
	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			IsDelay = true;
		}
		if(IsDelay)
		{
			currenttime += Time.deltaTime;
			if(currenttime >= delaytime)
			{
				currenttime = 0;
				IsDelay = false;
			}
		}
	}
}
```

- 아이템 사용 후 5초동안 사용이 안되는 코드를 코루틴 없이 구현했다.
- Update 함수는 1초당 약 60번이 실행되기 때문에 이러한 연산은 다소 부담이 클 수 있다.

- 코루틴 사용 O

```csharp
using System.Collections;
using System.Collection.Generic;
using UnityEngine;

public class Item : MonoBehaniour
{
	private bool IsDelay;
	private float delaytime;
	private float currenttime;

	private void Start()
	{
		IsDelay = false;
		delaytime = 5;
		currenttime = 0;
	}
	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			IsDelay = true;
			StartCoroutine(UseItem());
		}
	}

	IEnumerator UseItem()
	{
		yield return new WaitForSeconds(5);
		IsDelay = false;
	}
}
```

- 코루틴을 사용한 경우.
- 코루틴은 IEnumerator로 선언한다. 따라서 반환이 **yield return**으로 된다.
- **StartCoroutine(함수())** : 코루틴을 실행하는 명령어. 함수() 대신, “함수명” 으로 대체할 수 있다.
- **StopCoroutine(함수())** : 코루틴 종료. **StopAllCoroutine**도 있다.
- yield return, yield break : yield return은 지정된 시간만큼 반환을 지연하기에 어디에 있던지 그 **시간이 되면 실행**한다. yield break는 실행중 해당 문장을 실행하면 **그 즉시 반환**되고, 밑의 문장은 실행되지 않는다.
    - 이걸 굳이 맨 앞에 놓는 이유는 이 대기 시간동안 이 코루틴함수를 호출한 곳이 있는 메인 루틴을 실행 시킬 수 있기 때문에 **쉬는 동안 다른 일을 하는 효율이 있기 때문**이다.
    - **WaitForSeconds()** : **반환 시간을** 명시한다. 위 예제에서는 5초동안 반환을 지연 시킨다.
    - null : **1프레임**만큼 동작 중지.