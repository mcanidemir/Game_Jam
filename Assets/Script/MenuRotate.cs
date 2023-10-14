using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuRotate : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 Rotation_Speed = new Vector3(0, 0, 1);
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Rotation_Speed);
    }
}
