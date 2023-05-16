using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacter
{
    int Hp { get; set; }
    int Damage { get; set; }
    float Speed { get; set; }
    float JumpForce { get; set; }

    void Movement();
    void Attack();
    void GetDame(int amount);
    void Jump();
}
