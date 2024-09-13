using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System;




public class NewBehaviourScript : MonoBehaviour

{

    

    public Slider SliderThing;

    public Text restext;

    public Text record;
    public GameObject result;
    public GameObject cube;
    public GameObject cam ;
    public GameObject test;

    public GameObject prep;

    public Text cointext;

    public int coinval = 0;

    public int hp = 100;

    public int intToSave = 0;

    
    public List<GameObject> prep2 = new List<GameObject>();
    private float xcam =0f;
    public float spead = 5f;
    public float x =0;
    
    // Start is called before the first frame update
    void Start()
    {
        SliderThing.value = hp;
        Cursor.visible = false;
        AudioManager.instance.Play("music");


        

        if (PlayerPrefs.HasKey("SavedInteger"))
        {
            intToSave = PlayerPrefs.GetInt("SavedInteger");
            Debug.Log("Game data loaded!");
        }
        else
            Debug.LogError("There is no save data!");    
    }
 

//private void Awake() {
    
    
// }
  public void Update() 
    
 {  

    float spead2 = spead + (float)Math.Sqrt(coinval);

    //var angle = cube.transform.eulerAngles.y;
    //angle = Mathf.Repeat(angle + 180, 360) - 180;
    
    if(Input.GetKey (KeyCode.A)||Input.GetKey (KeyCode.LeftArrow)){
    cube.GetComponent<Transform>().Translate(new Vector3(-1,0,0)* (2+spead2/2)* Time.deltaTime);

    
    }
    if(Input.GetKey(KeyCode.D)||Input.GetKey (KeyCode.RightArrow)){
    cube.GetComponent<Transform>().Translate(new Vector3(1,0,0)* (2+spead2/2)* Time.deltaTime);

    } 




    //Debug.Log(angle);

    x = transform.position[0];
    xcam = cam.transform.position[0];

    
    if (x < (xcam -0.2))
    cam.GetComponent<Transform>().Translate(new Vector3(-1,0,0)* ((xcam-x)*10) * Time.deltaTime);

    if (x > (xcam+0.2))
    cam.GetComponent<Transform>().Translate(new Vector3(1,0,0)* ((x-xcam)*10) * Time.deltaTime);

    if (cube.transform.position[2] > cam.transform.position[2]+3)
    cam.GetComponent<Transform>().Translate(new Vector3(0,0,1)*spead2* Time.deltaTime,0);
    test.GetComponent<Transform>().Translate(new Vector3(0,0,1)*spead2* Time.deltaTime,0);
    cube.GetComponent<Transform>().Translate(new Vector3(0,0,1)*spead2* Time.deltaTime);

    if (prep2.Count < 1){
        
           //prep2.Add(Instantiate(prep, new Vector3(0, 0, cube.transform.position[2]+10),Quaternion.identity));


    }

    if(transform.position[1]< -2|| hp<0){
        
        result.SetActive(true);
        restext.text = "Было собрано: " + coinval;
        Time.timeScale = 0.1f;
        Cursor.visible = true;

        if(coinval>intToSave)
        {
        intToSave=coinval;
        PlayerPrefs.SetInt("SavedInteger", intToSave);
        PlayerPrefs.Save();
        }
        record.text = "Рекорд: " + intToSave;

        
        
        

    }



 }

     private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "coin" & hp>0){

            coinval++;
            Destroy(other.gameObject);
            cointext.text = "Монет собрано: " + coinval;
            AudioManager.instance.Play("money");
            
        }


        if(other.gameObject.tag == "barer"){
            hp -= 30;
            SliderThing.value = hp;
            AudioManager.instance.Play("avaria");
        }



    }






}
