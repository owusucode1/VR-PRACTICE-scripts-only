using UnityEngine;

public class YRotation : MonoBehaviour
{
    //private float rotationFactor = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(Vector3.up * 50f * Time.deltaTime);
    }
}
