﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PhoneBook.Controllers
{
        [RoutePrefix("api/Contacts")]
        public class ContactsController : ApiController
        {
            [Authorize]
            [Route("")]
            public IHttpActionResult Get()
            {
                return Ok(Contact.CreateContacts());
            }

        }

        #region Helpers

        public class Contact
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string PreferredContactMethod { get; set; }

            public static List<Contact> CreateContacts()
            {
                List<Contact> ContactList = new List<Contact>
            {
                new Contact { Name = "Taiseer Joudeh", Address = "123 Main", Email = "testname@email.com", PhoneNumber = "123-1234", PreferredContactMethod = "Phone" },
                new Contact { Name = "Tirzah", Address = "123 Main", Email = "testname@email.com", PhoneNumber = "123-1234", PreferredContactMethod = "Email" },
                new Contact { Name = "Kate", Address = "123 Main", Email = "testname@email.com", PhoneNumber = "123-1234", PreferredContactMethod = "Email" },
                new Contact { Name = "Mark", Address = "123 Main", Email = "testname@email.com", PhoneNumber = "123-1234", PreferredContactMethod = "Email" }
            };

                return ContactList;
            }
        }

        #endregion
    }

