using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(transform.forward); // unit vector to z axis 

        //transform.LookAt(new Vector3(0, 0, 0));
        transform.Rotate(new Vector3(10, 0, 0)); // x축 방향으로 10씩 무한 증가 

    }
}
