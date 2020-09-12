using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    void LateUpdate()
    {
        var h = Input.GetAxisRaw("Horizontal");
        var v = Input.GetAxisRaw("Vertical");
        var animator = GetComponent<Animator>();
        animator.rootPosition = animator.rootPosition + new Vector3(h, v);

        if (Input.GetButtonDown("Fire1"))
        {
            GetComponent<SpriteRenderer>().color = Color.black;
        }
    }
}
