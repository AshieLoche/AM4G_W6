using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISelectionMode
{
    void OnSelect(Transform selection);
    void OnDeselect(Transform selection);
}
