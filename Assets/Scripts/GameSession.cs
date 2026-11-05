using System;
using TMPro;
using Unity.Tutorials.Editor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    [SerializeField] int playerLives = 3;

    [SerializeField] TextMeshProUGUI livesText;
    [SerializeField] TextMeshProUGUI scoreText;

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
        livesText.text = playerLives.ToString();
    }

    public void ProcessPlayerDeath()
    {
        if (playerLives > 1)
        {
            Takelife();
        }
        else
        {
            ResetGameSession();
        }
    }

    void Takelife()
    {
        playerLives--;
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
        livesText.text = playerLives.ToString();
    }

    void ResetGameSession()
    {
        SceneManager.LoadScene(0);
        Destroy(gameObject);
    }

    


    void Update()
    {
        
    }
}
