using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
         PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to my stupid game");
        Debug.Log("Press WASD to move");
    }


    void MovePlayer()
    {
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;

        transform.Translate(xValue,0,zValue); 
    }

 
}
