using UnityEngine;

public class LifecycleLogger : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("1. Awake: Được gọi khi script instance được load (dù script chưa enable).");
    }

    private void OnEnable()
    {
        Debug.Log("2. OnEnable: Được gọi mỗi khi object/script được Active.");
    }

    private void Start()
    {
        Debug.Log("3. Start: Được gọi trước frame update đầu tiên (chỉ 1 lần).");
    }

    private void FixedUpdate()
    {
        // Chú ý: Hàm này chạy theo tần suất vật lý (mặc định 0.02s)
        // Debug.Log("FixedUpdate: Physics step."); 
    }

    private void Update()
    {
        // Debug.Log("Update: Frame update.");
    }

    private void LateUpdate()
    {
        // Debug.Log("LateUpdate: Chạy sau khi tất cả Update đã xong.");
    }

    private void OnDisable()
    {
        Debug.Log("4. OnDisable: Được gọi khi object/script bị Inactive.");
    }

    private void OnDestroy()
    {
        Debug.Log("5. OnDestroy: Được gọi khi object bị hủy hoàn toàn.");
    }
}