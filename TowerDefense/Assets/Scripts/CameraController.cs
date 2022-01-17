using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private bool doMovement = true;

    public float panSpeed = 30f;
    public float panBorderThichness = 10f;

    public float scrollSpeed = 5f;

    public float minY = 10f;
    public float maxY = 60f;

    public float minX = -10;
    public float maxX = 45;
    public float minZ = -50;
    public float maxZ = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            doMovement = !doMovement;
        
        if (!doMovement)
            return;

        Vector3 pos = transform.position;

        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThichness)
        {
            if (pos.z < maxZ)
            {
                transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
            }
        }
        if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThichness)
        {
            if (pos.z > minZ)
            {
                transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
            }
        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThichness)
        {
            if (pos.x < maxX)
            {
                transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
            }
        }
        if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThichness)
        {
            if (pos.x > minX)
            {
                transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
            }
        }

        pos = transform.position;
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y -= scroll * 200 * scrollSpeed * Time.deltaTime;

        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        
        transform.position = pos;
    }
}
