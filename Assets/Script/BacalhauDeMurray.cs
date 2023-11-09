using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacalhauDeMurray : MonoBehaviour
{
    private float _velocidade = 6.0f;
    // Start is called before the first frame update
    void Start()
    {
      
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * _velocidade * Time.deltaTime);
        if ( transform.position.x < -20.75f)
        {
             transform.position = new Vector3(7.5f, UnityEngine.Random.Range( -7f, 7f), 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if ( other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();

            if (player != null)
            {
                player.DanoAoPlayer();
            }
        }
    }
}
