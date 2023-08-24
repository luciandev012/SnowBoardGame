using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    Rigidbody2D rb2d;
    [SerializeField] float speedUpAmount = 30f;
    [SerializeField] float normalSpeedAmount = 10f;
    SurfaceEffector2D surfaceEffector;
    bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        surfaceEffector = FindObjectOfType<SurfaceEffector2D>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            SpeedUpPlayer();
            RotatePlayer();
        }
    }
    
    public void StopPlayer()
    {
        canMove = false;
    }
    void SpeedUpPlayer()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector.speed = speedUpAmount;
        }
        else
        {
            surfaceEffector.speed = normalSpeedAmount;
        }
    }
    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
