using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccess
{
    public class FacebookAccount
    {
        AutoGolikeEntities fbAccount;
        public FacebookAccount()
        {
            fbAccount = new AutoGolikeEntities();
        }
        public List<fbAccount> getAllFbAccount()
        {
            return fbAccount.fbAccounts.ToList();
        }
        public void addFbAccount(fbAccount addFbAccount)
        {
            fbAccount.fbAccounts.Add(addFbAccount);
        }
        public bool updateGlAccount(int fbId, int fbUid ,string fbPassword, string fb2Fa)
        {
            bool f = false;
            try
            {
                fbAccount fbaccount = fbAccount.fbAccounts.Find(fbId);
                fbaccount.fbUid = fbUid;
                fbaccount.fbPassword = fbPassword;
                fbaccount.fb2Fa = fb2Fa;
                fbAccount.SaveChanges();
                return f = true;
            }
            catch (Exception)
            {
                return f;

            }
        }
        public bool deleteFbAccount(int fbId)
        {
            bool f = false;
            try
            {
                var x = (from y in fbAccount.fbAccounts
                         orderby y.fiID descending
                         select y).FirstOrDefault();
                fbAccount.fbAccounts.Remove(x);
                fbAccount.SaveChanges();
                return f = true;
            }
            catch (Exception)
            {
                return f;
            }
        }
    }
}
