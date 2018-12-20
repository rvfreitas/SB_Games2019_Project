using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Vector2 moveTemp;
    public Vector2 move;

    public float x, y;

    public bool holdMode;

    public float force, forceMax;

    public Rigidbody2D rb;


    // Use this for initialization
    void Start()
    {
        rb = this.transform.gameObject.GetComponent<Rigidbody2D>();
        

    }

    // Update is called once per frame
    void Update()
    {
        KeyCallback();
        Move();

    }

    void KeyCallback()
    {

        if (holdMode)
        {
            if (Input.GetKey(KeyCode.W))
            {
                y += force * Time.deltaTime;

                if (y > forceMax)
                {
                    y = forceMax;
                }

            }

            if (Input.GetKeyUp(KeyCode.W))
            {

                moveTemp.y = y;
                y = 0;

            }

            if (Input.GetKey(KeyCode.S))
            {
                y -= force * Time.deltaTime;

                if (y <- forceMax)
                {
                    y = -forceMax;
                }

            }

            if (Input.GetKeyUp(KeyCode.S))
            {

                moveTemp.y = y;
                y = 0;

            }

            if (Input.GetKey(KeyCode.D))
            {
                x += force * Time.deltaTime;

                if (x > forceMax)
                {
                    x = forceMax;
                }

            }

            if (Input.GetKeyUp(KeyCode.D))
            {

                moveTemp.x = x;
                x = 0;

            }

            if (Input.GetKey(KeyCode.A))
            {
                x -= force * Time.deltaTime;

                if (x <- forceMax)
                {
                    x = -forceMax;
                }

            }

            if (Input.GetKeyUp(KeyCode.A))
            {

                moveTemp.x = x;
                x = 0;

            }



        }

    }

    void Move()
    {

        move = moveTemp;
        rb.AddForce(move);

        move.Set(0, 0);
        moveTemp.Set(0, 0);



    }

}
