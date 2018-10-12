using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public GameObject playerL;
    public GameObject playerR;
    [SerializeField]
    float cameraZ = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 camPos = new Vector3(0, ((playerL.transform.position.y + playerR.transform.position.y) / 2), cameraZ);
        Camera.main.transform.position = camPos;
        //float camRectW = Mathf.Abs(1.5f + (playerL.transform.position.x + playerR.transform.position.x) / 2 );
        float camRectH = (Mathf.Abs(Mathf.Abs(playerL.transform.position.y) - Mathf.Abs(playerR.transform.position.y)))/9;

        //Vector2 camS = new Vector2(6f, 6f);

        Camera.main.orthographicSize = 10f + camRectH;
	}
}
