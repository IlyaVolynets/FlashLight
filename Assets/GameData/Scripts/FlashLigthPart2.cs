using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLigthPart2 : MonoBehaviour {
    public AudioSource sourse;
    public AudioClip LightOnSound;
    public GameObject FL;
    private bool On = true;
    public float Intensity;
    public float Battery, BatteryStep;

   
    void Start() {

    }

 
    void Update() {
       

        Battery -= BatteryStep;
        if (Battery>0)
        {

            if (Input.GetKeyDown("f"))
            {
                if (On == false)
                {
                    
                   // FL.SetActive(true);
                    //On = true;
                    FL.GetComponent<Fonarik>().Energy += 50;
                    
                }
                else
                {
                    FL.GetComponent<Fonarik>().Energy -= 20;
                    //FL.SetActive(false);
                    //On = false;

                }
            }



        }
        else
        {
            FL.SetActive(false);
        }
     
    }
   
}
