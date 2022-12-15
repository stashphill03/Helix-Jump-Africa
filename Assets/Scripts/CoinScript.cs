using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            //Add 1 to points.
            
            FindObjectOfType<AudioManager>().Play("coin");
            GameManager.score += 15;
            Destroy(gameObject);
        }
    }
}
