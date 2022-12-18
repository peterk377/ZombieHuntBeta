using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baricade : Interactable
{
    
    protected override void Interact()
    {
        Destroy(gameObject);
    }

    public void DestroyBaricade()
    {
        Destroy(gameObject);
    }
}
