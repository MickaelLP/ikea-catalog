using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleUI : MonoBehaviour
{
    GameObject[] table;
    GameObject[] chaise;
    // Start is called before the first frame update
    void Start()
    {
        table = GameObject.FindGameObjectsWithTag("UI_table");
        chaise = GameObject.FindGameObjectsWithTag("UI_chaise");
        CloseAllUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggle(string tagname)
    {
        CloseAllUI();

        // Ouvrir le tagName
        if(tagname == "UI_table")
        {
            foreach (GameObject UItable in table)
            {
                UItable.SetActive(true);
            }
        } else
        {
            foreach (GameObject UItable in chaise)
            {
                UItable.SetActive(true);
            }
        }
        

    }

    private void CloseAllUI()
    {
        // Fermer tous les ui
        foreach (GameObject UItable in table)
        {
            UItable.SetActive(false);
        }

        foreach (GameObject UItable in chaise)
        {
            UItable.SetActive(false);
        }
    }
}
