using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public Transform block;

    // Start is called before the first frame update
    void Start()
    {
        for (var x = 0; x < 5; x++)
        {
            Instantiate(block, new Vector3(transform.position.x + x, transform.position.y, transform.position.z), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
