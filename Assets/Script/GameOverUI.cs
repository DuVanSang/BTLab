using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject gameOverPanel;

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
        Debug.Log("GAME OVER");
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }
}
