using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleScript : MonoBehaviour
{   
    public float rotateSpeed;
    public float freq;
    public float amp;

    private Vector3 startPostion;


    // Start is called before the first frame update
    void Start()
    {
        startPostion = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotateSpeed);
        transform.position = new Vector3(transform.position.x, startPostion.y + Mathf.Sin(Time.fixedTime * Mathf.PI * freq) * amp, transform.position.z);
    }
}
