using UnityEngine;
using UnityEngine.Serialization;

    public class PlayerController : MonoBehaviour {

        private Rigidbody2D rb;
        private Vector2 direction;
        public float speed = 30f;
        void Start() {
            rb = GetComponent<Rigidbody2D>();
        }

        void Update() {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
                direction = Vector2.left;
            } else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
                direction = Vector2.right;
            } else {
                direction = Vector2.zero;
            }
        }
        
        void FixedUpdate() {
            if(direction == Vector2.zero) {
                return;
            }

            rb.AddForce(direction * speed);
        }
    }

