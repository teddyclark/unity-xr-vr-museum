using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) {
            if (Input.touchCount == 2) {
                transform.Translate(new Vector3(-1 * Camera.main.transform.forward.x, 0, Camera.main.transform.forward.z) * Time.deltaTime * speed, Space.World);
            } else {
                transform.Translate(new Vector3(Camera.main.transform.forward.x, 0, Camera.main.transform.forward.z) * Time.deltaTime * speed, Space.World);
            }
        
        }

        // rotate on right/middle click (for testing)
        if (Input.GetMouseButton(1)) {
            transform.Rotate(Vector3.up * Time.deltaTime * 20, Space.Self);
        }
        if (Input.GetMouseButton(2)) {
            transform.Rotate(Vector3.down * Time.deltaTime * 20, Space.Self);
        }
    }
}
