using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrashInBin : MonoBehaviour
{
    public GameObject PieceOfTrash;
    public GameObject OnMap;
    public static int scoreValue = 0;
    public static int scoreNeed = 20;
    public GameObject Dialogue2;
    public GameObject Dialogue3;
    public Text score;

    void Start()
    {
        Dialogue3.SetActive(false);
        Dialogue2.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreValue + "/" + scoreNeed;

        if(scoreValue == 2)
        {
            Dialogue2.SetActive(true);
        }
        if (scoreValue == scoreNeed)
        {
            Dialogue3.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bin")
        {
            OnMap.SetActive(false);
            ThrowObject.isHolding = false;
            PieceOfTrash.GetComponent<Rigidbody>().useGravity = true;
            PieceOfTrash.GetComponent<Rigidbody>().isKinematic = false;
            Destroy(PieceOfTrash.GetComponent<ThrowObject>());
            Destroy(PieceOfTrash.GetComponent<ThrowObject2>());
            Destroy(PieceOfTrash.GetComponent<ThrowObject3>());
            Destroy(PieceOfTrash.GetComponent<ThrowObject4>());
            Destroy(PieceOfTrash.GetComponent<ThrowObject5>());
            Destroy(PieceOfTrash.GetComponent<ThrowObject6>());
            Destroy(PieceOfTrash.GetComponent<ThrowObject7>());
            Destroy(PieceOfTrash.GetComponent<ThrowObject8>());
            Destroy(PieceOfTrash.GetComponent<ThrowObject9>());
            Destroy(PieceOfTrash.GetComponent<ThrowObject10>());
            scoreValue = scoreValue + 1;
        }
    }
}
