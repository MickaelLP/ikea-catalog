using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool isTutorialActive;
    public GameObject textUI;
    public GameObject panelUI;

    // Start is called before the first frame update
    void Start()
    {
        isTutorialActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTutorialActive == false)
        {
            textUI.SetActive(false);
            panelUI.SetActive(false);
        }
    }
}
