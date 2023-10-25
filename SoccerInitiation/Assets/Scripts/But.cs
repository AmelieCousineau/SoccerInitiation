using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class But : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textNbPoint;
    [SerializeField] private GameObject ballon;
    private int nbPoints = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textNbPoint.text = nbPoints.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Soccer Ball"){
            nbPoints++;

            Invoke("BallonCentre", 2.0f);
        }
    }

    private void BallonCentre(){
        ballon.transform.position = new Vector3(3f, 2.25f, 0f);
    }
}
