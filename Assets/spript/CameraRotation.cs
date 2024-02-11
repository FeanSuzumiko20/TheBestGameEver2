using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
        public float MinAngle;
        public float MaxAngle;
        public Transform CameraAxisTransform;
        public float SpeedRotation;
    void Update()
    {
        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y + Time.deltaTime * SpeedRotation * Input.GetAxis("Mouse X"), 0);
        var newAngleX = CameraAxisTransform.localEulerAngles.x - Time.deltaTime * SpeedRotation * Input.GetAxis("Mouse Y");
        if (newAngleX > 180)
            newAngleX -= 360;
        newAngleX = Mathf.Clamp(newAngleX, MinAngle, MaxAngle);
        CameraAxisTransform.localEulerAngles = new Vector3(newAngleX, 0, 0);
    }
}
