namespace AddressBook
{
    class BookEntry
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }


        public BookEntry(string firstName, string lasName, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lasName;
            PhoneNumber = phoneNumber;
        }
    }
}
