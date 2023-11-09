using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade = 0.0f ;
    public float entradaHorizontal ;
    public float entradaVertical ;
    public int vidas = 3;

   // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start de "+this.name);
        velocidade = 3.0f ;
        transform.position = new Vector3(0,0,0);
    }

    void Update()
    {
        entradaHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*velocidade*entradaHorizontal);

        if ( transform.position.x  > 9.85f) 
        {
            transform.position = new Vector3(-9.85f,transform.position.y,0);
        }

        if ( transform.position.x  < -9.85f  ) 
        {
            transform.position = new Vector3(9.85f,transform.position.y,0);
        }

        entradaVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up*Time.deltaTime*velocidade*entradaVertical);

        if ( transform.position.y  > 7.95f ) 
        {
            transform.position = new Vector3(transform.position.x,0,0);
        }

        if ( transform.position.y  < -3.95f  ) 
        {
            transform.position = new Vector3(transform.position.x,-3.95f,0);
        }
    }

    public void DanoAoPlayer()
    {
        // vidas = vidas - 1;
        vidas--;

        if ( vidas < 1 )
        {
            Destroy(this.gameObject);
        }
        

    }
}