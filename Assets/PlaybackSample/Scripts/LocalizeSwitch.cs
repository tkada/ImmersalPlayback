using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LocalizeSwitch : MonoBehaviour
{
    [SerializeField] Button startButton;
    [SerializeField] Button stopButton;
    private void Start()
    {
        this.startButton.onClick.AddListener(() =>
        {
            Immersal.ImmersalSDK.Instance.Localizer.StartLocalizing();
        });

        this.stopButton.onClick.AddListener(() =>
        {
            Immersal.ImmersalSDK.Instance.Localizer.StopLocalizing();
        });
    }
}
