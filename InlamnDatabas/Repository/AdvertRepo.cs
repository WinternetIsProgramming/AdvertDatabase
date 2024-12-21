using InlamnDatabas.Entities;
using System.Data;
using System.Data.SqlClient;

namespace InlamnDatabas.Repository
{
    public class AdvertRepo
    {
        public List<Advert> SearchAdverts(string condition, string searchCategory, string searchsorting)
        {
            string sql = "Select a.AdvertID, a.AdvertTitle, a.AdvertDescription, a.AdvertPrice, a.AdvertDate, c.CategoryID, c.CategoryName, u.UserId, u.Username, u.[Password] " +
                         "from Advert a " +
                         "inner join Category c on c.CategoryID = a.CategoryID " + 
                         "inner join[User] u on u.UserID = a.UserID " + 
                         "Where a.AdvertTitle like @searchcondition and c.CategoryName like @categorycondition";

            List<SqlParameter> parameters = new List<SqlParameter>();

            switch (searchsorting)
            {
                case "Date (oldest first)":
                    sql += " order by a.AdvertDate asc";
                    break;
                case "Date (newest first)":
                    sql += " order by a.AdvertDate desc";
                    break;
                case "Price (lowest first)":
                    sql += " order by a.AdvertPrice asc";
                    break;
                case "Price (highest first)":
                    sql += " order by a.AdvertPrice desc";
                    break;
            }

            parameters.Add(new SqlParameter("@searchcondition", "%" + condition + "%"));
            parameters.Add(new SqlParameter("@categorycondition", searchCategory));
           

            DataTable data = DataContext.ExecuteCommandReturnTable(sql, parameters);


            //Mapping the adverts
            List<Advert> adverts = new List<Advert>();

            foreach(DataRow row in data.Rows)
            {
                //Mapping category
                Category category = new Category((int)row.ItemArray[5], row.ItemArray[6].ToString());
                
                //Mapping user
                User user = new User((int)row.ItemArray[7], row.ItemArray[8].ToString(), row.ItemArray[9].ToString());

                adverts.Add(new Advert((int)row.ItemArray[0], row.ItemArray[1].ToString(), row.ItemArray[2].ToString(), (int)row.ItemArray[3], 
                                       (DateTime)row.ItemArray[4], user, category));
            }

            return adverts;
        }

        public List<Advert> GetAdvertDesc(int advertId)
        {
            string sql = "Select a.AdvertID, a.AdvertTitle, a.AdvertDescription, a.AdvertPrice, a.AdvertDate, c.CategoryID, c.CategoryName, u.UserId, u.Username, u.[Password] " +
                         "from Advert a " +
                         "inner join Category c on c.CategoryID = a.CategoryID " +
                         "inner join[User] u on u.UserID = a.UserID " +
                         "where a.AdvertId like @selectedadvert";

            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@selectedadvert", advertId));

            DataTable data = DataContext.ExecuteCommandReturnTable(sql, parameters);

            List<Advert> adverts = new List<Advert>();

            foreach (DataRow row in data.Rows)
            {
                //Mapping category
                Category category = new Category((int)row.ItemArray[5], row.ItemArray[6].ToString());

                //Mapping user
                User user = new User((int)row.ItemArray[7], row.ItemArray[8].ToString(), row.ItemArray[9].ToString());

                adverts.Add(new Advert((int)row.ItemArray[0], row.ItemArray[1].ToString(), row.ItemArray[2].ToString(), (int)row.ItemArray[3],
                                       (DateTime)row.ItemArray[4], user, category));
            }

            return adverts;
        }

        public List<Advert> GetUserAdverts(int userid)
        {
            string sql = "Select a.AdvertID, a.AdvertTitle, a.AdvertDescription, a.AdvertPrice, a.AdvertDate, c.CategoryID, c.CategoryName, u.UserId, u.Username, u.[Password] " +
                         "from Advert a " +
                         "inner join Category c on c.CategoryID = a.CategoryID " +
                         "inner join[User] u on u.UserID = a.UserID " +
                         "where a.userid = @activeuser";

            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@activeuser", userid));

            DataTable data = DataContext.ExecuteCommandReturnTable(sql, parameters);

            List<Advert> adverts = new List<Advert>();

            foreach (DataRow row in data.Rows)
            {
                //Mapping category
                Category category = new Category((int)row.ItemArray[5], row.ItemArray[6].ToString());

                //Mapping user
                User user = new User((int)row.ItemArray[7], row.ItemArray[8].ToString(), row.ItemArray[9].ToString());

                adverts.Add(new Advert((int)row.ItemArray[0], row.ItemArray[1].ToString(), row.ItemArray[2].ToString(), (int)row.ItemArray[3],
                                       (DateTime)row.ItemArray[4], user, category));
            }

            return adverts;
        }

        public void SaveAdvert(string advertTitle, string advertDescription, string category, double price, int userId)
        {
            CategoryRepo repo = new();
            List<Category> categories = repo.GetCategoryId(category);

            string sql = "insert into Advert(adverttitle, AdvertDescription, AdvertPrice, AdvertDate, CategoryId, UserId) " +
                         "values (@title, @description, @price, @date, @categoryid, @userid)";

            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@title", advertTitle));
            parameters.Add(new SqlParameter("@description", advertDescription));
            parameters.Add(new SqlParameter("@price", price));
            parameters.Add(new SqlParameter("@date", DateTime.Now.Date));
            parameters.Add(new SqlParameter("@categoryid", categories[0].CategoryID));
            parameters.Add(new SqlParameter("@userid", userId));

            DataContext.ExecuteCommandVoid(sql, parameters);
        }

        public void UpdateAdvert(string advertTitle, string advertDescription, string category, double price, int advertId)
        {
            CategoryRepo repo = new();
            List<Category> categories = repo.GetCategoryId(category);

            string sql = "update advert " +
                         "set AdvertTitle = @title, AdvertDescription = @description, AdvertPrice = @price, CategoryID = @category " +
                         "where advertid = @id";

            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@title", advertTitle));
            parameters.Add(new SqlParameter("@description", advertDescription));
            parameters.Add(new SqlParameter("@price", price));
            parameters.Add(new SqlParameter("@id", advertId));
            parameters.Add(new SqlParameter("@category", categories[0].CategoryID));

            DataContext.ExecuteCommandVoid(sql, parameters);
        }

        public void DeleteAdvert(int advertId)
        {
            string sql = "delete " +
                         "from Advert " +
                         "where advertid = @conditionid";

            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@conditionid", advertId));

            DataContext.ExecuteCommandVoid(sql, parameters);
        }
    }
}
