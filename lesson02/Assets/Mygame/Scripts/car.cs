using System.Collections;
using UnityEngine;

public class car : MonoBehaviour
{
    public float speed = 10f;
    public Transform[] points;
    private int Curr;
    public float speedHorizontal = 10;
    public float speedVertical = 10;

    public enum Mode
    {
        Automatic,
        Manual
    }
    public Mode mode;

    void Start()
    {
        Debug.Log("bat dau ");
    }

    void Update()
    {
        if (mode == Mode.Automatic)
        {
            if (Vector3.Distance(transform.position, points[Curr].position) < 0.3f)
            { Curr++; }
            if (Curr >= points.Length)
            { Curr = 0; }
            transform.position = Vector3.MoveTowards(transform.position, points[Curr].position, Time.deltaTime * speed);
            transform.LookAt(points[Curr].position);
        }
        else if (mode == Mode.Manual)         
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            transform.Translate(0, 0, v * speedVertical * Time.deltaTime);
            transform.Rotate(Vector3.up * h * speedHorizontal * Time.deltaTime);
        }
    }
}
