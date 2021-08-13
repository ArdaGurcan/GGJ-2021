using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    public bool selected = false;
    public bool found = false;
    void Start()
    {
        //transform.Rotate(Vector3.forward, Random.Range(-5, 5));
    }

    //private void OnCollisionStay2D(Collider2D other)
    //{
    //    Destroy(gameObject);
    //}

    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    Destroy(gameObject);
    //}

    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log(collision.gameObject);
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        if(selected)
        {
            found = true;
        }
    }
}
