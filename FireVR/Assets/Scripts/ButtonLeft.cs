using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLeft : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject button;
    public GameObject platform;
    public float moveSpeed;
    GameObject presser;
    bool isPressed;
    // Start is called before the first frame update
    void Start()
    {
        isPressed = false;
    }

    void Update()
    {
        if (isPressed)
        {
            MoveLeft();
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            button.transform.localPosition = new Vector3(0, 0.003f, 0);
            presser = other.gameObject;
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == presser)
        {
            button.transform.localPosition = new Vector3(0, 0.015f, 0);
            isPressed = false;
        }
    }
    public void MoveLeft()
    {
        platform.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }
}
