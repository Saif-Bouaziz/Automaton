using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAll : MonoBehaviour

{
    [SerializeField]
    public TextC logControl1;

    public void key_pressed()
    {
        logControl1.delete_all();
    }

}