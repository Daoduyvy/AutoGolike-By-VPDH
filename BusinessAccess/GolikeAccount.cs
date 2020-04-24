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
        GolikeEntities glAccount;
        public GolikeAccount()
        {
            glAccount = new GolikeEntities();
        }
       public List<GLAccount> getAllGlAccount()
        {
            return glAccount.GLAccounts.ToList();
        }
        public void GetData()
        {
                var q = (from a in glAccount.GLAccounts
                         select a).ToList();
        }
        public void addGlAccount(GLAccount addGlAccount)
        {
            glAccount.GLAccounts.Add(addGlAccount);
        }
        public bool updateGlAccount(int glId, string glUsername, long glPassword)
        {
            bool f = false;
            try
            {
                GLAccount glaccount = glAccount.GLAccounts.Find(glId);
                glaccount.glUsername = glUsername;
                glaccount.glPassword = glPassword;
                glAccount.SaveChanges();
                return f = true;
            }
            catch (Exception ex)
            {
                return f;
                
            }
        }
        public bool deleteGlAccount(int glId)
        {
            bool f = false;
            try
            {
                var x = (from y in glAccount.GLAccounts
                         orderby y.glID descending
                         select y).FirstOrDefault();
                glAccount.GLAccounts.Remove(x);
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
