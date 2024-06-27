using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Strawman : MonoBehaviour
{
    void Start()
    {
        // UI의 루트 요소를 작성했다.
        var root = GetComponent<UIDocument>().rootVisualElement;
        // 애니메이션 작동을 위한 Animator를 작성했다.
        var anim = GetComponent<Animator>();
        /*
         * 버튼에 동작을 할당하는 처리이다.
         * 
         * // Query, Build, First 등 여러 메서드의 호출을 필요로 하는 처리이다.
         * root.Query<Button>("button-dance").Build().First()
         * root.Query<Button>("button-spin") .Build().First()
         * root.Query<Button>("button-flip") .Build().First()
         * 
         * // 매우 자주 사용되기 때문에 생략해서 Q라고 쓸 수 있다.
         * // 아까 설정했던 이름으로 버튼 요소를 3개 검색하고 있다.
         * root.Q<Button>("button-dance")
         * root.Q<Button>("button-spin")
         * root.Q<Button>("button-flip")
         * 
         * // 각각 작성한 요소의 clicked 이벤트에 처리를 추가했다.
         * // 처리 기술로는 람다식을 사용하고 있다.
         * // 단순하게 각각 대응하는 애니메이션을 재생하는 간단한 처리이다.
         * .clicked += () => anim.Play("Dance");
         * .clicked += () => anim.Play("Spin");
         * .clicked += () => anim.Play("Flip");
         */
        root.Q<Button>("button-dance").clicked += () => anim.Play("Dance");
        root.Q<Button>("button-spin").clicked += () => anim.Play("Spin");
        root.Q<Button>("button-flip").clicked += () => anim.Play("Flip");
    }
}
