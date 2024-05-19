
#region Single Responsibility Bad Example
//class SendMail
//{
//    public bool Send(string mail, string body)
//    {
//        if( IsMailAddressValid(mail) ) return true;
//        return false;
//    }

//    public bool IsMailAddressValid(string mail)
//    {
//        // some code for chek mail validation (regex)
//        return true;
//    }
//}

#endregion


#region Single Responsibility Good Example

class MailAddressValidation
{
    public bool IsMailAddressValid(string mail)
    {
        // some code for chek mail validation (regex)
        return true;
    }
}
class SendMail
{
    private MailAddressValidation _validation = new();
    public bool Send(string mail, string body)
    {
        if (_validation.IsMailAddressValid(mail)) return true;
        return false;
    }
}
#endregion



