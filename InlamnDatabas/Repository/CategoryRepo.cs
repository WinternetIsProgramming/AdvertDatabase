using InlamnDatabas.Entities;
using System.Data;
using System.Data.SqlClient;

namespace InlamnDatabas.Repository
{
    public class CategoryRepo
    {
        public List<Category> GetCategories()
        {
            string sql = "Select CategoryID, CategoryName " +
                         "from Category";

            DataTable categories = DataContext.ExecuteCommandReturnTable(sql, new List<SqlParameter>());

            List<Category> result = new List<Category>();

            foreach(DataRow row in categories.Rows)
            {
                result.Add(new Category((int)row.ItemArray[0], row.ItemArray[1].ToString()));
            }

            return result;
        }

        public List<Category> GetCategoryId(string categoryName)
        {
            string sql = "Select CategoryID, CategoryName " +
                         "from Category " +
                         "where CategoryName = @conditionname";

            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@conditionname", categoryName));

            DataTable categories = DataContext.ExecuteCommandReturnTable(sql, parameters);

            List<Category> result = new List<Category>();

            foreach (DataRow row in categories.Rows)
            {
                result.Add(new Category((int)row.ItemArray[0], row.ItemArray[1].ToString()));
            }

            return result;
        }
    }
}
