using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectstate : MonoBehaviour
{
    public float movespeed = 4f;
    [SerializeField] private Vector3 reposition;
    [SerializeField] private Vector3 lastposition;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
     protected virtual void Update()
    {
        if (!gamemanager.instance.GameOver && gamemanager.instance.Playerentered && gamemanager.instance.PlayerActive)
        {
            transform.Translate(new Vector2(movespeed * Time.deltaTime, 0));

            if (transform.position.x > lastposition.x)
            {
                transform.position = reposition;
            }
        }
        

    }
    
    


    

}
