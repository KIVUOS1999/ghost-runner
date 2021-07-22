using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class STARTINNG : MonoBehaviour
{
    public void QUIT(){
        Debug.Log("Quit");
        Application.Quit();
    }

    public void start_game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
