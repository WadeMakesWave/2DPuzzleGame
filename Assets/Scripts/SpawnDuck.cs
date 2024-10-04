using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDuck : MonoBehaviour
{
    public GameObject duckPrefab;

    // Update is called once per frame
    void Update()
    {
        // 왼쪽 클릭 시
        if (Input.GetMouseButtonDown(0))
        {
            // 마우스의 현재 Position을 가져오기
            Vector2 mousePosition = Input.mousePosition;

            // 메인 카메라를 통해 마우스의 현재 Position에서 광선을 발사
            Ray ray = Camera.main.ScreenPointToRay(mousePosition);
            // 발사한 광선이 어떠한 물체와 충돌했는지에 대한 정보를 hit에 저장
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            // 충돌한 물체가 있을 시
            if (hit.collider != null)
            {
                // 충돌 지점의 x좌표를 가져오기
                float xPos = hit.point.x;
                // 오리의 소환 지점 설정
                Vector2 spawnPosition = new Vector2(xPos, 3.5f);
                // 오리 소환
                Instantiate(duckPrefab, spawnPosition, Quaternion.identity);
            }
        }
     }
  }
