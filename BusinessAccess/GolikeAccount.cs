using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessAccess
{

    public class GolikeAccount
    {
        AutoGolikeEntities glAccount;
        public GolikeAccount()
        {
            glAccount = new AutoGolikeEntities();
        }
        public List<glAccount> getAllGlAccount()
        {
            return glAccount.glAccounts.ToList();
        }
        public void addGlAccount(glAccount addGlAccount)
        {
            glAccount.glAccounts.Add(addGlAccount);
        }
        public bool updateGlAccount(int glId, string glUsername, string glPassword)
        {
            bool f = false;
            try
            {
                glAccount glaccount = glAccount.glAccounts.Find(glId);
                glaccount.glUsername = glUsername;
                glaccount.glPassword = glPassword;
                glAccount.SaveChanges();
                return f = true;
            }
            catch (Exception)
            {
                return f;

            }
        }
        public bool deleteGlAccount(int glId)
        {
            bool f = false;
            try
            {
                var x = (from y in glAccount.glAccounts
                         orderby y.glId descending
                         select y).FirstOrDefault();
                glAccount.glAccounts.Remove(x);
                glAccount.SaveChanges();
                return f = true;
            }
            catch (Exception)
            {
                return f;
            }
        }
    }
}
