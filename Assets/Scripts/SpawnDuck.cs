using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDuck : MonoBehaviour
{
    public GameObject duckPrefab;

    // Update is called once per frame
    void Update()
    {
        // ���� Ŭ�� ��
        if (Input.GetMouseButtonDown(0))
        {
            // ���콺�� ���� Position�� ��������
            Vector2 mousePosition = Input.mousePosition;

            // ���� ī�޶� ���� ���콺�� ���� Position���� ������ �߻�
            Ray ray = Camera.main.ScreenPointToRay(mousePosition);
            // �߻��� ������ ��� ��ü�� �浹�ߴ����� ���� ������ hit�� ����
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            // �浹�� ��ü�� ���� ��
            if (hit.collider != null)
            {
                // �浹 ������ x��ǥ�� ��������
                float xPos = hit.point.x;
                // ������ ��ȯ ���� ����
                Vector2 spawnPosition = new Vector2(xPos, 3.5f);
                // ���� ��ȯ
                Instantiate(duckPrefab, spawnPosition, Quaternion.identity);
            }
        }
     }
  }
