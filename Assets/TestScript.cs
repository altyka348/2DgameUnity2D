using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    private Animation Anime2D;

    float Speed = 0;

    public AnimationClip PlayerMove;
    public AnimationClip PlayerRightMove;
    public AnimationClip PlayerBackMove;
    public AnimationClip PlayerLeftMove;


    // Start is called before the first frame update
    void Start()
    {
        Anime2D = GetComponent<Animation>();

    }

    // Update is called once per frame
    void Update()
    {
       // if (Input.GetKeyDown(KeyCode.A))
        //{
            //StartCoroutine("PlayerMove");
        //}
        if (Input.GetKeyDown(KeyCode.B))
        {
            Anime2D.Play("PlayerRightMove");
        }
    }
}
