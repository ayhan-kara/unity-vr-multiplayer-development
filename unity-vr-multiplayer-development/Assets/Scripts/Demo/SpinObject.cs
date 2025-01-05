using UnityEngine;

namespace Demo
{
    public class SpinObject : MonoBehaviour
    {
        [SerializeField] private float speed = 60.0f;

        private void Update() => transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}