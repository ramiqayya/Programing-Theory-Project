using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMotion : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    [SerializeField] private float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.left *verticalInput *speed *Time.deltaTime);

        transform.Translate(Vector3.forward*horizontalInput*speed *Time.deltaTime);
    }
}
