using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Define;

public class MonsterController : CreatureController
{
    protected override void Init()
    {
        base.Init();
    }

    protected override void UpdateController()
    {
        //GetDirInput();
        base.UpdateController();
    }

    void GetDirInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Dir = MoveDir.Up;
            //transform.position += Vector3.up * Time.deltaTime * _speed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Dir = MoveDir.Down;
            //transform.position += Vector3.down * Time.deltaTime * _speed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Dir = MoveDir.Left;
            //transform.position += Vector3.left * Time.deltaTime * _speed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Dir = MoveDir.Right;
            //transform.position += Vector3.right * Time.deltaTime * _speed;
        }
        else
        {
            Dir = MoveDir.None;

        }
    }
}
