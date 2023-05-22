using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    [SerializeField] private Transform[] childs;    // 위치를가지고 있어야하니까
    [SerializeField] private float scrollSpeed;

    [SerializeField] private Transform startPoint;  // 반복을 시작할 시점
    [SerializeField] private Transform endPoint;    // 반복을 마치고 돌아가 시점

    private void Update()
    {
        Scroll();
    }
    private void Scroll()
    {
        for (int i = 0; i < childs.Length; i++)
        {
            childs[i].Translate(Vector2.left * scrollSpeed * Time.deltaTime, Space.World);
            if (childs[i].position.x < endPoint.position.x) // 차일드의 포지션 x가 end포인트의 x 보다 적은경우
            {
                childs[i].position = startPoint.position;
            }
        }
    }


}
