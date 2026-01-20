using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 moveInput;

    void Update()
    {
        // Lấy input WASD
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // Tạo vector và chuẩn hóa (Normalize)
        moveInput = new Vector2(moveX, moveY).normalized;

        // Di chuyển
        transform.Translate(moveInput * speed * Time.deltaTime);
    }

    // Vẽ Gizmos hướng di chuyển
    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        // Vẽ tia từ vị trí nhân vật theo hướng đang đi
        Gizmos.DrawRay(transform.position, moveInput * 2f);
    }
}