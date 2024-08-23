using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class GameEvents : MonoBehaviour
{
    
    public Text gameOverText;

    
    void Start()
    {
        
        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(false);
        }
    }

    
    private void OnTriggerEnter(Collider other)
    {
        
        Debug.Log("Trigger detected with: " + other.gameObject.name);

        if (other.gameObject.CompareTag("Player"))
        {
            
            if (gameOverText != null)
            {
                gameOverText.gameObject.SetActive(true);
                gameOverText.text = "Game Over";
            }

            

            
            SceneManager.LoadScene("LoadScreen");
        }
        else
        {
            
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
