using System;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject playAgain, nextLevel, thanksText;
    private void Start()
    {
        var _last = SceneSwitch.Instance.IsLastLevel;
        thanksText.SetActive(_last);
        playAgain.SetActive(_last);
        nextLevel.SetActive(!_last);
    }
}
