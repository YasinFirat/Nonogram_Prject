using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Nonogram data ayarlamas� yap�lacak
/// </summary>
/// 
[CreateAssetMenu(fileName = "NonogramData", menuName = "Nonogram/Create Nonogram Data Controller", order = 1)]
public class NonogramDataController : ScriptableObject
{
    public List<NonogramProduct> nonogramProducts;
}
