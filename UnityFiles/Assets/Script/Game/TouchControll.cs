using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControll : MonoBehaviour
{

    public Rigidbody2D rb2D;
    public float Speed;
    private Vector2 touchOrigin = Vector2.one;

    private void Start()
    {
        rb2D.GetComponent<Rigidbody2D>();
    }

    void Update()
    {


        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 Movement = new Vector3(moveHorizontal, moveVertical, 0.0f) * Speed * Time.deltaTime;
            ;
        rb2D.velocity = Movement * Speed;

        if (Input.touchCount > 0)
        {
            Touch myTouch = Input.touches[0];
            if(myTouch.phase == TouchPhase.Began)
            {
                touchOrigin = myTouch.position;
            }
            else if(myTouch.phase == TouchPhase.Ended && touchOrigin.x >= 0)
            {
                Vector2 touchEnd = myTouch.position;
                float x = touchEnd.x - touchOrigin.x;
                float y = touchEnd.y - touchOrigin.y;
                touchOrigin.x = -1;
                if (Mathf.Abs(x) > Mathf.Abs(y))
                {
                    moveHorizontal = x > 0 ? 1 : -1;
                }
                else
                    moveVertical = y > 0 ? 1 : -1;
            
            }
        }
    }
}
