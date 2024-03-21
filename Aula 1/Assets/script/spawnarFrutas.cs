using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnarFrutas : MonoBehaviour
{
    public Transform[] spawnpoints;

    public GameObject fruta;

    private void Start(){
        InvokeRepeating("SpawnFruta", 1, 3);
    }

     void SpawnFruta(){
        int r = Random.Range(0, spawnpoints.Length);
        GameObject Fruta = Instantiate(fruta, spawnpoints[r].position, Quaternion.identity);
        Fruta.tag = "itens";
    }
}
