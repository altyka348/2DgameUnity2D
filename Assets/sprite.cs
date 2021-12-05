using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprite : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject go = new GameObject("Square");
        go.AddComponent<SpriteRenderer>();

        SpriteRenderer renderer = go.GetComponent<SpriteRenderer>();

        renderer.sprite = Resources.Load<Sprite>("Sample.png");

        renderer.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
