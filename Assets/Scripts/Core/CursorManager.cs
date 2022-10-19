using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            SetCursorVisible(false);
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SetCursorVisible(true);
        }
    }

    private void SetCursorVisible(bool isUnLock)
    {
        if(isUnLock == true)
            Cursor.lockState = CursorLockMode.None;
        else
            Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = isUnLock;
    }
}
