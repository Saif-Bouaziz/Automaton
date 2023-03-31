using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resett : MonoBehaviour

{
    [SerializeField]
    private TextLogControle1 logControl1;

    public void key_pressed()
    {
        logControl1.delete_all();
    }

}