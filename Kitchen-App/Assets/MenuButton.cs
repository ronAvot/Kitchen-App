using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuButton : MonoBehaviour {

    public GameObject Model;
    bool isHide = true;
        public Button yourButton;

    
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    
    

    void hide()
    {
        if (isHide)
        {
            Model.SetActive(true);
            isHide = false;
        }

        else
        {
            Model.SetActive(false);
            isHide = true;
        }
    }

    
    
    void TaskOnClick()
    {

        hide();
    }

    
}
