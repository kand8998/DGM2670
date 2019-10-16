using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class CineMachineController : MonoBehaviour
{
    public GameAction gameActionObj;
    private CinemachineVirtualCamera virtualCamera;
    private void Start()
    {
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
        gameActionObj.transformAction = TransformHandler;
    }
    
    private void TransformHandler(Transform transformObj)
    {
        virtualCamera.Follow = transformObj;
    }

}
