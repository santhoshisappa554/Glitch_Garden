using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health=100.0f;
    
    public void HealthDamage(float damage)
    {
        health -= damage;
        Debug.Log(health);
        if (health < 0)
        {
            DestroyObject();
        }
    }
    private void  DestroyObject()
    {
        Destroy(gameObject);
    }
}
