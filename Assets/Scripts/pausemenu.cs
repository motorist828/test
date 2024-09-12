using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemenu : MonoBehaviour
{
public GameObject PausePanel;

void Update()
{

}

public void Pause()
{
    PausePanel.SetActive(true);
    Time.timeScale = 0;
}

public void Contine()
{
    PausePanel.SetActive(false);
    Time.timeScale = 1;
}

}
