using UnityEngine;
using System;

public class ClockMovement : MonoBehaviour
{
    [SerializeField] Transform HourHandRotation, MinutesHandRotation, SecondHandRotation;
    const float hourDegree = 30f, secondDegree = 6f, minutesDegree = 6f;
    
   

    // Update is called once per frame
    void Update()
    {
        ClockAnimator();
    }

    void ClockAnimator()
    {
        DateTime time = DateTime.Now;
        HourHandRotation.localRotation = Quaternion.Euler(hourDegree * time.Hour, 0, 0);
        MinutesHandRotation.localRotation = Quaternion.Euler(minutesDegree * time.Minute, 0, 0);
        SecondHandRotation.localRotation = Quaternion.Euler(secondDegree * time.Second, 0, 0);
    }
}
