using UnityEngine;

public class RotationScript : MonoBehaviour
{
    public Transform centralObject; 
    public float orbitSpeed = 10f;  
    private bool isClockwise = true; 

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isClockwise = !isClockwise;
        }

        float direction = isClockwise ? 1f : -1f;

        transform.RotateAround(centralObject.position, Vector3.up, direction * orbitSpeed * Time.deltaTime);
    }
}
