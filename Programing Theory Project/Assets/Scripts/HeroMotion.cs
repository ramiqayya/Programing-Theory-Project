using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMotion : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    [SerializeField] private float speed = 10;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        HeroControls();//ABSTRACTION
    }

    private void HeroControls()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.left * verticalInput * speed * Time.deltaTime);

        transform.Translate(Vector3.forward * horizontalInput * speed * Time.deltaTime);
    }
}
