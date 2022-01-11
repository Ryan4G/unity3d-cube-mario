using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationZ;

    // Start is called before the first frame update
    void Start()
    {
        rotationZ = 0;
    }

    // Update is called once per frame
    void Update()
    {
        rotationZ += Time.deltaTime * 10;

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, rotationZ));
    }
}
