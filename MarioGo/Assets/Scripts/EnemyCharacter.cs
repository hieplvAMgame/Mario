using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCharacter : MonoBehaviour, ICharacter
{
    public int Hp { get ; set ; }
    public int Damage { get; set ; }
    public float Speed { get ; set; }
    public float JumpForce { get; set; }

    public void Attack()
    {
        Shoot();
    }
    private void Shoot()
    {
        // spawn bullet
        // toc do ban dan
        // so dan ban trong 1 lan
        // toc do nap dan

    }
    public void GetDame(int amount)
    {
        
    }

    public void Jump()
    {

    }

    public void Movement()
    {
       
    }
}
