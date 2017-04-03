using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using I2.Loc;

public class manager : MonoBehaviour {


    public GameObject slide1, slide2;
    private Camera cam;
    public Canvas canvas;
    private int alignment;


	// Use this for initialization
	void Start () {
        alignment = 0;
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    

    public void reverseText()
    {
        TextMeshProUGUI[] textMeshProObjects = Resources.FindObjectsOfTypeAll(typeof(TextMeshProUGUI)) as TextMeshProUGUI[];
        foreach (TextMeshProUGUI obj in textMeshProObjects)
        {
            obj.transform.localScale = new Vector3(obj.transform.localScale.x * -1f, obj.transform.localScale.y * 1f, obj.transform.localScale.z * 1f);

            //switch (obj.alignment.ToString())
            //{
            //    case "Left":
            //        obj.alignment = TextAlignmentOptions.Right;
            //        break;
            //    case "Right":
            //        obj.alignment = TextAlignmentOptions.Left;
            //        break;
            //    case "Center":
            //        obj.alignment = TextAlignmentOptions.Center;
            //        break;

            //}
        }
    
    }

    public void showEnglish()
    {
       LocalizationManager.CurrentLanguage = "English (United States)";
    }

    public void showArabic()
    {
        LocalizationManager.CurrentLanguage = "Arabic (U.A.E)";
    }

    public void showSlide1()
    {
        slide1.SetActive(true);
        slide2.SetActive(false);
    }

    public void showSlide2()
    {
        slide1.SetActive(false);
        slide2.SetActive(true);
    }

    public void reverseCamera()
    {
        if (alignment == 0)
        {
            canvas.renderMode = RenderMode.ScreenSpaceCamera;
            canvas.worldCamera = cam;
            alignment = 1;
        }
        else if (alignment == 1)
        {
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            canvas.worldCamera = cam;
            alignment = 0;
        }


        UnityEngine.UI.Text[] text = Resources.FindObjectsOfTypeAll(typeof(UnityEngine.UI.Text)) as UnityEngine.UI.Text[];
        foreach (UnityEngine.UI.Text obj in text)
        {
            obj.transform.localScale = new Vector3(obj.transform.localScale.x * -1f, obj.transform.localScale.y * 1f, obj.transform.localScale.z * 1f);
        }
    }

}
