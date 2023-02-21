using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform2 : MonoBehaviour
{
    [SerializeField] float speed = 3f;

    bool moveingUp = true;

    private void Update()
    {
        if (transform.position.x > 31.58f)
        {
            moveingUp = false;
        }
        else if (transform.position.x < 21.58f)
        {
            moveingUp = true;
        }

        if (moveingUp)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }
}
