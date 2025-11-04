using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorAssignment.Controllers

{
    internal class DBcontext
    {
        string connectString = @"Server = localhost\SQLEXPRESS; Database = Elevator; Trusted_Connection = True";

        public void InsertLogs(DataTable dt)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    string query = @"Insert into logs(LogTime, EventDescription) values(@Time, @Logs)";
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.InsertCommand = new SqlCommand(query, conn);
                        adapter.InsertCommand.Parameters.Add("@Time", SqlDbType.DateTime, 0, "Time");
                        adapter.InsertCommand.Parameters.Add("@Logs", SqlDbType.NVarChar, 255, "Events");

                        conn.Open();

                        adapter.Update(dt);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error while saving", ex.Message);
            }
        }

        public void loadLogs(DataTable dt, DataGridView dataGridViewLogs)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    string query = @"Select LogTime, EventDescription from logs order by LogTime desc";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        dt.Rows.Clear();

                        adapter.Fill(dt);

                        dataGridViewLogs.Rows.Clear();

                        foreach (DataRow row in dt.Rows)
                        {
                            string currentTime = Convert.ToDateTime(row["LogTime"]).ToString("hh:mm:ss");
                            string events = row["EventDescription"].ToString();

                            dataGridViewLogs.Rows.Add(currentTime, events);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading record from DB: ", ex.Message);
            }

        }

        public void TruncateLogs(DataTable dt, DataGridView dataGridViewLogs)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    string query = "TRUNCATE TABLE logs";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                dt.Rows.Clear();
                dataGridViewLogs.Rows.Clear();

                MessageBox.Show("All logs have been truncated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error truncating logs: " + ex.Message);
            }
        }
    }
}
