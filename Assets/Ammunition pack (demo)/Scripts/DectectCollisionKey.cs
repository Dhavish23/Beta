using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DectectCollisionKey : MonoBehaviour
{
    public Text youWinText;

    void Start()
    {
        if (youWinText != null)
        {
            youWinText.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger detected with: " + other.gameObject.name);

        if (other.gameObject.CompareTag("Player"))
        {
            if (youWinText != null)
            {
                youWinText.gameObject.SetActive(true);
                youWinText.text = "You Win!";
            }

            
            SceneManager.LoadScene("WinGame");
        }
        else
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }

    
}
