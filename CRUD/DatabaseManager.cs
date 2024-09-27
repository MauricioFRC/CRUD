using System.Data;
using System.Data.SQLite;

namespace CRUD
{
    public class DatabaseManager
    {
        private string _databaseName;

        public DatabaseManager(string databaseName)
        {
            _databaseName = databaseName;
            EnsureDatabaseAndTables();
        }

        public void EnsureDatabaseAndTables()
        {
            if (!File.Exists(_databaseName))
            {
                // Si la base de datos NO EXISTE lo creamos
                SQLiteConnection.CreateFile(_databaseName);
            }

            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_databaseName};Version=3"))
            {
                conn.Open();

                // Crear Las Tablas
                string createTable = @"
                    CREATE TABLE IF NOT EXISTS usuarios (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        cid INTEGER NOT NULL UNIQUE,
                        nombres TEXT NOT NULL,
                        apellidos TEXT,
                        ntelf TEXT,
                        fecha_nacimiento DATE
                    );"
                ;

                using (SQLiteCommand cmd = new SQLiteCommand(createTable, conn)) 
                {
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        public void InsertUser(int cid, string nombres, string apellidos, string numTelefono, string fecNacimiento)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_databaseName};Version=3"))
                {
                    conn.Open();

                    // Insertar Usuarios
                    string insertUser = @"
                        INSERT INTO usuarios (cid, nombres, apellidos, ntelf, fecha_nacimiento)
                            VALUES (@cid, @nombres, @apellidos, @ntelf, @fecha_nacimiento)"
                    ;

                    using (SQLiteCommand cmd = new SQLiteCommand(insertUser, conn))
                    {
                        cmd.Parameters.AddWithValue("@cid", cid);
                        cmd.Parameters.AddWithValue("@nombres", nombres);
                        cmd.Parameters.AddWithValue("@apellidos", apellidos);
                        cmd.Parameters.AddWithValue("@ntelf", numTelefono);
                        cmd.Parameters.AddWithValue("@fecha_nacimiento", fecNacimiento);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Usuario Registrado Correctamente!");
                        }
                        catch (SQLiteException ex)
                        {
                            if (ex.ErrorCode == (int)SQLiteErrorCode.Constraint)
                            {
                                MessageBox.Show("La cédula de identidad ya existe!!!");
                            }
                            else
                            {
                                MessageBox.Show($"Se ha producido un error al registrar al usuario: {ex.Message}");
                            }
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }

        public void DeleteUser(int cid)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_databaseName};Version=3"))
                {
                    conn.Open();

                    // Insertar Usuarios
                    string deleteUser = @"
                        DELETE FROM usuarios WHERE cid = @cid"
                    ;

                    using (SQLiteCommand cmd = new SQLiteCommand(deleteUser, conn))
                    {
                        cmd.Parameters.AddWithValue("@cid", cid);
                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Se ha Eliminado Correctamente al Usuario!");
                        } 
                        else
                        {
                            MessageBox.Show("No se ha Encontrado al Usuario!!!");
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }
        
        public DataTable QueryUser()
        {
            string Query = "SELECT * FROM usuarios;";

            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_databaseName};Version=3"))
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(Query, conn);

                SQLiteDataAdapter data = new SQLiteDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                data.Fill(dataTable);

                return dataTable;
            }
        }

        public void UpdateUser(int cid, int cidActualizar, string nombres, string apellidos, string numTelefono, string fecNacimiento)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_databaseName};Version=3"))
                {
                    conn.Open();

                    // Insertar Usuarios
                    string updateUser = @"
                        UPDATE usuarios 
                        SET cid = @cid, nombres = @nombres, apellidos = @apellidos, ntelf = @ntelf, fecha_nacimiento = @fecha_nacimiento 
                        WHERE cid = @cidActualizar;"
                    ;

                    using (SQLiteCommand cmd = new SQLiteCommand(updateUser, conn))
                    {
                        cmd.Parameters.AddWithValue("@cid", cid);
                        cmd.Parameters.AddWithValue("@nombres", nombres);
                        cmd.Parameters.AddWithValue("@apellidos", apellidos);
                        cmd.Parameters.AddWithValue("@ntelf", numTelefono);
                        cmd.Parameters.AddWithValue("@fecha_nacimiento", fecNacimiento);
                        cmd.Parameters.AddWithValue("@cidActualizar", cidActualizar);
                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void SearchUser(int cid, TextBox cidRellenar, TextBox nombreRellenar, TextBox apellidoRellenar, TextBox numTelRellenar, TextBox fecNacRellenar)
        {
            // Buscar al usuario por número de cédula
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_databaseName};Version=3;"))
            {
                conn.Open();

                string search = "SELECT * FROM usuarios WHERE cid = @cid;";

                using (SQLiteCommand cmd = new SQLiteCommand(search, conn))
                {
                    cmd.Parameters.AddWithValue("@cid", cid);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Si se encuentra el usuario
                        {
                            DateTime dt = DateTime.Parse(reader["fecha_nacimiento"].ToString());

                            // Usa los TextBox existentes en el formulario
                            cidRellenar.Text = reader["cid"].ToString();
                            nombreRellenar.Text = reader["nombres"].ToString();
                            apellidoRellenar.Text = reader["apellidos"].ToString();
                            numTelRellenar.Text = reader["ntelf"].ToString();
                            fecNacRellenar.Text = dt.ToString("yyyy-MM-dd");

                            MessageBox.Show("Usuario Encontrado");
                        }
                        else
                        {
                            MessageBox.Show("No se Encontró al Usuario");
                        }
                    }
                }
            }
        }
    }
}
