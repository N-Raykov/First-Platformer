using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    private bool facingRight;

    private PlayerMovement _playerMovement;

    private void Start()
    {
        facingRight = true;
        _playerMovement = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        flip();
    }

    void flip()
    {
        float xSpeed = Input.GetAxisRaw("Horizontal") * _playerMovement._speed * Time.deltaTime;

        if (xSpeed > 0 && !facingRight || xSpeed < 0 && facingRight)
        {
            facingRight = !facingRight;

            float rotation = transform.rotation.eulerAngles.y;

            switch (facingRight)
            {
                case (true):
                    rotation = 0;
                    break;
                case (false):
                    rotation = 180;
                    break;
            }

            transform.eulerAngles = new Vector3(0, rotation, 0);
        }
    }
}
