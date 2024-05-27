using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    IRaycastProvider iRaycastProvider;
    ISelector iSelector;
    ISelectionMode iSelectionMode;

    private Transform currentSelection;

    // Start is called before the first frame update
    void Start()
    {
        iRaycastProvider = GetComponent<IRaycastProvider>();
        iSelector = GetComponent<ISelector>();
        iSelectionMode = GetComponent<ISelectionMode>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentSelection != null)
            iSelectionMode.OnDeselect(currentSelection);
        iSelector.Check(iRaycastProvider.CreateRay());
        currentSelection = iSelector.GetSelection();

        if (currentSelection != null)
            iSelectionMode.OnSelect(currentSelection);
    }
}
