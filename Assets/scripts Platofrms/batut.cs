using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
            Application.LoadLevel(Application.loadedLevel);


        if (collision.gameObject.tag == "onPlatform")
        {
            this.transform.parent = collision.transform;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "onPlatform")
        {
            this.transform.parent = null;
        }
    }
}