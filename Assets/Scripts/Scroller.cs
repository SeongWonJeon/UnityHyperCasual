using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    [SerializeField] private Transform[] childs;    // ��ġ�������� �־���ϴϱ�
    [SerializeField] private float scrollSpeed;

    [SerializeField] private Transform startPoint;  // �ݺ��� ������ ����
    [SerializeField] private Transform endPoint;    // �ݺ��� ��ġ�� ���ư� ����

    private void Update()
    {
        Scroll();
    }
    private void Scroll()
    {
        for (int i = 0; i < childs.Length; i++)
        {
            childs[i].Translate(Vector2.left * scrollSpeed * Time.deltaTime, Space.World);
            if (childs[i].position.x < endPoint.position.x) // ���ϵ��� ������ x�� end����Ʈ�� x ���� �������
            {
                childs[i].position = startPoint.position;
            }
        }
    }


}
