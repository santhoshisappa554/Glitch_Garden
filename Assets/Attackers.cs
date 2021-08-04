using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attackers : MonoBehaviour
{
    [Range(-2f, 2f)]
    public float LizardWalkSpeed;
    Animator Lizardanim;
    SpriteRenderer lizardSprite;
    public GameObject currentObject;
    public float currentdamage=10.0f;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = gameObject.AddComponent<Rigidbody2D>();
        Lizardanim = GetComponent<Animator>();
        lizardSprite = GetComponent<SpriteRenderer>();
        rb.isKinematic = true;

    }

    // Update is called once per frame
    void Update()
    {
       
        if (LizardWalkSpeed > 0) 
        {
            lizardSprite.flipX = false;
            Lizardanim.SetFloat("Walking",LizardWalkSpeed);
            transform.Translate(Vector3.left * LizardWalkSpeed * Time.deltaTime);
        }
        if (LizardWalkSpeed==0)
        {
            if(!Lizardanim.enabled)
            Lizardanim.Play("Appear");
            //transform.Translate(Vector3.left * LizardWalkSpeed * Time.deltaTime);
        }
        if (LizardWalkSpeed < 0)
        {
            lizardSprite.flipX = true;
            Lizardanim.SetFloat("Walking", LizardWalkSpeed);
            transform.Translate(Vector3.left * LizardWalkSpeed * Time.deltaTime);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("triggered with" + name);
        StrikeCurrentTarget(currentdamage);
    }
    public void SetSpeed(float speed)
    {
        LizardWalkSpeed = speed;
    }
    public void StrikeCurrentTarget(float currentdamage)
    {
        Debug.Log(currentdamage+" Damage is " + name);
        GameObject.FindObjectOfType<Health>().HealthDamage(currentdamage);

        /*if (currentObject)
        {
           Health health=currentObject.GetComponent<Health>();
            if (health)
            {
                health.HealthDamage(currentdamage);
            }
        }*/
      



    }
    public void Attack(GameObject obj)
    {
        currentObject = obj;
    }
}
