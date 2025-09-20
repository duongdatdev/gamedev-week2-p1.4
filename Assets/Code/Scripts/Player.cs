using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 20f;       // tốc độ bay
    public float rotationSpeed = 50f;   // tốc độ xoay

    void Update()
    {
        // Di chuyển luôn về phía trước
        transform.position += transform.forward * (moveSpeed * Time.deltaTime);

        // Lấy input
        float yaw = Input.GetAxis("Horizontal"); // xoay trái/phải (A/D)
        float pitch = -Input.GetAxis("Vertical"); // ngóc/lộn (W/S)
        float roll = 0f;

        if (Input.GetKey(KeyCode.Q)) roll = 1f;   // nghiêng trái
        if (Input.GetKey(KeyCode.E)) roll = -1f;  // nghiêng phải

        // Áp dụng xoay
        Vector3 rotation = new Vector3(pitch, yaw, roll) * (rotationSpeed * Time.deltaTime);
        transform.Rotate(rotation, Space.Self);
    }
}
