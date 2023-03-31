using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resettuto4 : MonoBehaviour

{
    [SerializeField]
    private textlogCtuto4 logControl1;

    public void key_pressed()
    {
        logControl1.delete_all();
    }

}