using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FedCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI animalsFed;
    public int animalsHit = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animalsFed.SetText("Animals Fed: " + animalsHit);
    }
}
