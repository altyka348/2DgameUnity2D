using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rigidbody2d : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        GameObject go = new  GameObject("go");
        go.AddComponent<Rigidbody2D>();




        Rigidbody2D rigidbody2d = go.GetComponent<Rigidbody2D>();

        rigidbody2d.mass = 20;

        rigidbody2d.drag = 2;

        rigidbody2d.angularDrag = 0.03f;

        rigidbody2d.gravityScale = 2;

        rigidbody2d.fixedAngle = true;

        rigidbody2d.isKinematic = true;

        rigidbody2d.interpolation = RigidbodyInterpolation2D.Extrapolate;



        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
