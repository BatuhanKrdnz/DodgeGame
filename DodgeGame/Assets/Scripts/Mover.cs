using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //[SerializeField] float fly = 0.03f;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       MovePlayer();
    }

    void MovePlayer()
    {
         float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float fly = Input.GetAxis("Jump") * jumpSpeed;
        transform.Translate(xValue,fly * Time.deltaTime ,zValue);
    }
}
