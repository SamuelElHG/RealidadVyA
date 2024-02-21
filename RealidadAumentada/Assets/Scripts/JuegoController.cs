using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuegoController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void selected()
    {

        gameObject.SetActive(false);
        player.SetActive(true);

    }

}
