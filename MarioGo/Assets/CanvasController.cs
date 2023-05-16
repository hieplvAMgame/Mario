using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CanvasController : MonoBehaviour
{
    public Text txtHp;
    public void ShowHp(int value)
    {
        if (value > 0)
            txtHp.text = value.ToString();
        else
            txtHp.text = "GAME OVER";
    }
}
