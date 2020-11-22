    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D rgbody;
    public Vector2 jumpForce = new Vector2(0, 200);


    // Start is called before the first frame update
    void Start()
    {
        rgbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            rgbody.velocity = Vector2.zero;
            rgbody.AddForce(jumpForce);

    Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
    if (screenPosition.y > Screen.height || screenPosition.y < 0)
    {
        Die();
    }

        }
        

    }
    void OnCollisionEnter2d(Collision2D other)
    {
    Die();
    }
    
    void Die() 
    {
        Application.LoadLevel(Application.loadedLevel);
    
    }



    
}
