using UnityEngine;

namespace KANAME
{
    public class Practice : MonoBehaviour
    {
        private void Awake()
        {
            Debug.Log(message: "Awake");
        }

        private void Start()
        {
            Debug.Log(message: $"Start");

        }

        private void OnEnable()
        {
            Debug.Log(message: $"OnEnble");
        }

        private void OnDisable()
        {
            Debug.Log(message: $"OnDisable");
        }
        private void OnDestroy()
        {
            Debug.Log(message: $"OnDestroy");
        }
    }
}