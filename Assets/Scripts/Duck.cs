using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour
{
    public int duckIndex; // 오리의 순서 정보를 나타내는 번호

    private void OnCollisionEnter2D(Collision2D other)
    {
        //other 파라미터를 통해 충돌한 게임 오브젝트의 Duck 클래스에 접근
        Duck otherDuck = other.gameObject.GetComponent<Duck>();

        if (otherDuck != null)// 충돌한 게임 오브젝트에 Duck 클래스가 존재하는지 확인
        {
            // 충돌한 게임오브젝트에 Duck 클래스가 존재하고, 충돌한 오브젝트끼리 번호가 같은지 확인
            if ((duckIndex == otherDuck.duckIndex))

            {
                // 로그를 출력하고 게임 오브젝트를 게임에서 제거
                Debug.Log("충돌!");
                Destroy(gameObject);
            }
        }
    }
}
