using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CastleController : MonoBehaviour
{
    public float StartHealth;
    public float Health;

    public Image HealthBar;

    void Start()
    {
        Health = StartHealth;
    }

    public void TakeDamage(float amount)
    {
        Health -= amount;
        HealthBar.fillAmount = Health / StartHealth;
        if (Health <= 0)
        {
            CastleDestroyed();
        }
    }

    void CastleDestroyed()
    {
        Destroy(gameObject);
    }
}
