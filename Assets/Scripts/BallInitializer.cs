using UnityEngine;
    public class BallInitializer : MonoBehaviour {
        private Rigidbody2D rb { get; set; }
        public float speed = 500f;

        private void Awake() {
            rb = GetComponent<Rigidbody2D>();
        }

        private void Start() {
            Invoke(nameof(SetRandomTrajectory), 1f);
        }

        private void SetRandomTrajectory() {
            Vector2 force = Vector2.zero;
            force.x = Random.Range(-0.5f, 0.5f);
            force.y = -1;

            rb.AddForce(force.normalized * speed);
        }
    }