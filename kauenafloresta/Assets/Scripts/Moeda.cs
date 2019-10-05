using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda : MonoBehaviour
{
    private Jogo jogo;


    private void OnTriggerEnter2D(Collider2D colisor)
    {
        if(colisor.gameObject.tag == "Player"){
            jogo.AdicionarPontos();
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        GameObject objetoJogo = GameObject.FindWithTag("JOGO");
        jogo = objetoJogo.GetComponent<Jogo>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
