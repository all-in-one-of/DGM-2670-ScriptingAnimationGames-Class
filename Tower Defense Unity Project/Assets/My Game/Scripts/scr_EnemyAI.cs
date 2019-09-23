using UnityEngine;

public class scr_EnemyAI : MonoBehaviour
{
    public float speed = 2f; //Max 30ish

    private Transform target, lastTarget;
    private int wavepointIndex = 0;
    
    void Start()
    {
        target = scr_Waypoints.points[0];
        lastTarget = scr_Waypoints.points[scr_Waypoints.points.Length - 1];
    }

    void Update ()
    {
        Vector3 dir = target.position - transform.position;
        
        if (Vector3.Distance(transform.position, lastTarget.position) <= speed * 0.03f)
        {
            transform.Translate(dir.normalized * (speed / 2) * Time.deltaTime, Space.World); //This is so that at greater speeds the enemy is slow after it turns
        }
        else
        if (Vector3.Distance(transform.position, target.position) <= speed * 0.03f)
        {
            transform.Translate(dir.normalized * (speed / (speed / 4)) * Time.deltaTime, Space.World); //This is so that at greater speeds the enemy slows down before it turns
        }
        else
        {
            transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        }
        
        if (Vector3.Distance(transform.position, target.position) <= 0.05f)
        {
            transform.position = target.position;
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if (wavepointIndex >= scr_Waypoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
        wavepointIndex++;
        target = scr_Waypoints.points[wavepointIndex];
        lastTarget = scr_Waypoints.points[wavepointIndex-1];
    }
}
