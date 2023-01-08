using UnityEngine;

public class GameWin : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        SceneSwitch.Instance.EndLevel();
    }
}
