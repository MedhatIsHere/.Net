namespace CsD07
{
    public enum Gender
    {
        M, 
        F  
    }


    [Flags]
    public enum SecurityPrivileges
    {
        None = 0,
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8,
        FullAccess = 16
    }
}
