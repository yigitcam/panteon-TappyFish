using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMovement : MonoBehaviour
{
    public float speed;
    private BoxCollider2D box;
    private float groundWidht;
    void Start()
    {
        box = GetComponent<BoxCollider2D>();
        groundWidht = box.size.x;
    }

    
    void Update()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        if (transform.position.x <= -groundWidht)
        {
            transform.position = new Vector2(transform.position.x + 2 * groundWidht, transform.position.y);
        }
    }
}
