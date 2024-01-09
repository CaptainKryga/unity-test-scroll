using UnityEngine;

namespace Project.Scripts.Model
{
    [CreateAssetMenu(fileName = "Database", menuName = "ScriptableObjects/Database", order = 1)]
    public class Database : ScriptableObject
    {
        public MessageData[] messages;
    }
}
