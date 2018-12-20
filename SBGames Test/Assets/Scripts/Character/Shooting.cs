using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public Weapon primary, secondary;

    public GameObject barrel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        keyCallback();
		
	}


    void keyCallback()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            GameObject mockPlayer = new GameObject() ;
            mockPlayer.transform.position = new Vector3(barrel.transform.position.x, barrel.transform.position.y);
            mockPlayer.transform.rotation = new Quaternion(barrel.transform.rotation.x, barrel.transform.rotation.y, barrel.transform.rotation.z, barrel.transform.rotation.w);

            primary.shoot(mockPlayer.transform);

            Destroy(mockPlayer);


        }

        if (Input.GetKey(KeyCode.Mouse1))
        {
            GameObject mockPlayer = new GameObject();
            mockPlayer.transform.position = new Vector3(barrel.transform.position.x, barrel.transform.position.y);
            mockPlayer.transform.rotation = new Quaternion(barrel.transform.rotation.x, barrel.transform.rotation.y, barrel.transform.rotation.z, barrel.transform.rotation.w);

            secondary.shoot(mockPlayer.transform);

            Destroy(mockPlayer);

        }

    }

}
