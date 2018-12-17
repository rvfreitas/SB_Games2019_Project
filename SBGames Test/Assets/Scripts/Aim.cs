using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour {

    public GameObject aim;

	// Use this for initialization
	void Start () {

        Cursor.visible = false;
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector2 mouseScreen = Camera.main.ScreenToWorldPoint(Input.mousePosition -this.transform.position );
        this.transform.up = mouseScreen;

        aim.transform.position = mouseScreen;
		
	}
}
