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
            Debug.Log("TODO: GAME OVER - YOU DIED...sux");
        }
    }

    void SetHealthSlider()
    {
        if (healthSlider != null)
        {
            healthSlider.value = NormalisedHitPoints();

        }
    }

    float NormalisedHitPoints()
    {
        return hitPoints / hitMaxPoints;
    }
   
}
