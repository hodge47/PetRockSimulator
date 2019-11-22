using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionCameraController : MonoBehaviour
{
    Cinemachine.CinemachineVirtualCamera c_VirtualCamera;

    Cinemachine.CinemachineTrackedDolly c_TrackedDolly;

    [SerializeField] Transform[] target = new Transform[4];

    private int targetIndex = 0;

    private void Awake()
    {
        c_VirtualCamera = GetComponent<Cinemachine.CinemachineVirtualCamera>();
        c_TrackedDolly = GetComponent<Cinemachine.CinemachineTrackedDolly>();
    }
    private void Start()
    {

        c_VirtualCamera.m_LookAt = target[targetIndex].transform;
        
    }


    private void Update()
    {
        c_VirtualCamera.m_LookAt = target[targetIndex].transform;
        //c_TrackedDolly.m_PathPosition = targetIndex;

        if (Input.GetMouseButtonDown(0))
        {
            if (targetIndex >= 3)
            {
                targetIndex = 0;
            }
            else
            {
                targetIndex++;
            }

        }
    }
}
