using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour
{
    public int duckIndex; // ������ ���� ������ ��Ÿ���� ��ȣ

    private void OnCollisionEnter2D(Collision2D other)
    {
        //other �Ķ���͸� ���� �浹�� ���� ������Ʈ�� Duck Ŭ������ ����
        Duck otherDuck = other.gameObject.GetComponent<Duck>();

        if (otherDuck != null)// �浹�� ���� ������Ʈ�� Duck Ŭ������ �����ϴ��� Ȯ��
        {
            // �浹�� ���ӿ�����Ʈ�� Duck Ŭ������ �����ϰ�, �浹�� ������Ʈ���� ��ȣ�� ������ Ȯ��
            if ((duckIndex == otherDuck.duckIndex))

            {
                // �α׸� ����ϰ� ���� ������Ʈ�� ���ӿ��� ����
                Debug.Log("�浹!");
                Destroy(gameObject);
            }
        }
    }
}
