using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SingletonBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindAnyObjectByType<T>();
                DontDestroyOnLoad(_instance.gameObject);
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if(_instance != null )
        {
            if(_instance != this)
            {
                Destroy(gameObject); 
            }
            return; 
        }
        _instance = GetComponent<T>();
        DontDestroyOnLoad(gameObject); 
    }
}
