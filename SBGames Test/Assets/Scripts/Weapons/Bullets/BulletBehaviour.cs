using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletBehaviour : MonoBehaviour
{


    private void Start()
    {
        
    }

    public void shoot(float force)
    {
        /*  Vector3 direction = new Vector3();
          direction = this.transform.forward * force;
          this.transform.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(direction.x,direction.y));
         */

        //.transform.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(force, force));

        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 direction = mouseWorld - this.gameObject.transform.position;

        
        direction.Normalize();

        this.transform.gameObject.GetComponent<Rigidbody2D>().AddForce(direction * force);

    }
}

