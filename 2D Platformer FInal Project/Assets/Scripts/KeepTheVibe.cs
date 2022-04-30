using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepTheVibe : MonoBehaviour
{
    // So this is a simple line of code that will prevent the music from stopping at each level. So it will be continuous. 
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
