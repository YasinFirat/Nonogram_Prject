using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    [Header("COLOR SETTINGS")]
    [Tooltip("Boyanacak pixel'in rengi se�ilmeli")]
    public Color32 fullColor = Color.black;
    [Tooltip("Pixel'in boyanmam�� durumu")]
    public Color32 emptyColor = Color.white;

    #region Singleton
    public static Settings Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
            return;
        }
        Instance = this;
    }
    #endregion
}
