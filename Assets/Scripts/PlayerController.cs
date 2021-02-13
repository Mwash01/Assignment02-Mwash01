using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text scoreText;
    public Text winText;
    private int count = 0;

    private void Awake()
    {
        if (Data.largeBall)
        {
            this.gameObject.transform.localScale = new Vector3(3.0f, 3.0f, 3.0f);
        }

        if (Data.ballColor == 1)
        {
            GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        else if (Data.ballColor == 2)
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
        else if (Data.ballColor == 3)
        {
            GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        GetComponent<Rigidbody>().AddForce(movement * Data.playerSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            scoreText.text = "Score: " + count;
            if (count == 9)
            {
                winText.gameObject.SetActive(true);
            }
        }
    }
}
