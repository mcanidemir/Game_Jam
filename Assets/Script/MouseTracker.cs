using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTracker : MonoBehaviour
{
    private Transform mouse_transform;
    // Update is called once per frame
    private void Start()
    {
        mouse_transform = this.transform;
    }
    void Update()
    {
        MouseBak();
    }
    private void MouseBak()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - mouse_transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        mouse_transform.rotation = rotation;
    }
}
