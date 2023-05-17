using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Image healthbar;
    public int healthAmount;
    [SerializeField] public GameInfo gameInfo;
    // Start is called before the first frame update
    void Start()
    {
        healthAmount = gameInfo.PlayerHPTotal;
    }

    // Update is called once per frame
    public void TakeDamage(int damage)
    {
        healthAmount -= damage;
        healthbar.fillAmount = healthAmount / 100f;
    }

    public void Heal(int healing)
    {
        healthAmount += healing;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100);
        healthbar.fillAmount = healthAmount;
    }
}
