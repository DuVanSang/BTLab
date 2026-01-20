using UnityEngine;

public class TestDamage : MonoBehaviour
{
    public PlayerHealth playerHealth;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("H pressed");
            playerHealth.TakeDamage(10);
        }
    }
}
