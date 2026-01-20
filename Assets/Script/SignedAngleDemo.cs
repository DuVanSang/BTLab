using UnityEngine;
using TMPro;

public class SignedAngleDemo : MonoBehaviour
{
    [Header("Settings")]
    public Transform target;              // Target (nếu không dùng chuột)
    public bool useMouse = false;          // Bật để xoay theo chuột
    public TextMeshProUGUI uiText;         // UI hiển thị góc

    void Update()
    {
        // 1. Xác định vị trí mục tiêu
        Vector3 targetPosition;

        if (useMouse)
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPosition.z = 0f;
        }
        else
        {
            if (target == null) return;
            targetPosition = target.position;
        }

        // 2. Vector từ Player tới mục tiêu
        Vector2 direction = targetPosition - transform.position;

        // 3. Tính SignedAngle (cốt lõi của Lab 4)
        // Vector2.up là hướng mặc định của sprite
        float signedAngle = Vector2.SignedAngle(Vector2.up, direction);

        // 4. Xoay Player theo SignedAngle
        transform.rotation = Quaternion.Euler(0f, 0f, signedAngle);

        // 5. Lấy góc xoay hiện tại (chuyển về -180 → 180)
        float currentZ = transform.eulerAngles.z;
        if (currentZ > 180f)
            currentZ -= 360f;

        // 6. Hiển thị UI (có âm / dương)
        if (uiText != null)
        {
            uiText.text = $"Rotation Z: {currentZ:F2}°";

            // Màu trực quan
            if (currentZ > 0)
                uiText.color = Color.green;
            else if (currentZ < 0)
                uiText.color = Color.red;
            else
                uiText.color = Color.white;
        }

        // 7. Debug trực quan (ăn điểm)
        Debug.DrawRay(transform.position, Vector2.up * 2f, Color.blue); // Hướng gốc
        Debug.DrawRay(transform.position, direction, Color.yellow);    // Hướng mục tiêu
    }
}
