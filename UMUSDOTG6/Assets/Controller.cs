using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float ClockRotation = Input.GetAxis("rotateClock");
        float CounterClockRotation = Input.GetAxis("rotateCounterClock");
       

        if(ClockRotation!=0 && CounterClockRotation != 0)
        {
            rb.AddForce(speed * transform.up);

            if (GetComponent<ParticleSystem>().isStopped)
            {
                GetComponent<ParticleSystem>().Play();
            }

        }
        else if (ClockRotation != 0)
        {
            rb.angularVelocity=-rotationSpeed;
            GetComponent<ParticleSystem>().Stop();
        }
        else if(CounterClockRotation != 0)
        {
            rb.angularVelocity=rotationSpeed;
            GetComponent<ParticleSystem>().Stop();
        }
        else
        {
            GetComponent<ParticleSystem>().Stop();

        }

    }
}
