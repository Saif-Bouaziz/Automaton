using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetdo1 : MonoBehaviour

{
    [SerializeField]
    private textlogCdo logControl1;

    public void key_pressed()
    {
        logControl1.delete_all();
    }

}