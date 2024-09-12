using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menupause : MonoBehaviour
{
    public static bool Paused = false;
    public GameObject PauseMenuCanvas;
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(Paused)
            {
                Play();
            }
            else
            {
                Stop();
            }
        }
    }

    void Stop()
    {
        PauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
            Cursor.visible = true;
        Paused = true;
    }
    void Play()
    {
         PauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
            Cursor.visible = false;
        Paused = false;       
    }

    public void ExitGame(){
        Application.Quit();
         
    }
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex );
    }

}
