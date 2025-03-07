using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionOutlineModifier : MonoBehaviour, ISelectionMode
{
    public void OnSelect(Transform selection)
    {
        Outline outline = selection.GetComponent<Outline>();
        if (outline != null)
        {
            outline.OutlineWidth = 10;
        }
    }
    public void OnDeselect(Transform selection)
    {
        Outline outline = selection.GetComponent<Outline>();
        if (outline != null)
        {
            outline.OutlineWidth = 0;
        }
    }
}
