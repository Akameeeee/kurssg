using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move3 : MonoBehaviour
{
    [SerializeField] float speed = 3f;

    bool moveingUp = true;

    private void Update()
    {
        if (transform.position.x > 52.58f)
        {
            moveingUp = false;
        }
        else if (transform.position.x < 42.58f)
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
