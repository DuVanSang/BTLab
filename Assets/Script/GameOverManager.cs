using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject gameOverUI;

    void OnEnable()
    {
        playerHealth.OnPlayerDead += ShowGameOver;

    }

    void OnDisable()
    {
        playerHealth.OnPlayerDead -= ShowGameOver;

    }

    void ShowGameOver()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }
}
