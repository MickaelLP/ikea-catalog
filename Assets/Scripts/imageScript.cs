using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imageScript : MonoBehaviour
{
    static imageScript[] catalogue;
    // Start is called before the first frame update
    void Awake()
    {
        catalogue = GameObject.FindObjectsOfType<imageScript>();
        DesactiveAllObject();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActiveObject()
    {
        if(GameManager.isTutorialActive == true)
        {
            GameManager.isTutorialActive = false;
        }
        DesactiveAllObject();
        this.gameObject.SetActive(true);
    }

    void DesactiveAllObject()
    {
        foreach(imageScript unObject in catalogue)
        {
            unObject.gameObject.SetActive(false);
        }
    }
}
