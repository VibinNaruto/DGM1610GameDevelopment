using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    // What this code does is load the next scene when you land on the final block. But you have to go to build settings and apply the level.
    // At the top I used SceneMangaement so it wouldd use the engine.
    private void OnCollisionEnter2D(Collision2D other)
    {
        SceneManager.LoadScene("level2");
    }
}
