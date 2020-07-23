using System;

namespace WrongSample
{
    class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public void Add()
        {
            try
            {
                if(string.IsNullOrEmpty(Name)) throw new ArgumentException(Name);
                if(string.IsNullOrEmpty(Description)) throw new ArgumentException(Description);

                using(var conn = new SqlConnection())
                {
                    var command = new SqlCommand
                    {
                        CommandText = "INSERT INTO PRODUCT(Name, Description) VALUES (@name, @description)"
                    };
                    command.Parameters.AddWithValue("name", Name);
                    command.Parameters.AddWithValue("description", Description);
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            } 
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
                throw ex;
            }
        }
    }
}
