using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Nonogram data ayarlaması yapılacak
/// </summary>
/// 
[CreateAssetMenu(fileName = "NonogramData", menuName = "Nonogram/Create Nonogram Data Controller", order = 1)]
public class NonogramDataController : ScriptableObject
{
    public List<NonogramProduct> nonogramProducts;
}
