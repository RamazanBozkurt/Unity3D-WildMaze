using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class pausedGameMenu : MonoBehaviour {

    public GameObject pauseMenu;    
    public bool pause;   
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController player;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause = !pause;
        }
        if (pause)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
            player.enabled = false;
            Cursor.visible = true;
        }
        else
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1;
            player.enabled = true;
            Cursor.visible = false;
        }
        
    }
    public void resumeGame()
    {
        pause = !pause;
    }
    public void exitToMenu()
    {
        SceneManager.LoadScene("ANA MENU");
    }
    
    
}
