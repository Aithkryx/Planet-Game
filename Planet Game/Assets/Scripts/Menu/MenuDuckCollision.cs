using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuDuckCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        MenuDuckAnim.isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        MenuDuckAnim.isGrounded = false;
    }
}
