using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    public float rotationSpeed = 30f; // Скорость вращения куба

    void Update()
    {
        // Вращение куба вокруг оси Y
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
