using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defenders : MonoBehaviour
{
    public GameObject projectile,projectileParent;
    void ProjectileFire()
    {
        GameObject tempProjectile=Instantiate(projectile) as GameObject;
        tempProjectile.transform.position = projectileParent.transform.position;
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
    }
}
