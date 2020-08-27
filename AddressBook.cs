using System;
using System.Collections.Generic;

namespace address_book
{
  class AddressBook
  {
    // Instantiating dictionary to hold contacts in <key (email), value (Contact class)> pairs
    public Dictionary<string, Contact> ContactList = new Dictionary<string, Contact>();

    // AddressBook method to add new contact to contact list dictionary
    public void AddContact(Contact aContact)
    {
      ContactList.Add(aContact.Email, aContact);
    }

    // AddressBook method to get contact matching email in argument
    public Contact GetByEmail(string email)
    {
      return ContactList[email];
    }
  }
}