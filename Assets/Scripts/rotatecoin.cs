using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class rotatecoin : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject coin;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0,0,90) * Time.deltaTime);
    }
}
