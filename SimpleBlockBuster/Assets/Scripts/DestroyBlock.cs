using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlock : MonoBehaviour
{
    [SerializeField] private int hitsBeforeDestroyed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Function for destroying the blocks, hits required for destruction are set in the editor on prefabs
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("all"))
        {
            hitsBeforeDestroyed--;

            if(hitsBeforeDestroyed == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
