using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta2 : MonoBehaviour
{
    private Jogo jogo;
    // Start is called before the first frame update
    void Start()
    {
        GameObject objetoJogo = GameObject.FindGameObjectWithTag("JOGO");
        jogo = objetoJogo.GetComponent<Jogo>();


    }

    void OnTriggerEnter2D(Collider2D colisor)
    {
        if (colisor.gameObject.tag == "Player")
        {
            jogo.CarregaVoceVenceu();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
