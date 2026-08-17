-- 1. User Upcoming Events: Show upcoming events a user is registered for in their city, sorted by date.
SELECT u.full_name, e.title, e.start_date, e.city
FROM Users u
JOIN Registrations r ON u.user_id = r.user_id
JOIN Events e ON r.event_id = e.event_id
WHERE u.city = e.city AND e.status = 'upcoming'
ORDER BY e.start_date ASC;

-- 2. Top Rated Events: Identify events with highest avg rating, minimum 10 feedback submissions.
SELECT e.title, AVG(f.rating) AS average_rating
FROM Events e
JOIN Feedback f ON e.event_id = f.event_id
GROUP BY e.event_id, e.title
HAVING COUNT(f.feedback_id) >= 10
ORDER BY average_rating DESC;

-- 3. Inactive Users: Retrieve users who have not registered for any events in the last 90 days.
SELECT u.user_id, u.full_name, u.email
FROM Users u
LEFT JOIN Registrations r ON u.user_id = r.user_id AND r.registration_date >= CURDATE() - INTERVAL 90 DAY
WHERE r.registration_id IS NULL;

-- 4. Peak Session Hours: Count how many sessions are scheduled between 10 AM to 12 PM for each event.
SELECT e.title, COUNT(s.session_id) AS morning_sessions
FROM Events e
JOIN Sessions s ON e.event_id = s.event_id
WHERE TIME(s.start_time) >= '10:00:00' AND TIME(s.start_time) <= '12:00:00'
GROUP BY e.event_id, e.title;

-- 5. Most Active Cities: List top 5 cities with the highest number of distinct user registrations.
SELECT e.city, COUNT(DISTINCT r.user_id) AS total_unique_registrations
FROM Events e
JOIN Registrations r ON e.event_id = r.event_id
GROUP BY e.city
ORDER BY total_unique_registrations DESC
LIMIT 5;