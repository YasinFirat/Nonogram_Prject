using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Oyun ile ayarlar bu script üzerinde yapýlacak
/// </summary>
public class GameManager : MonoBehaviour
{
    #region Degiskenler


    #endregion


    #region Singleton
    public static GameManager Instance { get; private set; }

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
