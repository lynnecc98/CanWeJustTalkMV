using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public float outLoc;
    public float inLoc;
    public float zoomSpd;

    public bool zoomed;
    private Transform t;
    private Rigidbody rb;
    private Canvas c;
    // Start is called before the first frame update
    void Start()
    {
        zoomed = false;
        t = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        c = FindObjectOfType<Canvas>();
        c.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (zoomed == true && t.localPosition.z < inLoc)
        {
            rb.velocity = Vector3.forward * zoomSpd;
        }
        else if (zoomed == false && t.localPosition.z > outLoc)
        {
            rb.velocity = Vector3.back * zoomSpd;
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
        if (t.localPosition.z < outLoc)
        {
            t.localPosition = new Vector3(t.localPosition.x, t.localPosition.y, outLoc);
        }
        else if (t.localPosition.z > inLoc)
        {
            t.localPosition = new Vector3(t.localPosition.x, t.localPosition.y, inLoc);
        }
    }
}
