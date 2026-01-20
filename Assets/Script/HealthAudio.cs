using UnityEngine;

public class HealthAudio : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public AudioSource audioSource;

    void OnEnable()
    {
        if (audioSource == null)
        {
            Debug.LogError("AudioSource CHƯA ĐƯỢC GÁN!");
        }
        
        playerHealth.OnHealthChanged += PlaySound;
    }

    void OnDisable()
    {
        playerHealth.OnHealthChanged -= PlaySound;
    }

    public void PlaySound(int hp)
    {
        if (audioSource == null) return;

        audioSource.Play();
    }
}
