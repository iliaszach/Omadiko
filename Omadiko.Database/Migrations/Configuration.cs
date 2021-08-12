namespace Omadiko.Database.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Omadiko.Entities;
    using Omadiko.Entities.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Omadiko.Database.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Omadiko.Database.ApplicationDbContext context)
        {
            //Seeding

            Country c1 = new Country() { Name = "Greece" };
            Country c2 = new Country() { Name = "Italy" };
            Country c3 = new Country() { Name = "France" };
            Country c4 = new Country() { Name = "Turkey" };
            Country c5 = new Country() { Name = "Norway" };
            Country c6 = new Country() { Name = "Brazil" };
            Country c7 = new Country() { Name = "Spain" };
            Country c8 = new Country() { Name = "Albania" };
            context.Countries.AddOrUpdate(x => x.Name, c1, c2, c3, c4, c5, c6, c7, c8);


            BusinessType b1 = new BusinessType() { Kind = "Factory" };
            BusinessType b2 = new BusinessType() { Kind = "Quarry" };
            BusinessType b3 = new BusinessType() { Kind = "Retail" };
            BusinessType b4 = new BusinessType() { Kind = "Export" };
            BusinessType b5 = new BusinessType() { Kind = "Import" };
            context.BusinessTypes.AddOrUpdate(x => x.Kind, b1, b2, b3, b4, b5);

            Location l1 = new Location() { Country = "Italy", City = "Rome", Address = "Koloseo" };
            Location l2 = new Location() { Country = "France", City = "Paris", Address = "Panagia" };
            Location l3 = new Location() { Country = "England", City = "London", Address = "Palace" };
            Location l4 = new Location() { Country = "Greece", City = "Kastoria", Address = "Kafeneio" };
            Location l5 = new Location() { Country = "Greece", City = "Crete", Address = "Palaiochora" };
            Location l6 = new Location() { Country = "Greece", City = "Athens", Address = "Dexamenis" };
            context.Locations.AddOrUpdate(x => x.City, l1, l2, l3, l4, l5, l6);

            Provider p1 = new Provider() { CompanyTitle = "2E Marble", Phone="6949326800", WebSite="www.2eMarble.com", Email = "polizos.thodoris@gmail.com", CompanyPhoto= "https://i2.wp.com/daskalakismarble.com/wp-content/uploads/Daskalakis_Marble_SA.jpg?fit=960%2C600&w=640",
            CompanyDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborumnumquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentiumoptio,eaque rerum! Provident similique accusantium nemo autem.Veritatisobcaecati tenetur iure eius earum ut molestias architecto voluptate aliquamnihil,eveniet aliquid culpa officia aut! Impedit sit sunt quaerat,odit,"};
            p1.Location = l1;
            p1.BusinessTypes = new List<BusinessType>() { b1, b2};
            Provider p2 = new Provider() { CompanyTitle = "2E Marìé", Phone = "6949314800", WebSite = "www.cSharp.com", Email = "polizos.thodoris@gmail.com", CompanyPhoto = "photourl", CompanyDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborumnumquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentiumoptio,eaque rerum! Provident similique accusantium nemo autem.Veritatisobcaecati tenetur iure eius earum ut molestias architecto voluptate aliquamnihil,eveniet aliquid culpa officia aut! Impedit sit sunt quaerat,odit," };
            p2.Location = l2;
            p2.BusinessTypes = new List<BusinessType>() { b3, b4 };
            Provider p3 = new Provider() { CompanyTitle = "3D Stone Tile & Pavers",  Phone="6941626800", WebSite="www.cSharp.com", Email = "www", CompanyPhoto = "photourl", CompanyDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborumnumquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentiumoptio,eaque rerum! Provident similique accusantium nemo autem.Veritatisobcaecati tenetur iure eius earum ut molestias architecto voluptate aliquamnihil,eveniet aliquid culpa officia aut! Impedit sit sunt quaerat,odit," };
            p3.Location = l3;
            p3.BusinessTypes = new List<BusinessType>() { b5, b4 };
            Provider p4 = new Provider() { CompanyTitle = "Turkish Marble ",  Phone="6949326840", WebSite="www.cSharp.com", Email = "www", CompanyPhoto = "photourl", CompanyDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborumnumquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentiumoptio,eaque rerum! Provident similique accusantium nemo autem.Veritatisobcaecati tenetur iure eius earum ut molestias architecto voluptate aliquamnihil,eveniet aliquid culpa officia aut! Impedit sit sunt quaerat,odit,"};
            p4.Location = l4;
            p4.BusinessTypes = new List<BusinessType>() { b2 };
            Provider p5 = new Provider() { CompanyTitle = "A Burslem and Son Ltd", Phone="6949327800", WebSite="www.cSharp.com", Email = "www", CompanyPhoto = "photourl" , CompanyDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborumnumquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentiumoptio,eaque rerum! Provident similique accusantium nemo autem.Veritatisobcaecati tenetur iure eius earum ut molestias architecto voluptate aliquamnihil,eveniet aliquid culpa officia aut! Impedit sit sunt quaerat,odit,"};
            p5.Location = l5;
            p5.BusinessTypes = new List<BusinessType>() { b1, b2 };
            Provider p6 = new Provider() { CompanyTitle = "A2Z MARBLE AND TRAVERTINE",  Phone="6947126800", WebSite="www.cSharp.com", Email = "www", CompanyPhoto = "photourl", CompanyDescription= "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborumnumquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentiumoptio,eaque rerum! Provident similique accusantium nemo autem.Veritatisobcaecati tenetur iure eius earum ut molestias architecto voluptate aliquamnihil,eveniet aliquid culpa officia aut! Impedit sit sunt quaerat,odit," };
            p6.Location = l6;
            p6.BusinessTypes = new List<BusinessType>() { b5, b2 };
            context.Providers.AddOrUpdate(x => new { x.CompanyTitle,x.CompanyPhoto,x.WebSite }, p1, p2, p3, p4, p5, p6);

            Marble m1 = new Marble() { Name = "ADRANOS ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c1, MarbleDescription= "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborumnumquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentiumoptio,eaque rerum!" };
            m1.Providers = new List<Provider>() { p1, p2 };

            Marble m2 = new Marble() { Name = "AFYON  ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro2", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/AFYON.jpg?resize=300%2C180&ssl=1" }, Country = c2, MarbleDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborumnumquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentiumoptio,eaque rerum!" };
            m2.Providers = new List<Provider>() { p3, p4, p1, p2};

            Marble m3 = new Marble() { Name = "AGIA MARINA ", Color = "SEMI-WHITE", Photo = new Photo() { PhotoName = "Marmaro3", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Greel_Marble_Agia_Marina_Clouded_Semi_White.jpg?resize=300%2C180&ssl=1" }, Country = c4, MarbleDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborumnumquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentiumoptio,eaque rerum!" };
            m3.Providers = new List<Provider>() { p5, p6, p1,p2 };

            Marble m4 = new Marble() { Name = "ALMERA  ", Color = "Pink", Photo = new Photo() { PhotoName = "Marmaro4", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/ALMERA-PINK.jpg?resize=300%2C180&ssl=1" }, Country = c6, MarbleDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborumnumquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentiumoptio,eaque rerum!" };
            m4.Providers = new List<Provider>() { p1, p2 };

            Marble m5 = new Marble() { Name = "ARABESCATO", Color = "ALTISSIMO", Photo = new Photo() { PhotoName = "Marmaro5", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/ARABESCATO-ALTISSIMO.jpg?resize=300%2C180&ssl=1" }, Country = c7, MarbleDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborumnumquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentiumoptio,eaque rerum!" };
            m5.Providers = new List<Provider>() { p3, p4, p1,p2};

            Marble m6 = new Marble() { Name = "AVAFESCATO ", Color = "CERVAIOLE", Photo = new Photo() { PhotoName = "Marmaro6", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/ARABESCATO-CERVAIOLE.jpg?resize=300%2C180&ssl=1" }, Country = c3, MarbleDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborumnumquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentiumoptio,eaque rerum!" };
            m6.Providers = new List<Provider>() { p5, p6, p1,p2 };

            context.Marbles.AddOrUpdate(x => x.Name, m1, m2, m3, m4, m5, m6);
            context.SaveChanges();

            //#region Seeding Tzavellas

            //// COUNTRIES  A-Z


            //Country c1 = new Country() { Name = "Afghanistan" };
            //Country c2 = new Country() { Name = "Albania" };
            //Country c3 = new Country() { Name = "Algeria" };
            //Country c4 = new Country() { Name = "Andorra" };
            //Country c5 = new Country() { Name = "Angola" };
            //Country c6 = new Country() { Name = "Antigua and Barbuda" };
            //Country c7 = new Country() { Name = "Argentina" };
            //Country c8 = new Country() { Name = "Armenia" };
            //Country c9 = new Country() { Name = "Aruba" };
            //Country c10 = new Country() { Name = "Australia" };
            //Country c11 = new Country() { Name = "Austria" };
            //Country c12 = new Country() { Name = "Azerbaijan" };


            //Country c13 = new Country() { Name = "Bahamas" };
            //Country c14 = new Country() { Name = "Bahrain" };
            //Country c15 = new Country() { Name = "Bangladesh" };
            //Country c16 = new Country() { Name = "Barbados" };
            //Country c17 = new Country() { Name = "Belarus" };
            //Country c18 = new Country() { Name = "Belgium" };
            //Country c19 = new Country() { Name = "Belize" };
            //Country c20 = new Country() { Name = "Benin" };
            //Country c21 = new Country() { Name = "Bhutan" };
            //Country c22 = new Country() { Name = "Bolivia" };
            //Country c23 = new Country() { Name = "Bosnia and Herzegovina" };
            //Country c24 = new Country() { Name = "Botswana" };
            //Country c25 = new Country() { Name = "Brazil" };
            //Country c26 = new Country() { Name = "Brunei" };
            //Country c27 = new Country() { Name = "Bulgaria" };
            //Country c28 = new Country() { Name = "Burkina Faso" };
            //Country c29 = new Country() { Name = "Burma" };
            //Country c30 = new Country() { Name = "Burundi" };


            //Country c31 = new Country() { Name = "Cambodia" };
            //Country c32 = new Country() { Name = "Cameroon" };
            //Country c33 = new Country() { Name = "Canada" };
            //Country c34 = new Country() { Name = "Cape Verde" };
            //Country c35 = new Country() { Name = "Central African Republic" };
            //Country c36 = new Country() { Name = "Chad" };
            //Country c37 = new Country() { Name = "Chile" };
            //Country c38 = new Country() { Name = "China" };
            //Country c39 = new Country() { Name = "Colombia" };
            //Country c40 = new Country() { Name = "Comoros" };
            //Country c41 = new Country() { Name = "Congo, Democratic Republic of the" };
            //Country c42 = new Country() { Name = "Congo, Republic of the" };
            //Country c43 = new Country() { Name = "Costa Rica" };
            //Country c44 = new Country() { Name = "Cote d’Ivoire" };
            //Country c45 = new Country() { Name = "Croatia" };
            //Country c46 = new Country() { Name = "Cuba" };
            //Country c47 = new Country() { Name = "Curacao" };
            //Country c48 = new Country() { Name = "Cyprus" };
            //Country c49 = new Country() { Name = "Czech Republic" };


            //Country c50 = new Country() { Name = "Denmark" };
            //Country c51 = new Country() { Name = "Djibouti" };
            //Country c52 = new Country() { Name = "Dominica" };
            //Country c53 = new Country() { Name = "Dominican Republic" };


            //Country c54 = new Country() { Name = "East Timor (also see Timor-Leste)" };
            //Country c55 = new Country() { Name = "Ecuador" };
            //Country c56 = new Country() { Name = "Egypt" };
            //Country c57 = new Country() { Name = "El Salvador" };
            //Country c58 = new Country() { Name = "Equatorial Guinea" };
            //Country c59 = new Country() { Name = "Eritrea" };
            //Country c60 = new Country() { Name = "Estonia" };
            //Country c61 = new Country() { Name = "Ethiopiac" };


            //Country c62 = new Country() { Name = "Fiji" };
            //Country c63 = new Country() { Name = "Finland" };
            //Country c64 = new Country() { Name = "France" };


            //Country c65 = new Country() { Name = "Gabon" };
            //Country c66 = new Country() { Name = "Gambia" };
            //Country c67 = new Country() { Name = "Georgia" };
            //Country c68 = new Country() { Name = "Germany" };
            //Country c69 = new Country() { Name = "Ghana" };
            //Country c70 = new Country() { Name = "Greece" };
            //Country c71 = new Country() { Name = "Grenada" };
            //Country c72 = new Country() { Name = "Guatemala" };
            //Country c73 = new Country() { Name = "Guinea" };
            //Country c74 = new Country() { Name = "Guinea-Bissau" };
            //Country c75 = new Country() { Name = "Guyana" };


            //Country c76 = new Country() { Name = "Haiti" };
            //Country c77 = new Country() { Name = "Holy See" };
            //Country c78 = new Country() { Name = "Honduras" };
            //Country c79 = new Country() { Name = "Hong Kong" };
            //Country c80 = new Country() { Name = "Hungary" };


            //Country c81 = new Country() { Name = "Iceland" };
            //Country c82 = new Country() { Name = "India" };
            //Country c83 = new Country() { Name = "Indonesia" };
            //Country c84 = new Country() { Name = "Iran" };
            //Country c85 = new Country() { Name = "Iraq" };
            //Country c86 = new Country() { Name = "Ireland" };
            //Country c87 = new Country() { Name = "Israel" };
            //Country c88 = new Country() { Name = "Italy" };


            //Country c89 = new Country() { Name = "Jamaica" };
            //Country c90 = new Country() { Name = "Japan" };
            //Country c91 = new Country() { Name = "Jordan" };



            //Country c92 = new Country() { Name = "Kazakhstan" };
            //Country c93 = new Country() { Name = "Kenya" };
            //Country c94 = new Country() { Name = "Kiribati" };
            //Country c95 = new Country() { Name = "Korea, North" };
            //Country c96 = new Country() { Name = "Korea, South" };
            //Country c97 = new Country() { Name = "Kosovo" };
            //Country c98 = new Country() { Name = "Kuwait" };
            //Country c99 = new Country() { Name = "Kyrgyzstan" };


            //Country c100 = new Country() { Name = "Laos" };
            //Country c101 = new Country() { Name = "Latvia" };
            //Country c102 = new Country() { Name = "Lebanon" };
            //Country c103 = new Country() { Name = "Lesotho" };
            //Country c104 = new Country() { Name = "Liberia" };
            //Country c105 = new Country() { Name = "Libya" };
            //Country c106 = new Country() { Name = "Liechtenstein" };
            //Country c107 = new Country() { Name = "Lithuania" };
            //Country c108 = new Country() { Name = "Luxembourg" };


            //Country c109 = new Country() { Name = "Macau" };
            //Country c110 = new Country() { Name = "Macedonia" };
            //Country c111 = new Country() { Name = "Madagascar" };
            //Country c112 = new Country() { Name = "Malawi" };
            //Country c113 = new Country() { Name = "Malaysia" };
            //Country c114 = new Country() { Name = "Maldives" };
            //Country c115 = new Country() { Name = "Mali" };
            //Country c116 = new Country() { Name = "Malta" };
            //Country c117 = new Country() { Name = "Marshall Islands" };
            //Country c118 = new Country() { Name = "Mauritania" };
            //Country c119 = new Country() { Name = "Mauritius" };
            //Country c120 = new Country() { Name = "Mexico" };
            //Country c121 = new Country() { Name = "Micronesia" };
            //Country c122 = new Country() { Name = "Moldova" };
            //Country c123 = new Country() { Name = "Monaco" };
            //Country c124 = new Country() { Name = "Mongolia" };
            //Country c125 = new Country() { Name = "Montenegro" };
            //Country c126 = new Country() { Name = "Morocco" };
            //Country c127 = new Country() { Name = "Mozambique" };


            //Country c128 = new Country() { Name = "Namibia" };
            //Country c129 = new Country() { Name = "Nauru" };
            //Country c130 = new Country() { Name = "Nepal" };
            //Country c131 = new Country() { Name = "Netherlands" };
            //Country c132 = new Country() { Name = "Netherlands Antilles" };
            //Country c133 = new Country() { Name = "New Zealand" };
            //Country c134 = new Country() { Name = "Nicaragua" };
            //Country c135 = new Country() { Name = "Niger" };
            //Country c136 = new Country() { Name = "Nigeria" };
            //Country c137 = new Country() { Name = "Norway" };


            //Country c138 = new Country() { Name = "Oman" };

            //Country c139 = new Country() { Name = "Pakistan" };
            //Country c140 = new Country() { Name = "Palau" };
            //Country c141 = new Country() { Name = "Palestinian Territories" };
            //Country c142 = new Country() { Name = "Panama" };
            //Country c143 = new Country() { Name = "Papua New Guinea" };
            //Country c144 = new Country() { Name = "Paraguay" };
            //Country c145 = new Country() { Name = "Peru" };
            //Country c146 = new Country() { Name = "Philippines" };
            //Country c147 = new Country() { Name = "Poland" };
            //Country c148 = new Country() { Name = "Portugal" };


            //Country c149 = new Country() { Name = "Qatar" };


            //Country c150 = new Country() { Name = "Romania" };
            //Country c151 = new Country() { Name = "Russia" };
            //Country c152 = new Country() { Name = "Rwanda" };


            //Country c153 = new Country() { Name = "Saint Kitts and Nevis" };
            //Country c154 = new Country() { Name = "Saint Lucia" };
            //Country c155 = new Country() { Name = "Saint Vincent and the Grenadines" };
            //Country c156 = new Country() { Name = "Samoa" };
            //Country c157 = new Country() { Name = "San Marino" };
            //Country c158 = new Country() { Name = "Sao Tome and Principe" };
            //Country c159 = new Country() { Name = "Saudi Arabia" };
            //Country c160 = new Country() { Name = "Senegal" };
            //Country c161 = new Country() { Name = "Serbia" };
            //Country c162 = new Country() { Name = "Seychelles" };
            //Country c163 = new Country() { Name = "Sierra Leone" };
            //Country c164 = new Country() { Name = "Singapore" };
            //Country c165 = new Country() { Name = "Sint Maarten" };
            //Country c166 = new Country() { Name = "Slovakia" };
            //Country c167 = new Country() { Name = "Slovenia" };
            //Country c168 = new Country() { Name = "Solomon Islands" };
            //Country c169 = new Country() { Name = "Somalia" };
            //Country c170 = new Country() { Name = "South Africa" };
            //Country c171 = new Country() { Name = "South Sudan" };
            //Country c172 = new Country() { Name = "Spain" };
            //Country c173 = new Country() { Name = "Sri Lanka" };
            //Country c174 = new Country() { Name = "Sudan" };
            //Country c175 = new Country() { Name = "Suriname" };
            //Country c176 = new Country() { Name = "Swaziland" };
            //Country c177 = new Country() { Name = "Sweden" };
            //Country c178 = new Country() { Name = "Switzerland" };
            //Country c179 = new Country() { Name = "Syria" };


            //Country c180 = new Country() { Name = "Taiwan" };
            //Country c181 = new Country() { Name = "Tajikistan" };
            //Country c182 = new Country() { Name = "Tanzania" };
            //Country c183 = new Country() { Name = "Thailand" };
            //Country c184 = new Country() { Name = "Timor-Leste" };
            //Country c185 = new Country() { Name = "Togo" };
            //Country c186 = new Country() { Name = "Tonga" };
            //Country c187 = new Country() { Name = "Trinidad and Tobago" };
            //Country c188 = new Country() { Name = "Tunisia" };
            //Country c189 = new Country() { Name = "Turkey" };
            //Country c190 = new Country() { Name = "Turkmenistan" };
            //Country c191 = new Country() { Name = "Tuvalu" };


            //Country c192 = new Country() { Name = "Uganda" };
            //Country c193 = new Country() { Name = "Ukraine" };
            //Country c194 = new Country() { Name = "United Arab Emirates" };
            //Country c195 = new Country() { Name = "United Kingdom" };
            //Country c196 = new Country() { Name = "Uruguay" };
            //Country c197 = new Country() { Name = "Uzbekistan" };


            //Country c198 = new Country() { Name = "Vanuatu" };
            //Country c199 = new Country() { Name = "Venezuela" };
            //Country c200 = new Country() { Name = "Vietnam" };


            //Country c201 = new Country() { Name = "Yemen" };


            //Country c202 = new Country() { Name = "Zambia" };
            //Country c203 = new Country() { Name = "Zimbabwe" };




            ////BUSINESS TYPES

            //BusinessType b1 = new BusinessType() { Kind = "Factory" };
            //BusinessType b2 = new BusinessType() { Kind = "Quarry" };
            //BusinessType b3 = new BusinessType() { Kind = "Retail" };
            //BusinessType b4 = new BusinessType() { Kind = "Export" };
            //BusinessType b5 = new BusinessType() { Kind = "Import" };

            //context.BusinessTypes.AddOrUpdate(x => x.Kind, b1, b2, b3, b4, b5);





            //// PROVIDERS

            //Provider p1 = new Provider() { CompanyTitle = "2E Marble", Phone = "", WebSite = "", Email = " ", CompanyPhoto = " " };

            //Provider p2 = new Provider() { CompanyTitle = "A.A.T.C. and Co. S.r.l – Italian Marble Company", Phone = "0039 0456 861057", WebSite = "http://www.aatc.it/", Email = " ", CompanyPhoto = "" };
            //p2.BusinessTypes = new List<BusinessType>() { b1, b4 };

            //Provider p3 = new Provider() { CompanyTitle = "Aadhar Primeexim", Phone = "0091 291 2635619", WebSite = "www.aadharexim.com", Email = " ", CompanyPhoto = "" };
            //p3.BusinessTypes = new List<BusinessType>() { b1, b2 };

            //Provider p4 = new Provider() { CompanyTitle = "Abdeen Stone for Marble and Granite", Phone = "002 012 87104990", WebSite = "www.abdeenstone.net", Email = " ", CompanyPhoto = "" };
            //p4.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };

            //Provider p5 = new Provider() { CompanyTitle = "ACROPOLE MARBLE", Phone = "+357 9671 9945", WebSite = "www.acropolemarble.com/", Email = " ", CompanyPhoto = "" };
            //p5.BusinessTypes = new List<BusinessType>() { b1 };

            //Provider p6 = new Provider() { CompanyTitle = "Afrika National Granite", Phone = "0027 11 908 3595", WebSite = "www.ang.co.za", Email = " ", CompanyPhoto = "" };
            //p6.BusinessTypes = new List<BusinessType>() { b1, b2 };

            //Provider p7 = new Provider() { CompanyTitle = "AGHIA MARINA MARBLE LTD.", Phone = "+30 210-6039362", WebSite = "www.perrakis.eu", Email = " ", CompanyPhoto = "" };
            //p7.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };

            //Provider p8 = new Provider() { CompanyTitle = "AKROLITHOS Ltd", Phone = "0030 25920 51400", WebSite = "www.akrolithos.gr", Email = " ", CompanyPhoto = "" };
            //p8.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };

            //Provider p9 = new Provider() { CompanyTitle = "AL HASSANA MARBLE", Phone = "0020229700402", WebSite = "www.alhassana.com", Email = " ", CompanyPhoto = "" };
            //p9.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };


            //Provider p10 = new Provider() { CompanyTitle = "Al Nada Group for Marble & Granite", Phone = "0020 1 118585224", WebSite = "www.alnada-marble.com", Email = " ", CompanyPhoto = "" };
            //p10.BusinessTypes = new List<BusinessType>() { b1, b4 };


            //Provider p11 = new Provider() { CompanyTitle = "Al-Cobra for Marble and Granite", Phone = "0020 2 6909635", WebSite = "www.alcobra2mg.com", Email = " ", CompanyPhoto = "" };
            //p11.BusinessTypes = new List<BusinessType>() { b4, b5 };


            //Provider p12 = new Provider() { CompanyTitle = "Al-Rashad Marble Co.", Phone = "0020 2 29700600", WebSite = "www.alrashadmarble.net", Email = " ", CompanyPhoto = "" };
            //p12.BusinessTypes = new List<BusinessType>() { b1, b4 };


            //Provider p13 = new Provider() { CompanyTitle = "Albadr Marble Stone Co.", Phone = "01003630067", WebSite = "http://www.albadr-marble-stone.com/", Email = " ", CompanyPhoto = "" };
            //p13.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };


            //Provider p14 = new Provider() { CompanyTitle = "Alberti and Alberti S.r.l.", Phone = "00390456260444", WebSite = "www.marmialberti.it", Email = " ", CompanyPhoto = "" };
            //p14.BusinessTypes = new List<BusinessType>() { b1, b4 };


            //Provider p15 = new Provider() { CompanyTitle = "Aldur Madencilik", Phone = "0090 0 232 621 34 40", WebSite = "www.aldur.com.tr", Email = " ", CompanyPhoto = "" };
            //p15.BusinessTypes = new List<BusinessType>() { b1 };


            //Provider p16 = new Provider() { CompanyTitle = "Alfa Stone For Marble and Quarries", Phone = "0020 2 27541379", WebSite = "www.alfa-stone.com", Email = " ", CompanyPhoto = "" };
            //p16.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };


            //Provider p17 = new Provider() { CompanyTitle = "Alpa Hellas Marbles", Phone = "00302103425198", WebSite = "alpahellasmarbles.gr", Email = " ", CompanyPhoto = "" };
            //p17.BusinessTypes = new List<BusinessType>() { b1 };


            //Provider p18 = new Provider() { CompanyTitle = "Alpha Mena, Export Marble and Granite", Phone = "002-0106 2445527", WebSite = "www.alphamena.webs.com", Email = " ", CompanyPhoto = "" };
            //p18.BusinessTypes = new List<BusinessType>() { b1, b4 };


            //Provider p19 = new Provider() { CompanyTitle = "ALSAMAR A.V.E.E.", Phone = "+30 25410 93752", WebSite = " www.alsamar.gr", Email = " ", CompanyPhoto = "" };
            //p19.BusinessTypes = new List<BusinessType>() { b1, b4, b5 };


            //Provider p20 = new Provider() { CompanyTitle = "Anjalee Granite", Phone = "0091 98855 66709", WebSite = "www.anjalee.com", Email = " ", CompanyPhoto = "" };
            //p20.BusinessTypes = new List<BusinessType>() { b1, b2 };


            //Provider p21 = new Provider() { CompanyTitle = "Arihant Marbles", Phone = "0091 9414017329", WebSite = "www.arihantmarbles.com", Email = " ", CompanyPhoto = "" };
            //p21.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };


            //Provider p22 = new Provider() { CompanyTitle = "Aro Granite", Phone = "0091 4344 252100", WebSite = "www.arotile.com", Email = " ", CompanyPhoto = "" };
            //p22.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };


            //Provider p23 = new Provider() { CompanyTitle = "Azul Aran", Phone = "0034 973 64 73 95", WebSite = "www.azularan.com", Email = " ", CompanyPhoto = "" };
            //p23.BusinessTypes = new List<BusinessType>() { b1, b2 };


            //Provider p24 = new Provider() { CompanyTitle = "Azul italia", Phone = "0039 02817551", WebSite = "www.azulitalia.it", Email = " ", CompanyPhoto = "" };
            //p24.BusinessTypes = new List<BusinessType>() { b1, b2 };


            //Provider p25 = new Provider() { CompanyTitle = "Bacci Marmi", Phone = "0039 0584757537", WebSite = "www.baccimarmi.it", Email = " ", CompanyPhoto = "" };
            //p25.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };


            //Provider p26 = new Provider() { CompanyTitle = "Bahavan Granites", Phone = "0091 44 42170696", WebSite = "www.bahavangranites.com", Email = " ", CompanyPhoto = "" };
            //p26.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };


            //Provider p27 = new Provider() { CompanyTitle = "BALKAN SA MARBLE MANUFACTURE", Phone = "+302521068030", WebSite = "", Email = " ", CompanyPhoto = "" };
            //p27.BusinessTypes = new List<BusinessType>() { b1, b2, b3, b4, b5 };


            //Provider p28 = new Provider() { CompanyTitle = "BORCHARDT STONE", Phone = "0055 27 3732-5048", WebSite = "www.borchardtstone.com", Email = " ", CompanyPhoto = "" };
            //p28.BusinessTypes = new List<BusinessType>() { b2, b4 };


            //Provider p29 = new Provider() { CompanyTitle = "Brasigran Granitos", Phone = "005527 2124 1421", WebSite = "www.mcorcovado.com.br", Email = " ", CompanyPhoto = "" };
            //p29.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };


            //Provider p30 = new Provider() { CompanyTitle = "BVL Granites", Phone = "0091 40 23607488", WebSite = "www.bvlgranites.com", Email = " ", CompanyPhoto = "" };
            //p30.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };


            //Provider p31 = new Provider() { CompanyTitle = "Ceramiche Cerdisa", Phone = "00309 0522 773602", WebSite = "www.ceramichecerdisa.it/en/", Email = " ", CompanyPhoto = "" };
            //p31.BusinessTypes = new List<BusinessType>() { b1 };


            //Provider p32 = new Provider() { CompanyTitle = "Coex Granite", Phone = "0055 27 2124-3341", WebSite = "www.coexgranite.com", Email = " ", CompanyPhoto = "" };
            //p32.BusinessTypes = new List<BusinessType>() { b2, b4 };


            //Provider p33 = new Provider() { CompanyTitle = "CRYSTAL FOR MARBLE AND GRANITE", Phone = "00 202 29700 551", WebSite = "www.crystal.com.eg", Email = " ", CompanyPhoto = "" };
            //p33.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };


            //Provider p34 = new Provider() { CompanyTitle = "DASKALAKIS MARBLE S.A", Phone = "+30210 6612106, 6610888", WebSite = "www.daskalakismarble.com", Email = " ", CompanyPhoto = "" };
            //p34.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };


            //Provider p35 = new Provider() { CompanyTitle = "DASKALAKIS NATURAL STONES", Phone = "+30 2821 064557", WebSite = "www.daskalakis-stones.gr", Email = " ", CompanyPhoto = "" };
            //p35.BusinessTypes = new List<BusinessType>() { b3, b5 };


            //Provider p36 = new Provider() { CompanyTitle = "DERMITZAKIS BROS – GREEK WHITE MARBLE", Phone = "+30 25910 24942", WebSite = "", Email = " ", CompanyPhoto = "" };
            //p36.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };


            //Provider p37 = new Provider() { CompanyTitle = "DIONYSSOMARBLE COMPANY SA", Phone = "0030-2106211400", WebSite = "", Email = " ", CompanyPhoto = "" };
            //p37.BusinessTypes = new List<BusinessType>() { b1, b2, b4, b5 };


            //Provider p38 = new Provider() { CompanyTitle = "Dorgham For Marble and Granite", Phone = "002 0222614415", WebSite = "www.dorghammarble.com", Email = " ", CompanyPhoto = "" };
            //p38.BusinessTypes = new List<BusinessType>() { b1, b4 };


            //Provider p39 = new Provider() { CompanyTitle = "DORIKA MARMARA S.A.", Phone = "+306936608637,(+30) 25210.81601", WebSite = "", Email = " ", CompanyPhoto = "" };
            //p39.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };


            //Provider p40 = new Provider() { CompanyTitle = "DreamStone – Egyptian Marble Company", Phone = "202 382 43 121", WebSite = "www.dream-stone.com", Email = " ", CompanyPhoto = "" };
            //p40.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };


            //Provider p41 = new Provider() { CompanyTitle = "El Zomordah for Marble and Granite", Phone = "00 202 275 41 247", WebSite = "www.zomordah.com", Email = " ", CompanyPhoto = "" };
            //p41.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };


            //Provider p42 = new Provider() { CompanyTitle = "Elc Marble, Egyptian Lebanese Co.", Phone = "002 0100 188 66 30", WebSite = "www.elc-eg.com", Email = " ", CompanyPhoto = "" };
            //p42.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };


            //Provider p43 = new Provider() { CompanyTitle = "Elios Ceramica", Phone = "0039 0536 842411", WebSite = "http://www.eliosceramica.com/", Email = " ", CompanyPhoto = "" };
            //p43.BusinessTypes = new List<BusinessType>() { b5 };


            //Provider p44 = new Provider() { CompanyTitle = "FHL I.KIRIAKIDIS ~ MARBLES and GRANITES S.A.", Phone = " 0030-6974030383,+30 25210 81360 -3-4-5", WebSite = "www.fhl.gr", Email = " ", CompanyPhoto = "" };
            //p44.BusinessTypes = new List<BusinessType>() { b1, b2, b3, b4, b5 };


            //Provider p45 = new Provider() { CompanyTitle = "FIRST MARBLE", Phone = "", WebSite = "www.first-marble.com", Email = " ", CompanyPhoto = "" };
            //p45.BusinessTypes = new List<BusinessType>() { b5 };


            //Provider p46 = new Provider() { CompanyTitle = "GALANIS MARBLE S.A.", Phone = "(+30) 27530 22557", WebSite = "www.galanisquarries.com", Email = " ", CompanyPhoto = "" };
            //p46.BusinessTypes = new List<BusinessType>() { b2, b4 };


            //Provider p47 = new Provider() { CompanyTitle = "Galleni Gino Marmi", Phone = "0039 0585 844489", WebSite = "www.gallenimarmi.com", Email = " ", CompanyPhoto = "" };
            //p47.BusinessTypes = new List<BusinessType>() { b2 };


            //Provider p48 = new Provider() { CompanyTitle = "Geostones", Phone = "+49-(0)-4141-788 18 98", WebSite = "http://geostones.eu", Email = " ", CompanyPhoto = "" };
            //p48.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };


            //Provider p49 = new Provider() { CompanyTitle = "Giannakis Marble", Phone = "0030 25220 23596", WebSite = "www.giannakis-marble.gr", Email = " ", CompanyPhoto = "" };
            //p49.BusinessTypes = new List<BusinessType>() { b5 };


            //Provider p50 = new Provider() { CompanyTitle = "GLOBAL STONES LTD", Phone = "0020227549770", WebSite = "www.gsglobalstones.com", Email = " ", CompanyPhoto = "" };
            //p50.BusinessTypes = new List<BusinessType>() { b5 };






            ////MARBLE


            //Marble m1 = new Marble() { Name = "AEGEAN WHITE Greek Marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c70 };
            //m1.Providers = new List<Provider>() { p7, p8, p17, p19 };

            //Marble m2 = new Marble() { Name = "AGIA MARINA CLOUDED SEMI-WHITE Greek Marble", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c70 };
            //m2.Providers = new List<Provider>() { p27, p34, p35 };

            //Marble m3 = new Marble() { Name = "AGIOS KYRILLOS (POMPIA) GREY Greek marble", Color = "Grey", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c70 };
            //m3.Providers = new List<Provider>() { p36, p37, p39 };

            //Marble m4 = new Marble() { Name = "ALIVERI GREY Greek marble", Color = "Grey", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c70 };
            //m4.Providers = new List<Provider>() { p44, p46, p48, p49 };

            //Marble m5 = new Marble() { Name = "ALOIDES SEMI WHITE Greek marble", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c70 };
            //m5.Providers = new List<Provider>() { p7, p8, p17, p19, p36, p37 };

            //Marble m6 = new Marble() { Name = "ARAXOVA Greek marble", Color = "Brown", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c70 };
            //m6.Providers = new List<Provider>() { p44, p46 };

            //Marble m7 = new Marble() { Name = "ARGOS BLACK Greek marble ", Color = "Black", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c70 };
            //m7.Providers = new List<Provider>() { p36, p37, p48, p49 };

            //Marble m8 = new Marble() { Name = "ARIDAIA TRAVERTINO Greek marble ", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c70 };
            //m8.Providers = new List<Provider>() { p17, p19 };

            //Marble m9 = new Marble() { Name = "ARTA PINK Greek marble ", Color = "Pink", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c70 };
            //m9.Providers = new List<Provider>() { p36 };

            //Marble m10 = new Marble() { Name = "CHALKEROU CRYSTALLINA SEMI WHITE Greek marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c70 };
            //m10.Providers = new List<Provider>() { p7, p8, p17, p19, p36, p37, p44, p46, p48, p49 };



            //Marble m11 = new Marble() { Name = "ARABESCATO ALTISSIMO Italian marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c88 };
            //m11.Providers = new List<Provider>() { p2, p14 };

            //Marble m12 = new Marble() { Name = "ARABESCATO ARNI Italian marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c88 };
            //m12.Providers = new List<Provider>() { p24, p25 };

            //Marble m13 = new Marble() { Name = "ARABESCATO CERVAIOLE Italian marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c88 };
            //m13.Providers = new List<Provider>() { p31, p43 };

            //Marble m14 = new Marble() { Name = "ARABESCATO CORCHIA Italian marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c88 };
            //m14.Providers = new List<Provider>() { p47 };

            //Marble m15 = new Marble() { Name = "ARABESCATO Italian marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c88 };
            //m15.Providers = new List<Provider>() { p2, p14, p24, p25 };

            //Marble m16 = new Marble() { Name = "ARABESCATO MOSSA Italian marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c88 };
            //m16.Providers = new List<Provider>() { p2, p14, p24, p25, p31, p43 };

            //Marble m17 = new Marble() { Name = "ARABESCATO OROBICO GRIGIO Italian marble ", Color = "Grey", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c88 };
            //m17.Providers = new List<Provider>() { p31, p43 };

            //Marble m18 = new Marble() { Name = "ARABESCATO VAGLI Italian marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c88 };
            //m18.Providers = new List<Provider>() { p2, p24, p25 };

            //Marble m19 = new Marble() { Name = "BARDIGLIO COSTA Italian marble ", Color = "Grey", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c88 };
            //m19.Providers = new List<Provider>() { p24, p25, p31 };

            //Marble m20 = new Marble() { Name = "BARDIGLIO IMPERIALE Italian marble ", Color = "Grey", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c88 };
            //m20.Providers = new List<Provider>() { p31 };



            //Marble m21 = new Marble() { Name = "ALMERA PINK Egyptian marble ", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            //m21.Providers = new List<Provider>() { p4, p9 };

            //Marble m22 = new Marble() { Name = "BRECCIA FAWAKHIR Egyptian marble ", Color = "Green", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            //m22.Providers = new List<Provider>() { p10, p11, p12 };

            //Marble m23 = new Marble() { Name = "CHANTEUIL JAUNE BLEU French marble ", Color = "Blue", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            //m23.Providers = new List<Provider>() { p13, p16 };

            //Marble m24 = new Marble() { Name = "GALALA Egyptian marble ", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            //m24.Providers = new List<Provider>() { p18, p33, p40, p41 };

            //Marble m25 = new Marble() { Name = "GIALLO ATLANTIDE Egyptian marble ", Color = "Yellow", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            //m25.Providers = new List<Provider>() { p42, p45 };

            //Marble m26 = new Marble() { Name = "IVORY CLASSIC Egyptian marble ", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            //m26.Providers = new List<Provider>() { p50 };

            //Marble m27 = new Marble() { Name = "MARIGOLD Egyptian marble", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            //m27.Providers = new List<Provider>() { p10, p11, p12, p18, p33, p40, p41 };

            //Marble m28 = new Marble() { Name = "GIALLO CLEOPATRA Egyptian marble ", Color = "Yellow", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            //m28.Providers = new List<Provider>() { p42, p45, p50 };

            //Marble m29 = new Marble() { Name = "IVORY CLASSIC Egyptian marble ", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            //m29.Providers = new List<Provider>() { p4, p10, p12, p16, p33, p38, p40, p42, p50 };

            //Marble m30 = new Marble() { Name = "MARIGOLD Egyptian marble ", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            //m30.Providers = new List<Provider>() { p9, p11, p13, p18, p38, p41, p45 };

            //Marble m31 = new Marble() { Name = "ONYX ALABASTER Egyptian onyx ", Color = "Yellow", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            //m31.Providers = new List<Provider>() { p45 };

            //Marble m32 = new Marble() { Name = "SAMAHA Egyptian marble ", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            //m32.Providers = new List<Provider>() { p9, p33, p38, p45, p50 };

            //Marble m33 = new Marble() { Name = "SILVIA ORO ", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            //m33.Providers = new List<Provider>() { p10, p11, p12, p42, p45 };

            //Marble m34 = new Marble() { Name = "SINAI PEARL Egyptian limestone ", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            //m34.Providers = new List<Provider>() { p13, p16 };

            //Marble m35 = new Marble() { Name = "Sunny marble ", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            //m35.Providers = new List<Provider>() { p4, p10, p12, p16, p33 };

            //Marble m36 = new Marble() { Name = "YLANG Egyptian marble ", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            //m36.Providers = new List<Provider>() { p18, p33 };



            //Marble m37 = new Marble() { Name = "ADONIS BEIGE Turkish marble ", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c189 };
            //m37.Providers = new List<Provider>() { p15 };

            //Marble m38 = new Marble() { Name = "ADRANOS WHITE Turkish marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c189 };
            //m38.Providers = new List<Provider>() { p15 };

            //Marble m39 = new Marble() { Name = "AEGEAN BORDEAUX Turkish marble ", Color = "Red", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c189 };
            //m39.Providers = new List<Provider>() { p24, p25, p31 };

            //Marble m40 = new Marble() { Name = "AFYON WHITE Turkish marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c189 };
            //m40.Providers = new List<Provider>() { p9, p33, p38, p45, p50 };

            //Marble m41 = new Marble() { Name = "AKSEHIR BLACK Turkish marble ", Color = "Black", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c189 };
            //m41.Providers = new List<Provider>() { p38 };



            //Marble m42 = new Marble() { Name = "AMAZONIA BROWN Brazilian marble ", Color = "Brown", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c25 };
            //m42.Providers = new List<Provider>() { p28 };

            //Marble m43 = new Marble() { Name = "ARGENTO Brazilian marble ", Color = "Grey", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c25 };
            //m43.Providers = new List<Provider>() { p29 };

            //Marble m44 = new Marble() { Name = "AZUL ACQUAMARINA Brazilian marble ", Color = "Blue", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c25 };
            //m44.Providers = new List<Provider>() { p32 };

            //Marble m45 = new Marble() { Name = "AZUL BOCQUIRA Brazilian marble ", Color = "Blue", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c25 };
            //m45.Providers = new List<Provider>() { p28, p29 };

            //Marble m46 = new Marble() { Name = "BRANCO CACHOEIRO Brazilian marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c25 };
            //m46.Providers = new List<Provider>() { p28, p32 };

            //Marble m47 = new Marble() { Name = "ADRBRANCO CARRARINHA Brazilian marbleANOS ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c25 };
            //m47.Providers = new List<Provider>() { p29, p32 };

            //Marble m48 = new Marble() { Name = "BRANCO COMUM Brazilian marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c25 };
            //m48.Providers = new List<Provider>() { p28 };

            //Marble m49 = new Marble() { Name = "BRANCO RAJADO Brazilian marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c25 };
            //m49.Providers = new List<Provider>() { p28, p29, p32 };



            //Marble m50 = new Marble() { Name = "AGRA WHITE Indian sandstone ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c82 };
            //m50.Providers = new List<Provider>() { p3, p20 };

            //Marble m51 = new Marble() { Name = "BHAINSLANA BLACK indian marble ", Color = "Black", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c82 };
            //m51.Providers = new List<Provider>() { p21, p22 };

            //Marble m52 = new Marble() { Name = "BIDASAR BROWN India marble ", Color = "Brown", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c82 };
            //m52.Providers = new List<Provider>() { p26, p30 };

            //Marble m53 = new Marble() { Name = "DHOLPUR WHITE Indian sandstone ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c82 };
            //m53.Providers = new List<Provider>() { p3, p21 };

            //Marble m54 = new Marble() { Name = "HIMACHAL WHITE Indian quartzite ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c82 };
            //m54.Providers = new List<Provider>() { p3, p20, p21, p22, p26, p30 };

            //Marble m55 = new Marble() { Name = "JAIPUR RAINBOW Indian sandstone ", Color = "Multicolor", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c82 };
            //m55.Providers = new List<Provider>() { p21, p22, p26 };

            //Marble m56 = new Marble() { Name = "LIME GREEN Indian limestone ", Color = "Green", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c82 };
            //m56.Providers = new List<Provider>() { p3, p20, p21, p22, p26 };

            //Marble m57 = new Marble() { Name = "LIME PINK Indian limestone ", Color = "Pink", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c82 };
            //m57.Providers = new List<Provider>() { p20 };

            //Marble m58 = new Marble() { Name = "MORWAD WHITE Indian marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c82 };
            //m58.Providers = new List<Provider>() { p3, p21, p22, p26 };

            //Marble m59 = new Marble() { Name = "RAJASTHAN GREEN Indian marble", Color = "Green", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c82 };
            //m59.Providers = new List<Provider>() { p22 };

            //Marble m60 = new Marble() { Name = "TAJ ROSE Indian sandstone ", Color = "Pink", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c82 };
            //m60.Providers = new List<Provider>() { p20, p21, p22, p26, p30 };


            //Marble m61 = new Marble() { Name = "GIALLA ", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c48 };
            //m61.Providers = new List<Provider>() { p5 };



            //Marble m62 = new Marble() { Name = "CREMA MARFIL Spanish marble ", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c172 };
            //m62.Providers = new List<Provider>() { p23, p6 };



            //#endregion

            #region ImplB
            //var marbles = new List<Marble>
            //{
            //    new Marble { Name = "ADRANOS", Color = "White", Providers = new List<Provider>(){ p1, p2 } },
            //    new Marble { Name = "AFYON", Color = "White", Providers = new List<Provider>() { p3, p4 }  },
            //    new Marble { Name = "AGIA MARINA", Color = "SEMI-WHITE", Providers = new List<Provider>() { p5, p6 }    },
            //    new Marble { Name = "ALMERA", Color = "Pink", Providers = new List<Provider>() { p1, p2 }   },
            //    new Marble { Name = "ARABESCATO", Color = "ALTISSIMO", Providers = new List<Provider>() { p3, p4 }   },
            //    new Marble { Name = "AVAFESCATO ", Color = "CERVAIOLE", Providers = new List<Provider>() { p5, p6 }   }
            //};

            //marbles.ForEach(s => context.Marbles.AddOrUpdate(p => p.Name, s));

            //context.SaveChanges();
            //var photos = new List<Photo>
            //{
            //    new Photo { PhotoName = "Marmaro1", Url = "www" , MarbleId = marbles.FirstOrDefault(s => s.Name == "ADRANOS").MarbleId },
            //    new Photo { PhotoName = "Marmaro2", Url = "www" , Marble = marbles.FirstOrDefault(s => s.Name == "AFYON") },
            //    new Photo { PhotoName = "Marmaro3", Url = "www" , Marble = marbles.FirstOrDefault(s => s.Name == "AGIA MARINA") },
            //    new Photo { PhotoName = "Marmaro4", Url = "www" , Marble = marbles.FirstOrDefault(s => s.Name == "ALMERA") },
            //    new Photo { PhotoName = "Marmaro5", Url = "www" , Marble = marbles.FirstOrDefault(s => s.Name == "ARABESCATO") },
            //    new Photo { PhotoName = "Marmaro6", Url = "www" , Marble = marbles.FirstOrDefault(s => s.Name == "AVAFESCATO") },


            //};

            //photos.ForEach(s => context.Photos.AddOrUpdate(p => p.PhotoName, s));
            //context.SaveChanges();
            #endregion


            //Roles
            if (!context.Roles.Any(x => x.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Admin" };
                manager.Create(role);
            }


            var PasswordHash = new PasswordHasher();
            if (!context.Users.Any(x => x.UserName == "admin@admin.net"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser
                {
                    UserName = "admin@admin.net",
                    Email = "admin@admin.net",
                    PasswordHash = PasswordHash.HashPassword("Admin1!")
                };



                manager.Create(user);
                manager.AddToRole(user.Id, "Admin");
            }





        }
    }
}
