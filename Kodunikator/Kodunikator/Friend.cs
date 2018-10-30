using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodunikator
{
    /// <summary>
    /// Klasa przyjaciela, pełni role kontaktu z którym możemy pisać. Zawiera jego FB ID, które zapewnia komunikacje oraz nazwe użytkownika, która jest wyświetlana na liście przyjaciół.
    /// </summary>
    class Friend
    {
        public string nickname; // Nazwa przyjaciela, która będzie wyświetlana w liście przyjaciół
        public string fbID; // ID konta facebook przyjaciela

        public Friend() { }
        public Friend(string _nickname, string _fbID)
        {
            nickname = _nickname;
            fbID = _fbID;
        }
    }
}
