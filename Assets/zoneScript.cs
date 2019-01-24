using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoneScript : MonoBehaviour {

    public bool zoneEntered;

    private void OnTriggerEnter2D(Collider2D collision)
    {       
            zoneEntered = true;
    }
    
}
