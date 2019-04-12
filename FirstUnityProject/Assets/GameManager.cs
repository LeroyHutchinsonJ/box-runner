using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool HasGameEnded = false;
    public float GameEndDelay;
   public void EndGame()
    {
        if(HasGameEnded == false)
        {
            Debug.Log("Game Over");
            HasGameEnded = true;
            Invoke("RestartGame", GameEndDelay);
        }
        
    }

    public void RestartGame()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       
    }
}
