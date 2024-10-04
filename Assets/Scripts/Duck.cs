using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class Duck : MonoBehaviour
{
    public int duckIndex; // ������ ���� ������ ��Ÿ���� ��ȣ
    public GameObject managerObject;

    private GameManager gameManager;

    void Awake()
    {
        managerObject = GameObject.Find("GameManager");
        gameManager = managerObject.GetComponent<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //other �Ķ���͸� ���� �浹�� ���� ������Ʈ�� Duck Ŭ������ ����
        Duck otherDuck = other.gameObject.GetComponent<Duck>();

        if (otherDuck != null)// �浹�� ���� ������Ʈ�� Duck Ŭ������ �����ϴ��� Ȯ��
        {
            // �浹�� ���ӿ�����Ʈ�� Duck Ŭ������ �����ϰ�, �浹�� ������Ʈ���� ��ȣ�� ������ Ȯ��
            if ((duckIndex == otherDuck.duckIndex) && duckIndex < gameManager.duckPrefabs.Length)
            {
                gameManager.collisionCount++;
                Vector2 collisionPoint = other.contacts[0].point;
                gameManager.mergeDuck(duckIndex, collisionPoint);

                // �α׸� ����ϰ� ���� ������Ʈ�� ���ӿ��� ����
                Debug.Log("�浹!");
                Destroy(gameObject);
            }
        }
    }
}
