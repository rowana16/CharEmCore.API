using CharEmCore.Repository.Helpers;
using CharEmCore.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmCore.Repository.Migrations
{
    public class Seed
    {
        private CharEmContext _context;
        static List<County> _counties;
        static List<City> _cities;
        static List<Location> _locations;
        static List<Address> _addresses;
        static List<Organization> _organizations;
        static List<Contact> _contacts;
        static List<ServiceType> _serviceTypes;
        static List<Service> _services;
        static List<OrganizationCounty> _organizationCounty;

        Dictionary<string, int> County;
        Dictionary<string, int> City;
        Dictionary<string, int> Address;
        Dictionary<string, int> ServiceType;
        Dictionary<string, int> Organization;
        Dictionary<string, int> Contact;
        

        public Seed(CharEmContext context)
        {
            _context = context;
            _counties = new List<County>
            {
                new County { Name = "Emmet"},
                new County { Name = "Charlevoix"},
                new County { Name = "Antrim"},
                new County { Name = "Cheboygan"},
                new County { Name = "Otsego"},
                new County { Name = "None"}
            };
        }

        private void CreateCities()
        {
            _cities = new List<City>
            {
                new City { Name = "Alanson", CountyId = County["Emmet"]},
                new City { Name = "Alba", CountyId = County["Antrim"]},
                new City { Name = "Bellaire", CountyId = County["Antrim"]},
                new City { Name = "Boyne City", CountyId = County["Charlevoix"]},
                new City { Name = "Boyne Falls", CountyId = County["Charlevoix"]},
                new City { Name = "Central Lake", CountyId = County["Antrim"]},
                new City { Name = "Charlevoix", CountyId = County["Charlevoix"]},
                new City { Name = "Cheboygan", CountyId = County["Cheboygan"]},
                new City { Name = "East Jordan", CountyId = County["Charlevoix"]},
                new City { Name = "Ellsworth  ", CountyId = County["Antrim"]},
                new City { Name = "Gaylord", CountyId = County["Otsego"]},
                new City { Name = "Harbor Springs", CountyId = County["Emmet"]},
                new City { Name = "Mackinaw", CountyId = County["Cheboygan"]},
                new City { Name = "Mancelona", CountyId = County["Antrim"]},
                new City { Name = "None", CountyId = County["None"]},
                new City { Name = "Pellston", CountyId = County["Emmet"]},
                new City { Name = "Petoskey", CountyId = County["Emmet"]},
                new City { Name = "Vanderbilt", CountyId = County["Otsego"]},
                new City { Name = "Wolverine", CountyId = County["Cheboygan"]}
            };
        }

        void CreateLocations()
        {            
            _locations = new List<Location>
            {
                new Location { Name = "Resident - County - Emmet", CountyId = County["Antrim"], CityId = City["None"], IsSchool = false},
                new Location { Name = "Resident - County - Charlevoix", CountyId = County["Charlevoix"], CityId = City["None"], IsSchool = false},
                new Location { Name = "Resident - County - Antrim", CountyId = County["Cheboygan"], CityId = City["None"], IsSchool = false},
                new Location { Name = "Resident - County - Cheboygan", CountyId = County["Emmet"], CityId = City["None"], IsSchool = false},
                new Location { Name = "Resident - County - Otsego", CountyId = County["Otsego"], CityId = City["None"], IsSchool = false},
                new Location { Name = "Resident - City - Alanson", CountyId = County["Emmet"], CityId = City["Alanson"], IsSchool = false},
                new Location { Name = "Resident - City - Alba", CountyId = County["Antrim"], CityId = City["Alba"], IsSchool = false},
                new Location { Name = "Resident - City - Bellaire", CountyId = County["Antrim"], CityId = City["Bellaire"], IsSchool = false},
                new Location { Name = "Resident - City - Boyne City", CountyId = County["Charlevoix"], CityId = City["Boyne City"], IsSchool = false},
                new Location { Name = "Resident - City - Boyne Falls", CountyId = County["Charlevoix"], CityId = City["Boyne Falls"], IsSchool = false},
                new Location { Name = "Resident - City - Central Lake", CountyId = County["Antrim"], CityId = City["Central Lake"], IsSchool = false},
                new Location { Name = "Resident - City - Cheboygan", CountyId = County["Cheboygan"], CityId = City["Cheboygan"], IsSchool = false},
                new Location { Name = "Resident - City - East Jordan", CountyId = County["Charlevoix"], CityId = City["East Jordan"], IsSchool = false},
                new Location { Name = "Resident - City - Ellsworth  ", CountyId = County["Antrim"], CityId = City["Ellsworth  "], IsSchool = false},
                new Location { Name = "Resident - City - Gaylord", CountyId = County["Otsego"], CityId = City["Gaylord"], IsSchool = false},
                new Location { Name = "Resident - City - Harbor Springs", CountyId = County["Emmet"], CityId = City["Harbor Springs"], IsSchool = false},
                new Location { Name = "Resident - City - Mackinaw", CountyId = County["Cheboygan"], CityId = City["Mackinaw"], IsSchool = false},
                new Location { Name = "Resident - City - Mancelona", CountyId = County["Antrim"], CityId = City["Mancelona"], IsSchool = false},
                new Location { Name = "Resident - City - Pellston", CountyId = County["Emmet"], CityId = City["Pellston"], IsSchool = false},
                new Location { Name = "Resident - City - Petoskey", CountyId = County["Emmet"], CityId = City["Petoskey"], IsSchool = false},
                new Location { Name = "Resident - City - Vanderbilt", CountyId = County["Otsego"], CityId = City["Vanderbilt"], IsSchool = false},
                new Location { Name = "Resident - City - Wolverine", CountyId = County["Cheboygan"], CityId = City["Wolverine"], IsSchool = false},
                new Location { Name = "Alanson School", CountyId = County["Emmet"], CityId = City["Alanson"], IsSchool = true},
                new Location { Name = "Alba Public School", CountyId = County["Antrim"], CityId = City["Alba"], IsSchool = true},
                new Location { Name = "Bellaire Elementary", CountyId = County["Antrim"], CityId = City["Bellaire"], IsSchool = true},
                new Location { Name = "Bellaire Middle / High", CountyId = County["Antrim"], CityId = City["Bellaire"], IsSchool = true},
                new Location { Name = "Boyne City Elementary", CountyId = County["Charlevoix"], CityId = City["Boyne City"], IsSchool = true},
                new Location { Name = "Boyne City High", CountyId = County["Charlevoix"], CityId = City["Boyne City"], IsSchool = true},
                new Location { Name = "Boyne City Middle", CountyId = County["Charlevoix"], CityId = City["Boyne City"], IsSchool = true},
                new Location { Name = "Boyne Falls School", CountyId = County["Charlevoix"], CityId = City["Boyne Falls"], IsSchool = true},
                new Location { Name = "Central Lake Elementary", CountyId = County["Antrim"], CityId = City["Central Lake"], IsSchool = true},
                new Location { Name = "Central Lake Middle / High", CountyId = County["Antrim"], CityId = City["Central Lake"], IsSchool = true},
                new Location { Name = "Cheboygan - East Elementary", CountyId = County["Cheboygan"], CityId = City["Cheboygan"], IsSchool = true},
                new Location { Name = "Cheboygan - West Elementary", CountyId = County["Cheboygan"], CityId = City["Cheboygan"], IsSchool = true},
                new Location { Name = "Cheboygan High", CountyId = County["Cheboygan"], CityId = City["Cheboygan"], IsSchool = true},
                new Location { Name = "Cheboygan Middle", CountyId = County["Cheboygan"], CityId = City["Cheboygan"], IsSchool = true},
                new Location { Name = "East Jordan Elementary", CountyId = County["Charlevoix"], CityId = City["East Jordan"], IsSchool = true},
                new Location { Name = "East Jordan High", CountyId = County["Charlevoix"], CityId = City["East Jordan"], IsSchool = true},
                new Location { Name = "East Jordan Middle", CountyId = County["Charlevoix"], CityId = City["East Jordan"], IsSchool = true},
                new Location { Name = "Ellsworth - Hillcrest Elementary", CountyId = County["Antrim"], CityId = City["Ellsworth  "], IsSchool = true},
                new Location { Name = "Ellsworth - Prairie View Elementary", CountyId = County["Antrim"], CityId = City["Ellsworth  "], IsSchool = true},
                new Location { Name = "Ellsworth High", CountyId = County["Antrim"], CityId = City["Ellsworth  "], IsSchool = true},
                new Location { Name = "Ellsworth Middle", CountyId = County["Antrim"], CityId = City["Ellsworth  "], IsSchool = true},
                new Location { Name = "Gaylord - North Ohio Elementary", CountyId = County["Otsego"], CityId = City["Gaylord"], IsSchool = true},
                new Location { Name = "Gaylord - South Maple Elementary", CountyId = County["Otsego"], CityId = City["Gaylord"], IsSchool = true},
                new Location { Name = "Gaylord High", CountyId = County["Otsego"], CityId = City["Gaylord"], IsSchool = true},
                new Location { Name = "Gaylord Intermediate", CountyId = County["Otsego"], CityId = City["Gaylord"], IsSchool = true},
                new Location { Name = "Gaylord Middle", CountyId = County["Otsego"], CityId = City["Gaylord"], IsSchool = true},
                new Location { Name = "Harbor Springs - Black Bird Elementary", CountyId = County["Emmet"], CityId = City["Harbor Springs"], IsSchool = true},
                new Location { Name = "Harbor Springs - Shay Elementary", CountyId = County["Emmet"], CityId = City["Harbor Springs"], IsSchool = true},
                new Location { Name = "Harbor Springs High", CountyId = County["Emmet"], CityId = City["Harbor Springs"], IsSchool = true},
                new Location { Name = "Harbor Springs Middle", CountyId = County["Emmet"], CityId = City["Harbor Springs"], IsSchool = true},
                new Location { Name = "Mackinaw Elementary", CountyId = County["Cheboygan"], CityId = City["Mackinaw"], IsSchool = true},
                new Location { Name = "Mackinaw Middle / High", CountyId = County["Cheboygan"], CityId = City["Mackinaw"], IsSchool = true},
                new Location { Name = "Mancelona Elementary", CountyId = County["Antrim"], CityId = City["Mancelona"], IsSchool = true},
                new Location { Name = "Mancelona High", CountyId = County["Antrim"], CityId = City["Mancelona"], IsSchool = true},
                new Location { Name = "Mancelona Middle", CountyId = County["Antrim"], CityId = City["Mancelona"], IsSchool = true},
                new Location { Name = "Pellston Elementary", CountyId = County["Emmet"], CityId = City["Pellston"], IsSchool = true},
                new Location { Name = "Pellston Middle / High", CountyId = County["Emmet"], CityId = City["Pellston"], IsSchool = true},
                new Location { Name = "Petoskey - Central Elementary", CountyId = County["Emmet"], CityId = City["Petoskey"], IsSchool = true},
                new Location { Name = "Petoskey - Lincoln Elementary", CountyId = County["Emmet"], CityId = City["Petoskey"], IsSchool = true},
                new Location { Name = "Petoskey - Ottawa Elementary", CountyId = County["Emmet"], CityId = City["Petoskey"], IsSchool = true},
                new Location { Name = "Petoskey - Sheridan Elementary", CountyId = County["Emmet"], CityId = City["Petoskey"], IsSchool = true},
                new Location { Name = "Petoskey High", CountyId = County["Emmet"], CityId = City["Petoskey"], IsSchool = true},
                new Location { Name = "Petoskey Middle", CountyId = County["Emmet"], CityId = City["Petoskey"], IsSchool = true},
                new Location { Name = "Vanderbilt Area School", CountyId = County["Otsego"], CityId = City["Vanderbilt"], IsSchool = true},
                new Location { Name = "Wolverine Elementary", CountyId = County["Cheboygan"], CityId = City["Wolverine"], IsSchool = true},
                new Location { Name = "Wolverine High", CountyId = County["Cheboygan"], CityId = City["Wolverine"], IsSchool = true},
                };
        }

        void CreateAddresses()
        {
            _addresses = new List<Address>
            {
                new Address {Address1 = "2350 Mitchell Park Drive", CityId = City["Petoskey"], State = "MI", Zip = "49770", CountyId = County["Emmet"]},
                new Address {Address1 = "423 Porter Street", CityId = City["Petoskey"], State = "MI", Zip = "49770", CountyId = County["Emmet"]},
                new Address {Address1 = "8791 McBride Park Court", CityId = City["Harbor Springs"], State = "MI", Zip = "49737", CountyId = County["Emmet"]},
                new Address {Address1 = "415 State St.", CityId = City["Petoskey"], State = "MI", Zip = "49770", CountyId = County["Emmet"]},
                new Address {Address1 = "220 West Garfield", CityId = City["Charlevoix"], State = "MI", Zip = "49711", CountyId = County["Charlevoix"]},
                new Address {Address1 = "03001 Church Road", CityId = City["Petoskey"], State = "MI", Zip = "49770", CountyId = County["Emmet"]},
                new Address {Address1 = "434 East Lake Street", CityId = City["Petoskey"], State = "Michigan", Zip = "49770", CountyId = County["Emmet"]}
            };
        }

        void CreateOrganizations()
        {
            _organizations = new List<Organization>
            {
                new Organization{ Name = "Big Brothers / Big Sisters", Details = "We Provide Children With Strong And Enduring, Professionally Supported 1-To-1 Relationships That Change Their Lives For The Better. Our Goal Is To Help Children Obtain Higher Aspirations, Greater Confidence, And Better Relationships; Avoid Risky Behaviors And Obtain Educational Success.  We Offer Mentoring Opportunities Throughout The Community, As Well As School-Based Mentoring Programs In Specific Elementary Schools.", AddressId = Address["2350 Mitchell Park Drive"], Phone = "231-313-7323", Email = "christie.strahan@bigsupnorth.com"},
                new Organization{ Name = "Women's Resource Center of N. Michigan", Details = "We Provide Violence Prevention Programs, Education And Employment Services, Education Support For 'Safe Bodies', Counseling Services For Domestic Violence And Sexual Assault, And Child Abuse / Child Sexual Assault Counseling. ", AddressId = Address["423 Porter Street"], Phone = "231.347.0067", Email = "info@wrcnm.org"},
                new Organization{ Name = "Manna Food Project", Details = "We Help To Feed The Hungry In Northern Michigan. We Operate A Food Bank Providing Low Cost Food To Partner Food Pantries And Community Kitchens, A Food Rescue Program Which Collects Perishable Food For Distribution To The Hungry, A Weekly Pantry Which Provides Food To Families, And The `Food 4 Kids` Program Which Distributes Backpacks Filled With Nutritional Food Items To Elementary Schools And Preschools To Help Carry At-Risk Students Through Each Weekend Of The School Year.", AddressId = Address["8791 McBride Park Court"], Phone = "231.675.5715", Email = "kbaker@mannafoodproject.org"},
                new Organization{ Name = "Northern Community Mediation", Details = "We Provide Programs Specific To Youth Including: Child Protection Mediation, Victim-Offender Reconciliation, School Attendance Mediation, First-Time Offender Shoplifting, And Preventative Shoplifting", AddressId = Address["415 State St."], Phone = "231.487.1771", Email = "jane@northernmediation.org"},
                new Organization{ Name = "Health Dept. of NW Michigan", Details = "We Run School Based Health Centers, The Safe Youth Coalition, And A Home Visiting Program For Pregnant And Parenting Youth.. We Provide Programming To Prevent Substance Use Disorder, Improve Nutrition Education, And Provide Hearing And Vision Screening, Immunizations, Sexual Health Services, Children'S Healthcare Access Program, Health Insurance Assistance.  We Also Help To Develop Policy, Systems And Environment Changes With Schools Including: Safe Routes To Schools, Smarter Lunchroom, And School Wellness Policies. ", AddressId = Address["220 West Garfield"], Phone = "18004324121", Email = "n.kasiborski@nwhealth.org"},
                new Organization{ Name = "Camp Daggett", Details = "We Provide Programs Specific To Youth Including: Traditional Summer Camp, Leadership Programs And The School Climate Program", AddressId = Address["03001 Church Road"], Phone = "231-347-9742", Email = "brent.marlatt@campdaggett.org"},
                new Organization{ Name = "YMCA", Details = "We Provide Transformational Youth Programs That Develop Character, Build Self Confidence, Promote Healthy Lifestyle Choices. We Offer: An Afterschool Childcare Program For Students K-5, A Summer Day Camp For Students Ages 5-15, Physical Programs For Ages 3-4, Y Winners Basketball & Soccer, Y Karate, Y Archery, Jr. & First Lego League, Art Programs And More! The Y Makes Sure That Everyone, Regardless Of Age, Income Or Background, Has The Opportunity To Learn Grown And Thrive. ", AddressId = Address["434 East Lake Street"], Phone = "231-348-8393", Email = "csmith@ymcan.org"}
            };
        }

        void CreateContacts()
        {
            _contacts = new List<Contact>
            {
                new Contact{ Title = "Ms.", FirstName = "Christie ", LastName = "Ward-Strahan", DisplayName="Christie Ward-Strahan", Email = "christie.strahan@bigsupnorth.com", Phone = "231-313-7323", AddressId = Address["2350 Mitchell Park Drive"] },
                new Contact{ Title = "", FirstName = "Main ", LastName = "Office", DisplayName="Main Office", Email = "info@wrcnm.org", Phone = "231.347.0067", AddressId = Address["423 Porter Street"] },
                new Contact{ Title = "Ms.", FirstName = "Kim ", LastName = "Baker", DisplayName="Kim Baker", Email = "kbaker@mannafoodproject.org", Phone = "231.675.5715", AddressId = Address["8791 McBride Park Court"] },
                new Contact{ Title = "Ms.", FirstName = "Jane ", LastName = "Millar", DisplayName="Jane Millar", Email = "jane@northernmediation.org", Phone = "231.487.1771", AddressId = Address["415 State St."] },
                new Contact{ Title = "Ms.", FirstName = "Natalie ", LastName = "Kasiborski", DisplayName="Natalie Kasiborski", Email = "n.kasiborski@nwhealth.org", Phone = "18004324121", AddressId = Address["220 West Garfield"] },
                new Contact{ Title = "Mr.", FirstName = "Brent ", LastName = "Marlatt", DisplayName="Brent Marlatt", Email = "brent.marlatt@campdaggett.org", Phone = "231-347-9742", AddressId = Address["03001 Church Road"] },
                new Contact{ Title = "Mr.", FirstName = "Christian ", LastName = "Smith", DisplayName="Christian Smith", Email = "csmith@ymcan.org", Phone = "231-348-8393", AddressId = Address["434 East Lake Street"] },
            };
        }

        void CreateServiceTypes()
        {
            _serviceTypes = new List<ServiceType>
            {
                new ServiceType {  Name ="Behavioral Services", Description = " "},
                new ServiceType {  Name ="Child Care", Description = " "},
                new ServiceType {  Name ="Counseling", Description = " "},
                new ServiceType {  Name ="Educational Services", Description = " "},
                new ServiceType {  Name ="Financial Services", Description = " "},
                new ServiceType {  Name ="Food Services", Description = " "},
                new ServiceType {  Name ="Mentoring Services", Description = " "},
                new ServiceType {  Name ="Recreation and Enrichment", Description = " "},
                new ServiceType {  Name ="Substance Use and Health Services", Description = " "},
                new ServiceType {  Name ="Volunteering", Description = " "}
            };
        }

        void CreateServices()
        {
            _services = new List<Service>
            {
                new Service{ Name = "Jr. FIRST Lego League", Details = " ", ServiceTypeId = ServiceType["Recreation and Enrichment"], OrganizationId = Organization["YMCA"],LeadContactId = Contact["csmith@ymcan.org"]},
                new Service{ Name = "FIRST Lego League", Details = " ", ServiceTypeId = ServiceType["Recreation and Enrichment"], OrganizationId = Organization["YMCA"],LeadContactId = Contact["csmith@ymcan.org"]},
                new Service{ Name = "Art Programs", Details = " ", ServiceTypeId = ServiceType["Recreation and Enrichment"], OrganizationId = Organization["YMCA"],LeadContactId = Contact["csmith@ymcan.org"]},
                new Service{ Name = "After School Child Care", Details = " ", ServiceTypeId = ServiceType["Child Care"], OrganizationId = Organization["YMCA"],LeadContactId = Contact["csmith@ymcan.org"]},
                new Service{ Name = "Basketball", Details = " ", ServiceTypeId = ServiceType["Recreation and Enrichment"], OrganizationId = Organization["YMCA"],LeadContactId = Contact["csmith@ymcan.org"]},
                new Service{ Name = "Soccer", Details = " ", ServiceTypeId = ServiceType["Recreation and Enrichment"], OrganizationId = Organization["YMCA"],LeadContactId = Contact["csmith@ymcan.org"]},
                new Service{ Name = "Karate", Details = " ", ServiceTypeId = ServiceType["Recreation and Enrichment"], OrganizationId = Organization["YMCA"],LeadContactId = Contact["csmith@ymcan.org"]},
                new Service{ Name = "Archery", Details = " ", ServiceTypeId = ServiceType["Recreation and Enrichment"], OrganizationId = Organization["YMCA"],LeadContactId = Contact["csmith@ymcan.org"]},
                new Service{ Name = "Community-Based Mentoring (Big Brother / Big Sister)", Details = " ", ServiceTypeId = ServiceType["Mentoring Services"], OrganizationId = Organization["Big Brothers / Big Sisters"],LeadContactId = Contact["christie.strahan@bigsupnorth.com"]},
                new Service{ Name = "School-Based Mentoring (Big Brother / Big Sister)", Details = " ", ServiceTypeId = ServiceType["Mentoring Services"], OrganizationId = Organization["Big Brothers / Big Sisters"],LeadContactId = Contact["christie.strahan@bigsupnorth.com"]},
                new Service{ Name = "School Attendance Mediation", Details = " ", ServiceTypeId = ServiceType["Behavioral Services"], OrganizationId = Organization["Northern Community Mediation"],LeadContactId = Contact["jane@northernmediation.org"]},
                new Service{ Name = "Incorrigible Student Mediation", Details = " ", ServiceTypeId = ServiceType["Behavioral Services"], OrganizationId = Organization["Northern Community Mediation"],LeadContactId = Contact["jane@northernmediation.org"]},
                new Service{ Name = "Child Abuse and Neglect Mediation", Details = " ", ServiceTypeId = ServiceType["Behavioral Services"], OrganizationId = Organization["Northern Community Mediation"],LeadContactId = Contact["jane@northernmediation.org"]},
                new Service{ Name = "First-Time Shoplifter Mediation", Details = " ", ServiceTypeId = ServiceType["Behavioral Services"], OrganizationId = Organization["Northern Community Mediation"],LeadContactId = Contact["jane@northernmediation.org"]},
                new Service{ Name = "Just the Facts – Violence Prevention Program", Details = " ", ServiceTypeId = ServiceType["Educational Services"], OrganizationId = Organization["Women's Resource Center of N. Michigan"],LeadContactId = Contact["info@wrcnm.org"]},
                new Service{ Name = "Coaching Boys Into Men", Details = " ", ServiceTypeId = ServiceType["Educational Services"], OrganizationId = Organization["Women's Resource Center of N. Michigan"],LeadContactId = Contact["info@wrcnm.org"]},
                new Service{ Name = "White Ribbon Basketball Games", Details = " ", ServiceTypeId = ServiceType["Recreation and Enrichment"], OrganizationId = Organization["Women's Resource Center of N. Michigan"],LeadContactId = Contact["info@wrcnm.org"]},
                new Service{ Name = "Classroom Training – Teachers", Details = " ", ServiceTypeId = ServiceType["Educational Services"], OrganizationId = Organization["Women's Resource Center of N. Michigan"],LeadContactId = Contact["info@wrcnm.org"]},
                new Service{ Name = "Anti-Bullying", Details = " ", ServiceTypeId = ServiceType["Behavioral Services"], OrganizationId = Organization["Women's Resource Center of N. Michigan"],LeadContactId = Contact["info@wrcnm.org"]},
                new Service{ Name = "Healthy Relationships", Details = " ", ServiceTypeId = ServiceType["Educational Services"], OrganizationId = Organization["Women's Resource Center of N. Michigan"],LeadContactId = Contact["info@wrcnm.org"]},
                new Service{ Name = "Before and After School Programs - Children's Learning Center", Details = " ", ServiceTypeId = ServiceType["Child Care"], OrganizationId = Organization["Women's Resource Center of N. Michigan"],LeadContactId = Contact["info@wrcnm.org"]},

            };
        }

        void CreateOrganizationCounty()
        {
            _organizationCounty = new List<OrganizationCounty>
            {
                new OrganizationCounty { OrganizationId = Organization["YMCA"], CountyId = County["Emmet"]},
                new OrganizationCounty { OrganizationId = Organization["YMCA"], CountyId = County["Charlevoix"]},
                new OrganizationCounty { OrganizationId = Organization["Northern Community Mediation"], CountyId = County["Emmet"]},
                new OrganizationCounty { OrganizationId = Organization["Northern Community Mediation"], CountyId = County["Charlevoix"]},
                new OrganizationCounty { OrganizationId = Organization["Women's Resource Center of N. Michigan"], CountyId = County["Emmet"]},
                new OrganizationCounty { OrganizationId = Organization["Women's Resource Center of N. Michigan"], CountyId = County["Charlevoix"]},
                new OrganizationCounty { OrganizationId = Organization["Women's Resource Center of N. Michigan"], CountyId = County["Antrim"]},
                new OrganizationCounty { OrganizationId = Organization["Women's Resource Center of N. Michigan"], CountyId = County["Cheboygan"]},
                new OrganizationCounty { OrganizationId = Organization["Women's Resource Center of N. Michigan"], CountyId = County["Otsego"]},
                new OrganizationCounty { OrganizationId = Organization["Big Brothers / Big Sisters"], CountyId = County["Emmet"]},
                new OrganizationCounty { OrganizationId = Organization["Big Brothers / Big Sisters"], CountyId = County["Charlevoix"]}
            };
        }

        public async Task SeedCounty()
        {
            if (!_context.Counties.Any())
            {
                _context.AddRange(_counties);
                await _context.SaveChangesAsync();
            }

            County = _context.Counties.ToDictionary(p => p.Name, p => p.Id);
        }


        public async Task SeedCity()
        {
            CreateCities();  // Create Dependent List

            if (!_context.Cities.Any())
            {
                _context.AddRange(_cities);  //Seed List
                await _context.SaveChangesAsync();
            }

            City = _context.Cities.ToDictionary(p => p.Name, p => p.Id); //Create Dictionary with New Ids
        }

        public async Task SeedLocation()
        {
            CreateLocations();

            if (!_context.Locations.Any())
            {
                _context.AddRange(_locations);
                await _context.SaveChangesAsync();
            }
        }

        public async Task SeedAddress()
        {
            CreateAddresses();

            if (!_context.Addresses.Any())
            {
                _context.AddRange(_addresses);
                await _context.SaveChangesAsync();
            }

            Address = _context.Addresses.ToDictionary(p => p.Address1, p => p.Id);
        }

        public async Task SeedOrganization()
        {
            CreateOrganizations();

            if (!_context.Organizations.Any())
            {
                _context.AddRange(_organizations);
                await _context.SaveChangesAsync();
            }
            Organization = _context.Organizations.ToDictionary(p => p.Name, p => p.Id);
        }

        public async Task SeedServiceType()
        {
            CreateServiceTypes();

            if (!_context.ServiceTypes.Any())
            {
                _context.AddRange(_serviceTypes);
                await _context.SaveChangesAsync();
            }
            ServiceType = _context.ServiceTypes.ToDictionary(p => p.Name, p => p.Id);
        }

        public async Task SeedContact()
        {
            CreateContacts();

            if (!_context.Contacts.Any())
            {
                _context.AddRange(_contacts);
                await _context.SaveChangesAsync();
            }

            Contact = _context.Contacts.ToDictionary(p => p.Email, p => p.Id);
        }

        public async Task SeedSevice()
        {
            CreateServices();

            if (!_context.Services.Any())
            {
                _context.AddRange(_services);
                await _context.SaveChangesAsync();
            }
        }

        public async Task SeedOrganizationCounty()
        {
            CreateOrganizationCounty();
            if (!_context.OrganizationCounty.Any())
            {
                _context.AddRange(_organizationCounty);
                await _context.SaveChangesAsync();
            }
        }
    }
}
