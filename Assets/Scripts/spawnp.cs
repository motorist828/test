using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class spawnp : MonoBehaviour
{
    public GameObject platform;

    public GameObject coin;

    public GameObject prepyts;
    public float speed;
    public float zSpawnPrefabDistaince;
    public float zSpawnPrep;
    public float zSpawncoin;
    void Update()
    {
        transform.Translate(transform.forward * speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("platform"))
        {
            print("collision stay");
            float[] spisok = {-1.7f,0,0,1.7f};
            Instantiate(platform, new Vector3(0.0f, -0.5f, transform.position.z + zSpawnPrefabDistaince), Quaternion.identity);
            Instantiate(coin, new Vector3(0.0f, 0.0f, transform.position.z + zSpawnPrep+5), Quaternion.Euler(90,0,0));
            Instantiate(coin, new Vector3(0.0f, 0.0f, transform.position.z + zSpawnPrep + 8), Quaternion.Euler(90,0,0));
            Instantiate(prepyts, new Vector3( spisok[Random.Range(0,4)]  , 0.0f, transform.position.z + zSpawnPrep), Quaternion.identity);

            Instantiate(coin, new Vector3(0.0f, 0.0f, transform.position.z + zSpawnPrep+20), Quaternion.Euler(90,0,0));
            Instantiate(coin, new Vector3(0.0f, 0.0f, transform.position.z + zSpawnPrep + 23), Quaternion.Euler(90,0,0));
            Instantiate(prepyts, new Vector3( spisok[Random.Range(0,4)]  , 0.0f, transform.position.z + zSpawnPrep+15), Quaternion.identity);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        Destroy(collision.gameObject);
       
    }



}      
    

