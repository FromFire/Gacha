using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public Data data;

    public Text pointsNumber;

    // Start is called before the first frame update
    void Start()
    {
        pointsNumber.text = data.saveEntity.points + "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
