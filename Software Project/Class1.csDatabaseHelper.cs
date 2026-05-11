using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace Software_Project
{
    public class DatabaseHelper
    {
        private static string dbPath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "LabSystem.db");

        private static string connectionString = $"Data Source={dbPath};Version=3;";

        public static void InitializeDatabase()
        {
            if (!File.Exists(dbPath))
                SQLiteConnection.CreateFile(dbPath);

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string createUsers = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        FullName TEXT NOT NULL,
                        Username TEXT UNIQUE NOT NULL,
                        Password TEXT NOT NULL,
                        Role TEXT NOT NULL
                    )";

                string createAppointments = @"
                    CREATE TABLE IF NOT EXISTS Appointments (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        PatientName TEXT NOT NULL,
                        TestType TEXT NOT NULL,
                        AppointmentDate TEXT NOT NULL,
                        Result TEXT DEFAULT 'Pending'
                    )";

                new SQLiteCommand(createUsers, conn).ExecuteNonQuery();
                new SQLiteCommand(createAppointments, conn).ExecuteNonQuery();

                // Admin افتراضي
                string insertAdmin = @"
                    INSERT OR IGNORE INTO Users (FullName, Username, Password, Role)
                    VALUES ('Admin User', 'admin', '1234', 'Admin')";
                new SQLiteCommand(insertAdmin, conn).ExecuteNonQuery();
            }
        }

        public static DataTable GetUsers()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT FullName, Username, Password, Role FROM Users";
                var adapter = new SQLiteDataAdapter(query, conn);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static bool AddUser(string fullName, string username, string password, string role)
        {
            try
            {
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Users (FullName, Username, Password, Role) VALUES (@fn, @un, @pw, @role)";
                    var cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@fn", fullName);
                    cmd.Parameters.AddWithValue("@un", username);
                    cmd.Parameters.AddWithValue("@pw", password);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch { return false; }
        }

        public static bool ValidateLogin(string username, string password, out string role)
        {
            role = "";
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Role FROM Users WHERE Username=@un AND Password=@pw";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@un", username);
                cmd.Parameters.AddWithValue("@pw", password);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    role = result.ToString();
                    return true;
                }
                return false;
            }
        }

        public static bool AddAppointment(string patientName, string testType, string date)
        {
            try
            {
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Appointments (PatientName, TestType, AppointmentDate) VALUES (@pn, @tt, @dt)";
                    var cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@pn", patientName);
                    cmd.Parameters.AddWithValue("@tt", testType);
                    cmd.Parameters.AddWithValue("@dt", date);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch { return false; }
        }

        public static DataTable GetAppointments()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT PatientName, TestType, AppointmentDate, Result FROM Appointments";
                var adapter = new SQLiteDataAdapter(query, conn);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static bool DeleteUser(string username)
        {
            try
            {
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Users WHERE Username=@un";
                    var cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@un", username);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch { return false; }
        }
    }
}