using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 3.0f;
    public float jumpSpeed = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateControl();
    }

    void UpdateControl()
    {
        var horizontal = Input.GetAxis("Horizontal");

        var jump = Input.GetButtonDown("Jump");

        Vector3 move = Vector3.zero;

        move.x = horizontal * speed;

        if (jump)
        {
            move.y = jumpSpeed;
        }

        transform.Translate(move * Time.deltaTime);

    }
}
