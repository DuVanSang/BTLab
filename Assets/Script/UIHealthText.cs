using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthText : MonoBehaviour
{
    public TextMeshProUGUI healthText;

    void Start()
    {
        if (healthText == null)
        {
            Debug.LogError("HealthText chưa được gán trong Inspector!", this);
        }
    }

    public void UpdateHealthText(int value)
    {
        if (healthText == null) return;
        
        healthText.text = "HP: " + value;
    }
}