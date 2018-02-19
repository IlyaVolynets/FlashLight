using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour {
    public FlashLigthPart2 fl;
    private float distance;
    public string TakeText;
    public float TakeDistance;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        distance = Vector3.Distance(transform.position, fl.transform.position);
        if (distance < TakeDistance)
        {
            if (Input.GetKeyDown("e"))
            {
                fl.Battery++;
                Destroy(gameObject);
            }
        }
	}


    private void OnGUI()
    {
        if (distance < TakeDistance)
        {
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2 + 145, 50, 50), TakeText);
        }
    }
}
