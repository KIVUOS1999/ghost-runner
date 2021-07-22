using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public void QUIT(){
        Debug.Log("Quit");
        Application.Quit();
    }

    public void start_game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
