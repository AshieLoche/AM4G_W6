using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotSelector : MonoBehaviour, ISelector
{
    [SerializeField] string selectableTag = "Selectable";
    public List<SelectableText> selectables;
    public float threshhold;
    private Transform _selection;

    public void Check(Ray ray)
    {
        _selection = null;

        for (int i = 0; i < selectables.Count; i++)
        {
            Vector3 vector1 = ray.direction;
            Vector3 vector2 = selectables[1].transform.position - ray.origin;

            float lookPercentage = Vector3.Dot(vector1.normalized, vector2.normalized);

            selectables[i].lookPercent = lookPercentage;

            if (lookPercentage > threshhold && lookPercentage > closest)
            {

            }
        }
    }

    public Transform GetSelection() { return _selection; }
}
