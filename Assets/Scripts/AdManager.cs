using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour
{
    public static AdManager Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy (gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad (gameObject);
        }
    }
}
