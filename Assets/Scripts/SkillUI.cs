using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SkillUI : MonoBehaviour
{
    UIDocument uiDocument;
    Label l;
    VisualElement ve;

    void OnEnable()
    {
        uiDocument = GetComponent<UIDocument>();
        ve = uiDocument.rootVisualElement.Q<VisualElement>("skillInfo");
        ve.style.display = DisplayStyle.None;
        l = uiDocument.rootVisualElement.Q<Label>("labelSkills");
        l.RegisterCallback<ClickEvent>(ClickLabelSkill);
    }

    void ClickLabelSkill(ClickEvent e)
    {
        if (ve.style.display == DisplayStyle.Flex)
        {
            ve.style.display = DisplayStyle.None;
        }
        else 
        {
            ve.style.display = DisplayStyle.Flex;
        }
    }
}
