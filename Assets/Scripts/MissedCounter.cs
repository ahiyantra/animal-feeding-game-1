using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MissedCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI animalsMissed;
    public int animalsPassed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animalsMissed.SetText("Animals Missed: " + animalsPassed);
    }

    private void OnTriggerEnter(Collider other)
    {
        animalsPassed++;
    }
}
