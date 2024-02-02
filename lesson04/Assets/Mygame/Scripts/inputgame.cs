using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputgame : MonoBehaviour

{
    public float speedHorizontal = 10;
    public float speedVertical = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        
        float v = Input.GetAxis("Vertical");

        transform.Translate(0, 0, v * speedVertical * Time.deltaTime);

        transform.Rotate(Vector3.up * h * speedHorizontal * Time.deltaTime);
    }
}
