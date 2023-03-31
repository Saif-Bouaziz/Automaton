using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backtuto4 : MonoBehaviour
{
    [SerializeField]
    private textlogCtuto4 logControl2;

    public void key_pressed1()
    {
        logControl2.delete_last();
    }
}