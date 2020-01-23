using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonGenerator : MonoBehaviour
{
  public Room m_TemplatePrefab;

  Dictionary<Vector2Int, Room> m_Grid;


  private void Awake()
  {
    Generate();
  }


  void Generate()
  {

  }
}
