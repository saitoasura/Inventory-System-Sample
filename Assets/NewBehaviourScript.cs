using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private int score;
    // Start is called before the first frame update
    void Start()
    {
     CheckHealth();
    }

    void CheckHealth()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(score);
    }
}
