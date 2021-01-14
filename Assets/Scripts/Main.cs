using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public Data data;

    public Text pointsNumber;

    // Start is called before the first frame update
    void Start()
    {
        pointsNumber.text = Data.saveEntity.points + "";
    }

    public void ToCardBook() {
        SceneManager.LoadScene("CardBook");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
