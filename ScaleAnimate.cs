using UnityEngine;

public class ScaleAnimate : MonoBehaviour
{
    public float minScale = 0.5f;
    public float maxScale = 1.2f;
    public float scaleFrequence = 2;

    private Vector3 initalScale;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       initalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = initalScale * updatedScale(minScale, maxScale, scaleFrequence);
    }

    private float updatedScale(float min, float max, float freq)
    {
        float updatedScaleFactor = Mathf.Lerp(min, max, (Mathf.Sin(Time.time * freq) + 1.0f) / 2.0f);
        return updatedScaleFactor;
    }
}
