using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenTrigger : MonoBehaviour
{
	[SerializeField] private Animator myDoor = null;
	//[SerializeField] private bool openTrigger = false;
	//[SerializeField] private bool closeTrigger = false;
	private bool doorOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
    	//show message open door
    }

    private void OnTriggerStay(Collider other){
    	if (Input.GetKeyDown(KeyCode.E) && !doorOpen) {
    			myDoor.Play("DoorOpening", 0, 0.0f);
    			doorOpen = true;

    	} else if (Input.GetKeyDown(KeyCode.E) && doorOpen) {
			myDoor.Play("DoorClosing", 0, 0.0f);
			doorOpen = false;
		}
    }
}
