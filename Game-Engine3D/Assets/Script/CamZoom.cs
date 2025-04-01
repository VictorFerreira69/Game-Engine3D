using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CamZoom : MonoBehaviour
{
    CinemachineVirtualCamera virtualCamera;
    [SerializeField] float rifleFov;
    [SerializeField] float sniperFov;


    // Start is called before the first frame update
    void Start()
    {
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
        GameController.instance.OnRifleMode.AddListener(delegate
        {
          virtualCamera.m_Lens.FieldOfView = rifleFov;
        });
        GameController.instance.OnSniperMode.AddListener(delegate
        {
            virtualCamera.m_Lens.FieldOfView = sniperFov;
        });
    }

  
  
    
}
