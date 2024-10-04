using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int collisionCount;
    public GameObject[] duckPrefabs;
    public int gameScore;

    public static bool canPlay = true;

    // Start is called before the first frame update
    void Start()
    {
        gameScore = 0;
        canPlay = true;
    }

    public void mergeDuck(int duckIndex, Vector2 pos)
    {
        if (collisionCount >= 2 && duckIndex < duckPrefabs.Length)
        {
            if (duckIndex < duckPrefabs.Length - 1)
            {
                Instantiate(duckPrefabs[duckIndex + 1], pos, Quaternion.identity);
            }

            switch (duckIndex)
            {
                case 0:
                    gameScore += 1;
                    break;
                case 1:
                    gameScore += 3;
                    break;
                case 2:
                    gameScore += 6;
                    break;
                case 3:
                    gameScore += 10;
                    break;
                case 4:
                    gameScore += 15;
                    break;
                case 5:
                    gameScore += 21;
                    break;
                case 6:
                    gameScore += 28;
                    break;
                case 7:
                    gameScore += 36;
                    break;
                case 8:
                    gameScore += 45;
                    break;
                case 9:
                    gameScore += 55;
                    break;
                case 10:
                    gameScore += 66;
                    break;
            }

            collisionCount = 0;
        }
    }

    public IEnumerator GameOver()
    {
        canPlay = false;
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(2f);
        Time.timeScale = 1f;
        Restart();
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
