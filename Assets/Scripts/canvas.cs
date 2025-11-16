using UnityEngine;

public class CanvasSwitcher : MonoBehaviour {
    public GameObject canvas1;
    public GameObject canvas2;

    public void SwitchCanvas() {
        canvas1.SetActive(false);
        canvas2.SetActive(true);
    }
}
