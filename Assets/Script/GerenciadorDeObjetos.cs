using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorDeObjetos : MonoBehaviour
{

    [SerializeField]
    private GameObject _BacalhauDeMurrayPrefab ;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RotinaGeracaoInimigo());
    }

   IEnumerator RotinaGeracaoInimigo()
    {
        while ( 1==1 )
        {
            Instantiate(_BacalhauDeMurrayPrefab, new Vector3(Random.Range( 9.05f,-15f), -9.05f, 85f),Quaternion.identity);
            yield return new WaitForSeconds(6);
        }        


    }


}