using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
  [System.Serializable]
  public enum DoorType
  {
    Open,
    Wall,
    Silver,
    Gold,
  }

  public DoorType m_N = DoorType.Open;
  public DoorType m_S = DoorType.Open;
  public DoorType m_E = DoorType.Open;
  public DoorType m_W = DoorType.Open;
  public Transform m_WallPrefab;
  public Transform m_WallsNode;

  static Vector3 m_WallPositionN = new Vector3(0, 4, 0);
  static Vector3 m_WallPositionS = new Vector3(0, -4, 0);
  static Vector3 m_WallPositionE = new Vector3(6.5f, 0, 0);
  static Vector3 m_WallPositionW = new Vector3(-6.5f, 0, 0);


  public void Setup(DoorType n, DoorType s, DoorType e, DoorType w)
  {
    m_N = n;
    m_S = s;
    m_E = e;
    m_W = w;

    if (n == DoorType.Wall)
    {
      var wall = Instantiate(m_WallPrefab, m_WallPositionN, Quaternion.identity, m_WallsNode);
      wall.localScale = new Vector3(2, 1, 1);
    }
    if (s == DoorType.Wall)
    {
      var wall = Instantiate(m_WallPrefab, m_WallPositionS, Quaternion.identity, m_WallsNode);
      wall.localScale = new Vector3(2, 1, 1);
    }
    if (e == DoorType.Wall)
    {
      var wall = Instantiate(m_WallPrefab, m_WallPositionE, Quaternion.identity, m_WallsNode);
      wall.localScale = new Vector3(1, 2, 1);
    }
    if (w == DoorType.Wall)
    {
      var wall = Instantiate(m_WallPrefab, m_WallPositionW, Quaternion.identity, m_WallsNode);
      wall.localScale = new Vector3(1, 2, 1);
    }
  }
}
