using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class InitiateBattle : MonoBehaviour
{

    [SerializeField] private UnityEvent startBattle;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            TriggerBattle();
        }
       
        
    }

    void TriggerBattle()
    {
        startBattle.Invoke();

    }
}
