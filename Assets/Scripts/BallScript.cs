using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallScript : MonoBehaviour
{
    //Vars
    protected Rigidbody rb;

    [SerializeField] protected int worldVelocity = 25;

    [SerializeField] protected Vector3 startForce = Vector3.one;

    //Awake
    //Start
    //OnEnable


    //Methods
    private void OnEnable()
    {
        rb = gameObject.GetComponent<Rigidbody>();

        ApplyStartForce();
    }

    private void FixedUpdate()
    {
        LimitBallVellocity();
    }

    protected void ApplyStartForce()
    {
        rb.AddForce(startForce, ForceMode.Impulse);
    }

    protected void LimitBallVellocity()
    {
        Vector3 hV3 = rb.velocity;

        Vector3 nV3 = Vector3.zero;

        nV3.x = Mathf.Clamp(hV3.x, -worldVelocity, worldVelocity);
        nV3.y = Mathf.Clamp(hV3.y, -worldVelocity, worldVelocity);
        nV3.z = 0;

        rb.velocity = nV3;
    }
    
}
