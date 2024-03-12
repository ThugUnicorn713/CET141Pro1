using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    [SerializeField] float hitMaxPoints = 100f;
    float hitPoints;

    public Slider healthSlider;

    void Start()
    {
        hitPoints = hitMaxPoints;
    }

    void Hit(float rawDamage)
    {
        hitPoints -= rawDamage;
        SetHealthSlider();

        Debug.Log("OUCH:" + hitPoints.ToString());

        if (hitPoints <= 0)
        {
            OnDeath();
        }
    }

    void SetHealthSlider()
    {
        if (healthSlider != null)
        {
            healthSlider.value = NormalisedHitPoint();

        }
    }

    float NormalisedHitPoint()
    {
        return hitPoints / hitMaxPoints;
    }
   
    void OnDeath()
    {
        Debug.Log("TODO: GAME OVER - YOU DIED....sux");
        GameManager.Instance.GameOver();
    }
}
