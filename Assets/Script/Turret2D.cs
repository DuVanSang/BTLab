using UnityEngine;

public class Turret2D : MonoBehaviour
{
    public Transform target;
    public float rotationSpeed = 5f;
    public bool useSmooth = true;

    void Update()
    {
        if (target == null) return;

        // 1. Tính toán hướng từ Turret tới Target
        Vector2 direction = target.position - transform.position;

        // 2. Tính góc quay (Atan2 trả về radian, cần đổi sang độ)
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        // Lưu ý: Nếu sprite mặc định hướng lên thì trừ đi 90 độ (angle - 90)

        Quaternion targetRotation = Quaternion.Euler(0, 0, angle);

        if (useSmooth)
        {
            // Xoay mượt (Slerp hoặc RotateTowards)
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
        else
        {
            // Xoay trực tiếp (Instant)
            transform.rotation = targetRotation;
        }
    }
}