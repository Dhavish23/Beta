using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public int totalKeysToCollect = 2;
    public int keysCollected = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Keep this instance across scenes
        }
        else
        {
            Destroy(gameObject); // Ensure only one instance
        }
    }

    public void CollectKey()
    {
        keysCollected++;
        if (keysCollected >= totalKeysToCollect)
        {
            // Trigger win condition
            WinGame();
        }
    }

    private void WinGame()
    {
        // Load the win scene
        SceneManager.LoadScene("WinGame");
    }
}
