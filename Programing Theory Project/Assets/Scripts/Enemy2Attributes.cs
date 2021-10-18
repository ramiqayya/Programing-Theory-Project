using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Attributes : EnemyMotion //INHERITANCE
{
    private Rigidbody enemy2Rb;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        enemy2Rb = gameObject.GetComponent<Rigidbody>();
        InvokeRepeating("EnemyRandomMotion", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.transform);
    }

    public override void EnemyRandomMotion()//POLYMORPHISM
    {
        xRange = Random.Range(-10, 10);
        zRange = Random.Range(-10, 10);

        enemy2Rb.AddForce(xRange, 0, zRange, ForceMode.Impulse);
    }
}
