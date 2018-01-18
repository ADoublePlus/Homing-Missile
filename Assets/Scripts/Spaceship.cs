using UnityEngine;

namespace Home
{
    public class Spaceship : MonoBehaviour
    {
        public float speed = 1f;

        // Update is called once per frame
        void Update ()
        {
            float horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            float vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;

            transform.Translate(horizontal, vertical, 0f);
        }
    }
}