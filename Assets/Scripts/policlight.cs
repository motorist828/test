using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class policlight : MonoBehaviour
{   public GameObject LightRed;
    public GameObject LightBlue;
    public float timer = 0;
    public float newtimer =0;
    



    // Update is called once per frame
    void Update()
    {
        timer-=Time.deltaTime;
        if(timer<0){
            timer =newtimer;
        }
        if(timer>1){
            LightBlue.SetActive(true);
            LightRed.SetActive(false);
        }
        if(timer<1){
            LightBlue.SetActive(false);
            LightRed.SetActive(true); 
        }

    }
}
