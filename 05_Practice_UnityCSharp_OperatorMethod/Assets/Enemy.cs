using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Attack(int a)
    {
        a -= 10;
        return a;
    }

    public int Heal(int b)
    {
        b += 10;
        return b;
    }
}
