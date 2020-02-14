using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldDeathTrigger : MonoBehaviour
{

    
    public Transform spawn = null;
    public CharacterController player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        player.enabled = false;
        other.transform.position = spawn.position;
        player.enabled = true;
    }
}//End of Script

