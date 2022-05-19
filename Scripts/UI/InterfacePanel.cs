using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfacePanel : MonoBehaviour
{
    private bool _isOpen;

    public virtual void Open()
    {
        if (_isOpen)
            return;
        _isOpen = true;
        gameObject.SetActive(_isOpen);
    }

    public virtual void Close()
    {
        if (!_isOpen)
            return;
        _isOpen = false;
        gameObject.SetActive(_isOpen);
    }
}
