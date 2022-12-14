using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    public float speed = 3.0f;
    
    public int maxHealth = 5;
    int currentHealth;
    
    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;


    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D >();

        currentHealth = maxHealth;
    }

    void Update()
    {
        //create variables to use the built in axis 
        horizontal = Input.GetAxis("Horizontal");
         vertical = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {   //create a movement vector
        Vector2 position = transform.position;
        //make horizontal and vertical movement work
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(position);
    }
     
    
    void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);

        Debug.Log(currentHealth + "/" + maxHealth);
    }
}