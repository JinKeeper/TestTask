using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject ball;
    public float ySpeed = 3.5f;
    public float xSpeed = 3.5f;
    public GameObject upButton;
    public GameObject gameOverScreen;
    private bool buttonPosition = false;

   // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ball.transform.position += Vector3.right * Time.deltaTime * xSpeed;
        if (buttonPosition == true)
        {
            ball.transform.position += Vector3.up * Time.deltaTime * ySpeed;
            print("UP");
        }
        else
        {
            ball.transform.position += Vector3.down * Time.deltaTime * ySpeed;
            print("DOWN");
        }
    }


    public void BallTransformUpButtonDown()
    {
        buttonPosition = true;       
    }

    public void BallTransformUpButtonUp()
    {
        buttonPosition = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("TRIGGERED");
        Destroy(ball);
        Destroy(upButton);
        gameOverScreen.SetActive(true);
    }
}
