using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hp : MonoBehaviour
{
    public string sceneName;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            HpUI2.hp -= 1;
        }
        else if (other.CompareTag("Heart"))
        {
            HpUI2.hp += 1;
        }

        if (HpUI2.hp == 0)
        {
            SceneManager.LoadScene(sceneName);
            HpUI2.hp = 5;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Heart"))
        {
            HpUI2.hp += 1;
        }
        if (collision.collider.CompareTag("Obstacle"))
        {
            HpUI2.hp -= 1;
        }

        if (HpUI2.hp == 0)
        {
            SceneManager.LoadScene(sceneName);
            HpUI2.hp = 5;
        }

        if (HpUI2.hp == 0)
        {
            SceneManager.LoadScene(sceneName);
            HpUI2.hp = 5;
        }
    }
}
