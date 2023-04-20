using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObjMoveDiagonal : MonoBehaviour
{
    Vector3 moveUp = new Vector3(0, 1, 0);
    Vector3 moveDown = new Vector3(0, -1, 0);
    Vector3 moveLeft = new Vector3(-1, 0, 0);
    Vector3 moveRight = new Vector3(1, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //MoveLeftUp();
        //MoveLeftDown();
        //MoveRightUp();
        MoveRightDown();
    }

    void MoveLeftUp()
    {
        MoveLeft(); 
        MoveUp();
    }

    void MoveLeftDown()
    {
        MoveLeft();
        MoveDown();
    }

    void MoveRightUp()
    {
        MoveRight();
        MoveUp();
    }

    void MoveRightDown()
    {
        MoveRight();
        MoveDown();
    }

    void MoveUp()
    {
        transform.position += moveUp * Time.deltaTime;
    }

    void MoveDown()
    {
        transform.position += moveDown * Time.deltaTime;
    }

    void MoveLeft()
    {
        transform.position += moveLeft * Time.deltaTime;
    }

    void MoveRight()
    {
        transform.position += moveRight * Time.deltaTime;
    }
}
