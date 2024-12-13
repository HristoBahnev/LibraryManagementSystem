namespace LibraryManagement.Members
{
    public class StudentMember : Member
    {
        public StudentMember(string name, string memberID, string membershipType, int borrowingLimit) : base(name, memberID, membershipType, borrowingLimit)
        {
        }
    }
}