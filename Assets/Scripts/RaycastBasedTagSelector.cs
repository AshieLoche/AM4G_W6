using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastBasedTagSelector : MonoBehaviour, ISelector
{
    [SerializeField] string selectedTag = "Selectable";
    private Transform _selection;

    public void Check(Ray ray)
    {
        _selection = null;

        if (!Physics.Raycast(ray, out var hit)) return;
        var selection = hit.transform;
        if (selection.CompareTag(selectedTag))
        {
            _selection = selection;
        }
    }

    public Transform GetSelection() { return _selection; }
}
