# 물리적 충돌 이벤트

---

## OnCollision

---

- 오브젝트에 **물리적 충돌이 일어났을 때 실행**되는 메서드.
- 오브젝트에 충격이 가해졌음을 인지하기 위해 충돌하는 **두 오브젝트엔 collider 컴포넌트가 필요**하다. **또한 둘 중 한 오브젝트엔 rigidbody**가 있어야 한다.

## OnTrriger

---

- 콜리젼과 트리거의 사용 상황의 차이는 오브젝트의 콜라이더에 **istrriger**가 켜져있냐 아니냐로 갈린다.
    - istrriger가 켜져있는 오브젝트는 외부 물리작용을 무시한다. 따라서 콜리젼으론 못 읽는다.
- istrriger때문에 무시받는 충돌을 트리거가 인지할 수 있다.

### 종류

---

- 콜리젼 트리거 둘 다 종류는 같다. 콜리젼으로 설명하겠다.
- OnCollisionEnter / OnCollisionEnter2D
    - 물체가 **충돌한 순간**에 발동.
- OnCollisionStay / OnCollisionStay2D
    - 물체가 **충돌하는 동안**에 발동.
- OnCollisionExit / OnCollisionExit2D
    - 물체의 **충돌이 끝날 때** 발동.