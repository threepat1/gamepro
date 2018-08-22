using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{

    [Header("References")]
    public GameObject player;
    public GameObject mainCam;

    void Start()
    {


        player = GameObject.Find("Player");
        mainCam = GameObject.FindGameObjectWithTag("MainCamera");


    /// cam = mainCam.GetComponent<Camera>();
    /// cam = GameObject.FindGameObjectWithTag("MainCamer").GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray Interact;
            Interact = Camera.main.ScreenPointToRay
                (new Vector2(Screen.width / 2, Screen.height / 2));
            RaycastHit hitInfo;
            if (Physics.Raycast(Interact, out hitInfo, 10.0f))
            {
                #region NPC Dialogue
                if (hitInfo.collider.CompareTag("NPC"))
                {
                    Debug.Log("Talk to NPC");
                }

                #endregion
                #region Chest
                if (hitInfo.collider.CompareTag("Chest"))
                {
                    Debug.Log("Open Chest");
                }

                #endregion
                #region Item
                if (hitInfo.collider.CompareTag("Item"))
                {
                    Debug.Log("Pick up Item");
                }
                #endregion
            }

        }


    }
}
