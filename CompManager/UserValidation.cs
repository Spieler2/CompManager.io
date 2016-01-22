using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*TODO 
Auf die Api zugreifen und die Daten verschlüsselt übermitteln
oAuth
Daten lokal sicher speichern
    */
public class UserValidation
{
    private String username;
    private String password;

    public UserValidation(String _username, String _password)
    {
        username = _username;
        password = _password;
    }

    private bool checkData()
    {
        /*
            Die Daten gegen den Server abgleichen
            Schlüssel auf dem Rechner sicher speichern

            Wenn login erfolgreich, dann rückgabe von true sonst false;
        */
        return true;
    }

    private void safeSessionKey()
    {
        /*
            Daten sicher verwahren!
        */
    }

}