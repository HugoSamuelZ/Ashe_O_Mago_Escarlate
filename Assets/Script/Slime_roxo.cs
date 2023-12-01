using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime_roxo : MonoBehaviour
{
    public int hp = 3;
    public float velocidade = 0.1f;
    public float distInicial = -0.5f;
    public float distFinal = 2f;
    private SpriteRenderer ImagemSlime;
    public Animator anim;

    void Start()
    {
        ImagemSlime = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {

        Andar();
    }

    void Andar()
    {
        transform.position = new Vector3(transform.position.x + velocidade, transform.position.y, transform.position.z);
        //mudar velocidade
        //Andar para trás
        if (transform.position.x > distFinal)
        {
            velocidade = velocidade * -1;
            ImagemSlime.flipX = true;
        }
        //Andar para frente
        if (transform.position.x < distInicial)
        {
            velocidade = velocidade * -1f;
            ImagemSlime.flipX = false;
        }
    }


    ///Danos

    // verifica dano recebido dos inimigos
    void OnTriggerEnter2D(Collider2D colisao)
    {

        if (colisao.gameObject.tag == "Fogo")
        {


            hp--;
            if (hp <= 0)
            {

                Destroy(this.gameObject);



            }


        }
    }
}
