using System;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    [System.Obsolete]
    void Awake()
    {
        int numberGameSessions = FindObjectsByType<GameSession>(FindObjectsInactive.Exclude, FindObjectsSortMode.None).Length;
        if (numberGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

   

    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
