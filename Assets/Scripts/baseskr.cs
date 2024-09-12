using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class baseskr : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prep;
    public List<GameObject> prep2 = new List<GameObject>();
    public GameObject cub;
    //private float zcub =0;
    //public GameObject[] goCube ;
    public void Start()
    {    
        
    }

private void Awake(){
    //zcub = cub.transform.position[2];
}

    // Update is called once per frame
    private void Update()
    {
        

            
            if (prep2.Count < 3){
                
                 prep2.Add(Instantiate(prep, new Vector3(0, 0, cub.transform.position[2]+10),Quaternion.identity));


            }
        
        

    }
}
