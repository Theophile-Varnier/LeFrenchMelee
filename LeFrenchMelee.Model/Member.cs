using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace LeFrenchMelee.Model
{
    [Table("Member")]
    public class Member
    {
        [Key]
        public virtual int Id { get; set; }

        public virtual string Pseudo { get; set; }

        public virtual string Password { get; protected set; }

        [NotMapped]
        public virtual string ClearPassword
        {
            set
            {
                byte[] array = Encoding.UTF8.GetBytes(value);
                SHA256Managed sha256 = new SHA256Managed();
                Password = string.Join(string.Empty, sha256.ComputeHash(array).Select(b => string.Format("{0:x2}", b)));
            }
        }
    }
}
