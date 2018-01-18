using UnityEngine;

namespace Home
{
    [RequireComponent(typeof(Rigidbody2D))]

    public class HomingMissile : MonoBehaviour
    {
        public Transform target;

        public float speed = 5f;
        public float rotateSpeed = 200f;

        private Rigidbody2D rigid;

        // Use this for initialization
        void Start ()
        {
            rigid = GetComponent<Rigidbody2D>();
        }

        void FixedUpdate ()
        {
            Vector2 direction = (Vector2)target.position - rigid.position;

            direction.Normalize();

            float rotateAmount = Vector3.Cross(direction, transform.up).z;

            rigid.angularVelocity = -rotateAmount * rotateSpeed;

            rigid.velocity = transform.up * speed;
        }

        void OnTriggerEnter2D ()
        {
            // Put a particle effect here


            Destroy(gameObject);
        }
    }
}