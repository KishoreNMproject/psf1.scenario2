using UnityEngine;

public class Step1 : MonoBehaviour
{
    public Camera introCam;
    public Camera step1Cam;

    public void SwitchToStep1()
    {
        introCam.enabled = false;
        step1Cam.enabled = true;
    }
    void Start() {
    Canvas canvas = GetComponent<Canvas>();
    if (canvas.renderMode == RenderMode.ScreenSpaceCamera)
        canvas.worldCamera = Camera.main;
}

}
