using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clean : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Roflani")
        {
            Destroy(this.gameObject);
        }
    }
    }
