using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.DTO;

namespace WebApplication1.Service;

public class Mapper
{
      public Root MapRoot2ToRoot(RootRequest root2)
      {
          if (root2 == null) throw new Exception("the API response from the request was null");
            
            Root result = new Root
            {
                header = new Header
                {
                    // Header can be filled as per your requirements.
                },
                payload = new Payload
                {
                    key = new Key
                    {
                        // Key can be filled as per your requirements.
                    },
                    person = new Person
                    {
                        timeline = new Timeline
                        {
                            Address = new List<Address>
                            {
                                new Address
                                {
                                    Value = root2.details.address,
                                    ValidFrom = DateTime.Now.ToString("yyyy-MM-dd")
                                }
                            },
                            Address2 = new List<Address2>
                            {
                                new Address2
                                {
                                    Value = root2.details.address2,
                                    ValidFrom = DateTime.Now.ToString("yyyy-MM-dd")
                                }
                            },
                            Email = new List<Email>
                            {
                                new Email
                                {
                                    Value = root2.email,
                                    ValidFrom = DateTime.Now.ToString("yyyy-MM-dd")
                                }
                            },
                            LastName = new List<LastName>
                            {
                                new LastName
                                {
                                    Value = root2.lastName,
                                    ValidFrom = DateTime.Now.ToString("yyyy-MM-dd")
                                }
                            },
                            FirstName = new List<FirstName>
                            {
                                new FirstName
                                {
                                    Value = root2.firstName,
                                    ValidFrom = DateTime.Now.ToString("yyyy-MM-dd")
                                }
                            },
                            Birthdate = new List<Birthdate>
                            {
                                new Birthdate
                                {
                                    Value = root2.birthdate,
                                    ValidFrom = DateTime.Now.ToString("yyyy-MM-dd")
                                }
                            },
                            SSN = new List<SSN>
                            {
                                new SSN
                                {
                                    Value = root2.details.ssn,
                                    ValidFrom = DateTime.Now.ToString("yyyy-MM-dd")
                                }
                            },
                            PhoneMobile = new List<PhoneMobile>
                            {
                                new PhoneMobile
                                {
                                    Value = root2.details.phoneMobile,
                                    ValidFrom = DateTime.Now.ToString("yyyy-MM-dd")
                                }
                            },
                            Gender = new List<Gender>
                            {
                                new Gender
                                {
                                    Value = root2.gender,
                                    ValidFrom = DateTime.Now.ToString("yyyy-MM-dd")
                                }
                            },
                            Country = new List<Country>
                            {
                                new Country
                                {
                                    Value = root2.details.country,
                                    ValidFrom = DateTime.Now.ToString("yyyy-MM-dd")
                                }
                            },
                            City = new List<City>
                            {
                                new City
                                {
                                    Value = root2.details.city,
                                    ValidFrom = DateTime.Now.ToString("yyyy-MM-dd")
                                }
                            },
                            Zip = new List<Zip>
                            {
                                new Zip
                                {
                                    Value = root2.details.zip,
                                    ValidFrom = DateTime.Now.ToString("yyyy-MM-dd")
                                }
                            },
                            Nationality = new List<Nationality>
                            {
                                new Nationality
                                {
                                    Value = root2.details.nationality,
                                    ValidFrom = root2.details.nationality
                                    }
                                },
                            PositionListName = root2.positionList.Select(pl => new PositionListName
                            {
                                Value = pl.name,
                                ValidFrom = DateTime.Now.ToString("yyyy-MM-dd")
                            }).ToList()
                        }
                    },
                    employee = null, // Placeholder. Adjust if needed.
                    employment = null // Placeholder. Adjust if needed.
                }
            };

            return result;
      }
}

      
