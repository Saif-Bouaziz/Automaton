using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    [SerializeField]
    public TextC logControl2;

    public void key_pressed1()
    {
        logControl2.delete_last();
    }
}
