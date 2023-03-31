using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backdo1 : MonoBehaviour
{
    [SerializeField]
    private textlogCdo logControl2;

    public void key_pressed1()
    {
        logControl2.delete_last();
    }
}