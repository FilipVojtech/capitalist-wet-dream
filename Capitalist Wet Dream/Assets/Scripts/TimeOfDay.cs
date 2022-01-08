using TMPro;
using UnityEngine;

public class TimeOfDay : MonoBehaviour
{
    [SerializeField] private float dayInSeconds = 60 * 10;
    private float _day;
    [SerializeField] private float startDayAtHoursDecimal = 7.75f;

    [SerializeField] private Transform sun;
    [SerializeField] private TMP_Text digitalClock;

    private void Start()
    {
        // Set the start of the day at 7:45
        _day = startDayAtHoursDecimal / 24f;
    }

    private void Update()
    {
        _day += Time.deltaTime / dayInSeconds;
        var dayNormalized = _day % 1f;

        //Update sun rotation
        const float sunRotationOffset = 90f;
        sun.eulerAngles = new Vector3(-dayNormalized * 360f - sunRotationOffset, 0, 0);

        // Update clock
        var hours = Mathf.Floor(dayNormalized * 24f);
        var minutes = Mathf.Floor(((dayNormalized * 24f) % 1f) * 60f);
        digitalClock.text = $"{hours:0}:{minutes:00}";
    }
}