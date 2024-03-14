using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
   
    [SerializeField]
    SpriteRenderer sprite;

    private Rigidbody2D rb;
   
    public bool isRight = true;

    [SerializeField]
    private float speed;

    [SerializeField]
    private float jump;

    private float timeLeft;
    private BoxCollider2D box;

    private Vector3 pointAPosition;
    private Vector3 pointBPosition;

    void Start()
    {
        timeLeft = Random.Range(1, 8);
        pointAPosition = new Vector3(19.8f, 15.8f, 0f);
        pointBPosition = new Vector3(34.5f, 15.8f, 0f);
        rb = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
    }

   
    void Update()
    {
        if(timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        }
        Vector3 max = box.bounds.max;
        Vector3 min = box.bounds.min;

        Vector2 corner1 = new Vector2(max.x, min.y - 0.1f);
        Vector2 corner2 = new Vector2(min.x, min.y - 0.2f);

        Collider2D hit = Physics2D.OverlapArea(corner1, corner2);

        bool grounded = false;
        if (hit != null)
        {
            grounded = true;
        }//end if

        if (grounded && timeLeft <= 0)
        {
            rb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
            timeLeft = Random.Range(1, 8);
        }//end if
        

        Vector3 thisPosition = new Vector3(transform.position.x, 15.8f, 0);
         if (!isRight)
         {
             transform.position = Vector3.MoveTowards(transform.position, pointBPosition, speed);
             if (thisPosition.Equals(pointBPosition))
             {
                 //Position B
                 isRight = true;
                 sprite.flipX = false;
             }
         }
         else
         {
             transform.position = Vector3.MoveTowards(transform.position, pointAPosition, speed);
             if (thisPosition.Equals(pointAPosition))
             {
                 //Position A
                 isRight = false;
                 sprite.flipX = true;
             }
         }
    }//end Update
    
}
