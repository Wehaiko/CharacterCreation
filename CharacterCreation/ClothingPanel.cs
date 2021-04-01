using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClothingPanel : MonoBehaviour
{
    //Add this script to a clothing panel and in Start-method the panel in which the script is, is added to the variable thisPanel
    public RectTransform thisPanel;

    private void Start()
    {
        thisPanel = GetComponent<RectTransform>();
    }

    //Method for bringing up the pressed panel. Add to panels button component On-click event and drag script to the field and select OpenPanel.
    public void OpenPanel()
    {
        //Changes the panels SiblingIndex to last, which brings the panel to the top
        thisPanel.transform.SetAsLastSibling();
    }
}
