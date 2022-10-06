using UnityEngine;

public enum TeamIndex
{
    None = -1,
    Neutral = 0,
    Player,
    Enemy,
    Count
}

public class TeamComponent : MonoBehaviour
{
    [SerializeField] private TeamIndex _teamIndex = TeamIndex.None;

    public TeamIndex teamIndex
    {
        set
        {
            if (_teamIndex == value)
            {
                return;
            }
        }
        get => _teamIndex;
    }
}