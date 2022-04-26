using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepTheVibe : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
