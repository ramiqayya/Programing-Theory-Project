using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMotion : MonoBehaviour
{
    public float xRange;
    public float zRange;
    public float enemySpeed=10;
    Rigidbody enemyRb;
    // Start is called before the first frame update
    void Start()
    {
        
        enemyRb = gameObject.GetComponent<Rigidbody>();
        InvokeRepeating("EnemyRandomMotion", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void EnemyRandomMotion()
    {
        xRange = Random.Range(-10, 10);
        zRange = Random.Range(-10, 10);

        enemyRb.AddForce(xRange, 0, zRange, ForceMode.Impulse);

        //transform.Translate(Vector3.back*enemySpeed*xRange*Time.deltaTime);
        //transform.Translate(Vector3.right* enemySpeed*xRange*Time.deltaTime);

    }
}
