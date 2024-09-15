using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{

    public int audioSave = 0;
    public Dropdown audrop;

void Start()
{
        if (PlayerPrefs.HasKey("Savedaudio"))
        {
            audioSave = PlayerPrefs.GetInt("Savedaudio");
            Debug.Log("Game data loaded!");
            audrop.value = audioSave;
        }

}



    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        audioSave = audrop.value;
        PlayerPrefs.SetInt("Savedaudio", audioSave);
        PlayerPrefs.Save();

    }
    public void ExitGame(){
        Application.Quit();
         
    }
}



