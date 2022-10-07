#if UNITY_EDITOR
using UnityEngine;

namespace YellowJelloGames.YSceneManagement.Core
{
    public partial class YSceneType
    {
        [Header("Editor")]
        [SerializeField]
        private Color editorColor;

        public Color EditorColor => editorColor;
    }
}
#endif