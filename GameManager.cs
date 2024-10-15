
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{ 
    bool gameHasEnded = false;

    public float restartDelay = 1f;
    public GameObject completeLevel1UI;
    public PlayerMovement movement;
  

    public void EndGame()
    {
      if (gameHasEnded == false)
      {
        gameHasEnded = true;
        movement.enabled = false;
        Debug.Log("GAME OVER!");
        Invoke("Restart",restartDelay);
      }
      
    }

    public void NextLevel()
    {     
        CompleteLevel(); 
        
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Invoke("LoadNextLevel", restartDelay);
        }
    }

    public void CompleteLevel()
    {
        completeLevel1UI.SetActive(true);
        
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void LoadNextLevel()
    {
        Debug.Log("****");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("active scene"+ SceneManager.GetActiveScene().name);
        
    }
    
}
