using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clearobj : MonoBehaviour
{
    // Start is called before the first frame update

    //public GameObject obj;
    //public GameObject cub;


    void Start()
    {
        
    }

  
    void Update(){
        //if  (cub.transform.position[2]>obj.transform.position[2]) 
            //Destroy(obj.gameObject);


        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "barer" || other.gameObject.tag == "coin"){
            Destroy(other.gameObject,0.6f);
        }
        


    }
}



