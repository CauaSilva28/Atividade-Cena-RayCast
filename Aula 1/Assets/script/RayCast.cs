using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class iObjetos : MonoBehaviour
{
    private int frutasPegas = 0;

    public AudioSource pegandoFruta;

    public Text textoQuantFrutas;

    Vector3 point;
    public Camera _camera;
    Ray ray;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        textoQuantFrutas.text = frutasPegas.ToString();

        if (Input.GetMouseButtonDown(0))
        {
            point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
            ray = _camera.ScreenPointToRay(point);

            RaycastHit hit;

            float maxDistance = 20f;

            if (Physics.Raycast(ray, out hit, maxDistance))
            {
                if (hit.transform.gameObject.CompareTag("Itens"))
                {
                    StartCoroutine(DestroyAlvoAfterDelay(hit.transform.gameObject, 2f));
                }
            }
        }
    }

     IEnumerator DestroyAlvoAfterDelay(GameObject alvo, float delay)
    {
        ParticleSystem hitParticleSystem = alvo.GetComponent<ParticleSystem>();
        if (hitParticleSystem != null)
        {
            alvo.GetComponent<Collider>().enabled = false;
            hitParticleSystem.Play();
            pegandoFruta.Play();
            frutasPegas++;
            yield return new WaitForSeconds(delay);
        }

        Destroy(alvo);
    }


}