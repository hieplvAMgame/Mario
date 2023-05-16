using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour, ICharacter
{
    public int Hp { get; set; }
    public int Damage { get; set; }
    public float Speed { get; set; }
    public float JumpForce { get ; set ; }

    public bool isGrounded = true;      // check nhan vat co cham dat hay khong

    public CanvasController canvas;
    private void Awake()
    {
        Hp = 6;
    }
    public void Attack()
    {
        // code movement control
        //Shoot bullet - truyen attack vao cho bullet khi spawn
    }

    public void GetDame(int amount)
    {
        Hp -= amount;
        canvas.ShowHp(Hp);
        if (Hp<0)
        {
            // Xu ly khi player die (show anim, show UI, ...)
        }
    }
    
    public void Jump()
    {
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            // code player jump
        }
    }
    public void Movement()
    {
        // xu ly input
        // di chuyen nhan vat
    }
}
