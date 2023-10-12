using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Soccer Ball";
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3 (0, 0, .5f));
    }
}
