using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Attributes : EnemyMotion
{
    private Rigidbody squareRb;
    private float jump = 10;
    // Start is called before the first frame update
    void Start()
    {
        squareRb = gameObject.GetComponent<Rigidbody>();
        
        InvokeRepeating("EnemyRandomMotion", 1, 2);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    public override void EnemyRandomMotion()
    {
        
        xRange = Random.Range(-10, 10);
        zRange = Random.Range(-10, 10);

        squareRb.AddForce(xRange, 0, zRange, ForceMode.Impulse);
        Jump();

    }

    private void Jump()
    {
        squareRb.AddForce(Vector3.up * jump, ForceMode.Impulse);
    }

}
