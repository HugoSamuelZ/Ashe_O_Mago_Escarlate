using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuvem_movendo : MonoBehaviour
{
    public float velocidade = 0;
    public GameObject Jogador;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NuvemVelocidade();
    }

    void NuvemVelocidade()
    {
        transform.position = new Vector3(transform.position.x + velocidade, transform.position.y, transform.position.z);

        if (transform.position.x < Jogador.transform.position.x - 12)
        {


        }

    }
}
