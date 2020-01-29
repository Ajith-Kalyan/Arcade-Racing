using UnityEngine;
using UnityEngine.SceneManagement; // for managing the scenes i.e load scene

public class GameManager : MonoBehaviour
{

    public bool gameEnded = false;
    public float restartDelay = 1f;
    public GameObject levelCompleteUI;


  public void EndGame()
    {
        if (gameEnded == false)
        {
            Debug.Log("Game Over");
            gameEnded = true;

            Invoke("Restart", restartDelay);
            //Restart(); // to restart the game
        }
   }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



    public void LevelComplete()
    {
        levelCompleteUI.SetActive(true); 
    }

}
