using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraChangeDropdown : MonoBehaviour
{
    private Dropdown cameraChangeDropdown;

    private Transform mainCameraTransform;

    private Vector3 frontViewPos;
    private Quaternion frontViewDir;
    private Vector3 sideViewPos;
    private Quaternion sideViewDir;
    private Vector3 topViewPos;
    private Quaternion topViewDir;

    void Start()
    {
        cameraChangeDropdown = GetComponent<Dropdown>();

        cameraChangeDropdown.onValueChanged.AddListener(delegate {
            CameraChangeDropdownValueChangedHandler(cameraChangeDropdown);
        });

        mainCameraTransform = GameObject.Find("Main Camera").transform;

        frontViewPos = new Vector3(32f, 32f, 140f);
        frontViewDir = new Quaternion();
        frontViewDir = Quaternion.Euler(42.5f, 180f, 0f);

        sideViewPos = new Vector3(-32f, 0f, 32f);
        sideViewDir = new Quaternion();
        sideViewDir = Quaternion.Euler(0f, 90f, 0f);

        topViewPos = new Vector3(32f, 128f, 32f);
        topViewDir = new Quaternion();
        topViewDir = Quaternion.Euler(90f, 0f, 0f);
    }

    private void CameraChangeDropdownValueChangedHandler(Dropdown target)
    {
        switch(target.value)
        {
            default:
            case 0:
                mainCameraTransform.position = frontViewPos;
                mainCameraTransform.rotation = frontViewDir;
                break;
            case 1:
                mainCameraTransform.position = sideViewPos;
                mainCameraTransform.rotation = sideViewDir;
                break;
            case 2:
                mainCameraTransform.position = topViewPos;
                mainCameraTransform.rotation = topViewDir;
                break;
        }
    }
}
