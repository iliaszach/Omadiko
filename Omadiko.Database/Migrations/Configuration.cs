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

            //Country c1 = new Country() { Name = "Greece" };
            //Country c2 = new Country() { Name = "Italy" };
            //Country c3 = new Country() { Name = "France" };
            //Country c4 = new Country() { Name = "Turkey" };
            //Country c5 = new Country() { Name = "Norway" };
            //Country c6 = new Country() { Name = "Brazil" };
            //Country c7 = new Country() { Name = "Spain" };
            //Country c8 = new Country() { Name = "Albania" };
            //context.Countries.AddOrUpdate(x => x.Name, c1, c2, c3, c4, c5, c6, c7, c8);


            //BusinessType b1 = new BusinessType() { Kind = "Factory" };
            //BusinessType b2 = new BusinessType() { Kind = "Quarry" };
            //BusinessType b3 = new BusinessType() { Kind = "Retail" };
            //BusinessType b4 = new BusinessType() { Kind = "Export" };
            //BusinessType b5 = new BusinessType() { Kind = "Import" };
            //context.BusinessTypes.AddOrUpdate(x => x.Kind, b1, b2, b3, b4, b5);

            //Location l1 = new Location() { Country = "Italy", City = "Rome", Address = "Koloseo" };
            //Location l2 = new Location() { Country = "France", City = "Paris", Address = "Panagia" };
            //Location l3 = new Location() { Country = "England", City = "London", Address = "Palace" };
            //Location l4 = new Location() { Country = "Greece", City = "Kastoria", Address = "Kafeneio" };
            //Location l5 = new Location() { Country = "Greece", City = "Crete", Address = "Palaiochora" };
            //Location l6 = new Location() { Country = "Greece", City = "Athens", Address = "Dexamenis" };
            //context.Locations.AddOrUpdate(x => x.City, l1, l2, l3, l4, l5, l6);

            //Provider p1 = new Provider() { CompanyTitle = "2E Marble", Phone="6949326800", WebSite="www.2eMarble.com", Email = "polizos.thodoris@gmail.com", CompanyPhoto= "https://i2.wp.com/daskalakismarble.com/wp-content/uploads/Daskalakis_Marble_SA.jpg?fit=960%2C600&w=640",
            //CompanyDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborumnumquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentiumoptio,eaque rerum! Provident similique accusantium nemo autem.Veritatisobcaecati tenetur iure eius earum ut molestias architecto voluptate aliquamnihil,eveniet aliquid culpa officia aut! Impedit sit sunt quaerat,odit,"};
            //p1.Location = l1;
            //p1.BusinessTypes = new List<BusinessType>() { b1, b2};
            //Provider p2 = new Provider() { CompanyTitle = "2E Marìé", Phone = "6949314800", WebSite = "www.cSharp.com", Email = "polizos.thodoris@gmail.com", CompanyPhoto = "photourl", CompanyDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborumnumquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentiumoptio,eaque rerum! Provident similique accusantium nemo autem.Veritatisobcaecati tenetur iure eius earum ut molestias architecto voluptate aliquamnihil,eveniet aliquid culpa officia aut! Impedit sit sunt quaerat,odit," };
            //p2.Location = l2;
            //p2.BusinessTypes = new List<BusinessType>() { b3, b4 };
            //Provider p3 = new Provider() { CompanyTitle = "3D Stone Tile & Pavers",  Phone="6941626800", WebSite="www.cSharp.com", Email = "www", CompanyPhoto = "photourl", CompanyDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborumnumquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentiumoptio,eaque rerum! Provident similique accusantium nemo autem.Veritatisobcaecati tenetur iure eius earum ut molestias architecto voluptate aliquamnihil,eveniet aliquid culpa officia aut! Impedit sit sunt quaerat,odit," };
            //p3.Location = l3;
            //p3.BusinessTypes = new List<BusinessType>() { b5, b4 };
            //Provider p4 = new Provider() { CompanyTitle = "Turkish Marble ",  Phone="6949326840", WebSite="www.cSharp.com", Email = "www", CompanyPhoto = "photourl", CompanyDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborumnumquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentiumoptio,eaque rerum! Provident similique accusantium nemo autem.Veritatisobcaecati tenetur iure eius earum ut molestias architecto voluptate aliquamnihil,eveniet aliquid culpa officia aut! Impedit sit sunt quaerat,odit,"};
            //p4.Location = l4;
            //p4.BusinessTypes = new List<BusinessType>() { b2 };
            //Provider p5 = new Provider() { CompanyTitle = "A Burslem and Son Ltd", Phone="6949327800", WebSite="www.cSharp.com", Email = "www", CompanyPhoto = "photourl" , CompanyDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborumnumquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentiumoptio,eaque rerum! Provident similique accusantium nemo autem.Veritatisobcaecati tenetur iure eius earum ut molestias architecto voluptate aliquamnihil,eveniet aliquid culpa officia aut! Impedit sit sunt quaerat,odit,"};
            //p5.Location = l5;
            //p5.BusinessTypes = new List<BusinessType>() { b1, b2 };
            //Provider p6 = new Provider() { CompanyTitle = "A2Z MARBLE AND TRAVERTINE",  Phone="6947126800", WebSite="www.cSharp.com", Email = "www", CompanyPhoto = "photourl", CompanyDescription= "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborumnumquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentiumoptio,eaque rerum! Provident similique accusantium nemo autem.Veritatisobcaecati tenetur iure eius earum ut molestias architecto voluptate aliquamnihil,eveniet aliquid culpa officia aut! Impedit sit sunt quaerat,odit," };
            //p6.Location = l6;
            //p6.BusinessTypes = new List<BusinessType>() { b5, b2 };

            //context.Providers.AddOrUpdate(x => new { x.CompanyTitle,x.CompanyPhoto,x.WebSite }, p1, p2, p3, p4, p5, p6);

            //Marble m1 = new Marble() { Name = "ADRANOS ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c1, MarbleDescription= "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborumnumquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentiumoptio,eaque rerum!" };
            //m1.Providers = new List<Provider>() { p1, p2, p3, p4, p5, p6 };

            //Marble m2 = new Marble() { Name = "AFYON  ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro2", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/AFYON.jpg?resize=300%2C180&ssl=1" }, Country = c2, MarbleDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborumnumquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentiumoptio,eaque rerum!" };
            //m2.Providers = new List<Provider>() { p3, p4, p1, p2};

            //Marble m3 = new Marble() { Name = "AGIA MARINA ", Color = "SEMI-WHITE", Photo = new Photo() { PhotoName = "Marmaro3", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Greel_Marble_Agia_Marina_Clouded_Semi_White.jpg?resize=300%2C180&ssl=1" }, Country = c4, MarbleDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborumnumquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentiumoptio,eaque rerum!" };
            //m3.Providers = new List<Provider>() { p5, p6, p1,p2 };

            //Marble m4 = new Marble() { Name = "ALMERA  ", Color = "Pink", Photo = new Photo() { PhotoName = "Marmaro4", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/ALMERA-PINK.jpg?resize=300%2C180&ssl=1" }, Country = c6, MarbleDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborumnumquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentiumoptio,eaque rerum!" };
            //m4.Providers = new List<Provider>() { p1, p2 };

            //Marble m5 = new Marble() { Name = "ARABESCATO", Color = "ALTISSIMO", Photo = new Photo() { PhotoName = "Marmaro5", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/ARABESCATO-ALTISSIMO.jpg?resize=300%2C180&ssl=1" }, Country = c7, MarbleDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborumnumquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentiumoptio,eaque rerum!" };
            //m5.Providers = new List<Provider>() { p3, p4, p1,p2};

            //Marble m6 = new Marble() { Name = "AVAFESCATO ", Color = "CERVAIOLE", Photo = new Photo() { PhotoName = "Marmaro6", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/ARABESCATO-CERVAIOLE.jpg?resize=300%2C180&ssl=1" }, Country = c3, MarbleDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborumnumquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentiumoptio,eaque rerum!" };
            //m6.Providers = new List<Provider>() { p5, p6, p1,p2 };



            //context.Marbles.AddOrUpdate(x => x.Name, m1, m2, m3, m4, m5, m6);
            //context.SaveChanges();

            //#region Seeding Tzavellas

            //// COUNTRIES  A-Z


            Country c1 = new Country() { Name = "Afghanistan" };
            Country c2 = new Country() { Name = "Albania" };
            Country c3 = new Country() { Name = "Algeria" };
            Country c4 = new Country() { Name = "Andorra" };
            Country c5 = new Country() { Name = "Angola" };
            Country c6 = new Country() { Name = "Antigua and Barbuda" };
            Country c7 = new Country() { Name = "Argentina" };
            Country c8 = new Country() { Name = "Armenia" };
            Country c9 = new Country() { Name = "Aruba" };
            Country c10 = new Country() { Name = "Australia" };
            Country c11 = new Country() { Name = "Austria" };
            Country c12 = new Country() { Name = "Azerbaijan" };


            Country c13 = new Country() { Name = "Bahamas" };
            Country c14 = new Country() { Name = "Bahrain" };
            Country c15 = new Country() { Name = "Bangladesh" };
            Country c16 = new Country() { Name = "Barbados" };
            Country c17 = new Country() { Name = "Belarus" };
            Country c18 = new Country() { Name = "Belgium" };
            Country c19 = new Country() { Name = "Belize" };
            Country c20 = new Country() { Name = "Benin" };
            Country c21 = new Country() { Name = "Bhutan" };
            Country c22 = new Country() { Name = "Bolivia" };
            Country c23 = new Country() { Name = "Bosnia and Herzegovina" };
            Country c24 = new Country() { Name = "Botswana" };
            Country c25 = new Country() { Name = "Brazil" };
            Country c26 = new Country() { Name = "Brunei" };
            Country c27 = new Country() { Name = "Bulgaria" };
            Country c28 = new Country() { Name = "Burkina Faso" };
            Country c29 = new Country() { Name = "Burma" };
            Country c30 = new Country() { Name = "Burundi" };


            Country c31 = new Country() { Name = "Cambodia" };
            Country c32 = new Country() { Name = "Cameroon" };
            Country c33 = new Country() { Name = "Canada" };
            Country c34 = new Country() { Name = "Cape Verde" };
            Country c35 = new Country() { Name = "Central African Republic" };
            Country c36 = new Country() { Name = "Chad" };
            Country c37 = new Country() { Name = "Chile" };
            Country c38 = new Country() { Name = "China" };
            Country c39 = new Country() { Name = "Colombia" };
            Country c40 = new Country() { Name = "Comoros" };
            Country c41 = new Country() { Name = "Congo, Democratic Republic of the" };
            Country c42 = new Country() { Name = "Congo, Republic of the" };
            Country c43 = new Country() { Name = "Costa Rica" };
            Country c44 = new Country() { Name = "Cote d’Ivoire" };
            Country c45 = new Country() { Name = "Croatia" };
            Country c46 = new Country() { Name = "Cuba" };
            Country c47 = new Country() { Name = "Curacao" };
            Country c48 = new Country() { Name = "Cyprus" };
            Country c49 = new Country() { Name = "Czech Republic" };


            Country c50 = new Country() { Name = "Denmark" };
            Country c51 = new Country() { Name = "Djibouti" };
            Country c52 = new Country() { Name = "Dominica" };
            Country c53 = new Country() { Name = "Dominican Republic" };


            Country c54 = new Country() { Name = "East Timor (also see Timor-Leste)" };
            Country c55 = new Country() { Name = "Ecuador" };
            Country c56 = new Country() { Name = "Egypt" };
            Country c57 = new Country() { Name = "El Salvador" };
            Country c58 = new Country() { Name = "Equatorial Guinea" };
            Country c59 = new Country() { Name = "Eritrea" };
            Country c60 = new Country() { Name = "Estonia" };
            Country c61 = new Country() { Name = "Ethiopiac" };


            Country c62 = new Country() { Name = "Fiji" };
            Country c63 = new Country() { Name = "Finland" };
            Country c64 = new Country() { Name = "France" };


            Country c65 = new Country() { Name = "Gabon" };
            Country c66 = new Country() { Name = "Gambia" };
            Country c67 = new Country() { Name = "Georgia" };
            Country c68 = new Country() { Name = "Germany" };
            Country c69 = new Country() { Name = "Ghana" };
            Country c70 = new Country() { Name = "Greece" };
            Country c71 = new Country() { Name = "Grenada" };
            Country c72 = new Country() { Name = "Guatemala" };
            Country c73 = new Country() { Name = "Guinea" };
            Country c74 = new Country() { Name = "Guinea-Bissau" };
            Country c75 = new Country() { Name = "Guyana" };


            Country c76 = new Country() { Name = "Haiti" };
            Country c77 = new Country() { Name = "Holy See" };
            Country c78 = new Country() { Name = "Honduras" };
            Country c79 = new Country() { Name = "Hong Kong" };
            Country c80 = new Country() { Name = "Hungary" };


            Country c81 = new Country() { Name = "Iceland" };
            Country c82 = new Country() { Name = "India" };
            Country c83 = new Country() { Name = "Indonesia" };
            Country c84 = new Country() { Name = "Iran" };
            Country c85 = new Country() { Name = "Iraq" };
            Country c86 = new Country() { Name = "Ireland" };
            Country c87 = new Country() { Name = "Israel" };
            Country c88 = new Country() { Name = "Italy" };


            Country c89 = new Country() { Name = "Jamaica" };
            Country c90 = new Country() { Name = "Japan" };
            Country c91 = new Country() { Name = "Jordan" };



            Country c92 = new Country() { Name = "Kazakhstan" };
            Country c93 = new Country() { Name = "Kenya" };
            Country c94 = new Country() { Name = "Kiribati" };
            Country c95 = new Country() { Name = "Korea, North" };
            Country c96 = new Country() { Name = "Korea, South" };
            Country c97 = new Country() { Name = "Kosovo" };
            Country c98 = new Country() { Name = "Kuwait" };
            Country c99 = new Country() { Name = "Kyrgyzstan" };


            Country c100 = new Country() { Name = "Laos" };
            Country c101 = new Country() { Name = "Latvia" };
            Country c102 = new Country() { Name = "Lebanon" };
            Country c103 = new Country() { Name = "Lesotho" };
            Country c104 = new Country() { Name = "Liberia" };
            Country c105 = new Country() { Name = "Libya" };
            Country c106 = new Country() { Name = "Liechtenstein" };
            Country c107 = new Country() { Name = "Lithuania" };
            Country c108 = new Country() { Name = "Luxembourg" };


            Country c109 = new Country() { Name = "Macau" };
            Country c110 = new Country() { Name = "Macedonia" };
            Country c111 = new Country() { Name = "Madagascar" };
            Country c112 = new Country() { Name = "Malawi" };
            Country c113 = new Country() { Name = "Malaysia" };
            Country c114 = new Country() { Name = "Maldives" };
            Country c115 = new Country() { Name = "Mali" };
            Country c116 = new Country() { Name = "Malta" };
            Country c117 = new Country() { Name = "Marshall Islands" };
            Country c118 = new Country() { Name = "Mauritania" };
            Country c119 = new Country() { Name = "Mauritius" };
            Country c120 = new Country() { Name = "Mexico" };
            Country c121 = new Country() { Name = "Micronesia" };
            Country c122 = new Country() { Name = "Moldova" };
            Country c123 = new Country() { Name = "Monaco" };
            Country c124 = new Country() { Name = "Mongolia" };
            Country c125 = new Country() { Name = "Montenegro" };
            Country c126 = new Country() { Name = "Morocco" };
            Country c127 = new Country() { Name = "Mozambique" };


            Country c128 = new Country() { Name = "Namibia" };
            Country c129 = new Country() { Name = "Nauru" };
            Country c130 = new Country() { Name = "Nepal" };
            Country c131 = new Country() { Name = "Netherlands" };
            Country c132 = new Country() { Name = "Netherlands Antilles" };
            Country c133 = new Country() { Name = "New Zealand" };
            Country c134 = new Country() { Name = "Nicaragua" };
            Country c135 = new Country() { Name = "Niger" };
            Country c136 = new Country() { Name = "Nigeria" };
            Country c137 = new Country() { Name = "Norway" };


            Country c138 = new Country() { Name = "Oman" };

            Country c139 = new Country() { Name = "Pakistan" };
            Country c140 = new Country() { Name = "Palau" };
            Country c141 = new Country() { Name = "Palestinian Territories" };
            Country c142 = new Country() { Name = "Panama" };
            Country c143 = new Country() { Name = "Papua New Guinea" };
            Country c144 = new Country() { Name = "Paraguay" };
            Country c145 = new Country() { Name = "Peru" };
            Country c146 = new Country() { Name = "Philippines" };
            Country c147 = new Country() { Name = "Poland" };
            Country c148 = new Country() { Name = "Portugal" };


            Country c149 = new Country() { Name = "Qatar" };


            Country c150 = new Country() { Name = "Romania" };
            Country c151 = new Country() { Name = "Russia" };
            Country c152 = new Country() { Name = "Rwanda" };


            Country c153 = new Country() { Name = "Saint Kitts and Nevis" };
            Country c154 = new Country() { Name = "Saint Lucia" };
            Country c155 = new Country() { Name = "Saint Vincent and the Grenadines" };
            Country c156 = new Country() { Name = "Samoa" };
            Country c157 = new Country() { Name = "San Marino" };
            Country c158 = new Country() { Name = "Sao Tome and Principe" };
            Country c159 = new Country() { Name = "Saudi Arabia" };
            Country c160 = new Country() { Name = "Senegal" };
            Country c161 = new Country() { Name = "Serbia" };
            Country c162 = new Country() { Name = "Seychelles" };
            Country c163 = new Country() { Name = "Sierra Leone" };
            Country c164 = new Country() { Name = "Singapore" };
            Country c165 = new Country() { Name = "Sint Maarten" };
            Country c166 = new Country() { Name = "Slovakia" };
            Country c167 = new Country() { Name = "Slovenia" };
            Country c168 = new Country() { Name = "Solomon Islands" };
            Country c169 = new Country() { Name = "Somalia" };
            Country c170 = new Country() { Name = "South Africa" };
            Country c171 = new Country() { Name = "South Sudan" };
            Country c172 = new Country() { Name = "Spain" };
            Country c173 = new Country() { Name = "Sri Lanka" };
            Country c174 = new Country() { Name = "Sudan" };
            Country c175 = new Country() { Name = "Suriname" };
            Country c176 = new Country() { Name = "Swaziland" };
            Country c177 = new Country() { Name = "Sweden" };
            Country c178 = new Country() { Name = "Switzerland" };
            Country c179 = new Country() { Name = "Syria" };


            Country c180 = new Country() { Name = "Taiwan" };
            Country c181 = new Country() { Name = "Tajikistan" };
            Country c182 = new Country() { Name = "Tanzania" };
            Country c183 = new Country() { Name = "Thailand" };
            Country c184 = new Country() { Name = "Timor-Leste" };
            Country c185 = new Country() { Name = "Togo" };
            Country c186 = new Country() { Name = "Tonga" };
            Country c187 = new Country() { Name = "Trinidad and Tobago" };
            Country c188 = new Country() { Name = "Tunisia" };
            Country c189 = new Country() { Name = "Turkey" };
            Country c190 = new Country() { Name = "Turkmenistan" };
            Country c191 = new Country() { Name = "Tuvalu" };


            Country c192 = new Country() { Name = "Uganda" };
            Country c193 = new Country() { Name = "Ukraine" };
            Country c194 = new Country() { Name = "United Arab Emirates" };
            Country c195 = new Country() { Name = "United Kingdom" };
            Country c196 = new Country() { Name = "Uruguay" };
            Country c197 = new Country() { Name = "Uzbekistan" };


            Country c198 = new Country() { Name = "Vanuatu" };
            Country c199 = new Country() { Name = "Venezuela" };
            Country c200 = new Country() { Name = "Vietnam" };


            Country c201 = new Country() { Name = "Yemen" };


            Country c202 = new Country() { Name = "Zambia" };
            Country c203 = new Country() { Name = "Zimbabwe" };

            context.Countries.AddOrUpdate(x => x.Name,

                c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20, c21, c22, c23, c24, c25, c26, c27, c28, c29, c30,
                c31, c32, c33, c34, c35, c36, c37, c38, c39, c40, c41, c42, c43, c44, c45, c46, c47, c48, c49, c50, c51, c52, c53, c54, c55, c56, c57, c58, c59, c60,
                c61, c62, c63, c64, c65, c66, c67, c68, c69, c70, c71, c72, c73, c74, c75, c76, c77, c78, c79, c80, c81, c82, c83, c84, c85, c86, c87, c88, c89, c90,
                c91, c92, c93, c94, c95, c96, c97, c98, c99, c100, c101, c102, c103, c104, c105, c106, c107, c108, c109, c110, c111, c112, c113, c124, c115, c116, c117, c118, c119, c120,
                c121, c122, c123, c124, c125, c126, c127, c128, c129, c130, c131, c132, c133, c134, c135, c136, c137, c138, c139, c140, c141, c142, c143, c144, c145, c146, c147, c148, c149, c150,
                c151, c152, c153, c154, c155, c156, c157, c158, c159, c160, c161, c162, c163, c164, c165, c166, c167, c168, c169, c170, c171, c172, c173, c174, c175, c176, c177, c178, c179, c180,
                c181, c182, c183, c184, c185, c186, c187, c188, c189, c190, c191, c192, c193, c194, c195, c196, c197, c198, c199, c200, c201, c202, c203


                );


            ////BUSINESS TYPES

            BusinessType b1 = new BusinessType() { Kind = "Factory" };
            BusinessType b2 = new BusinessType() { Kind = "Quarry" };
            BusinessType b3 = new BusinessType() { Kind = "Retail" };
            BusinessType b4 = new BusinessType() { Kind = "Export" };
            BusinessType b5 = new BusinessType() { Kind = "Import" };

            context.BusinessTypes.AddOrUpdate(x => x.Kind, b1, b2, b3, b4, b5);




            // LOCATIONS

            Location l1 = new Location() { Country = "Italy1", City = "Rome1", Address = "Koloseo" };
            Location l2 = new Location() { Country = "Italy2", City = "Rome2", Address = "Koloseo" };
            Location l3 = new Location() { Country = "Italy3", City = "Rome3", Address = "Koloseo" };
            Location l4 = new Location() { Country = "Italy4", City = "Rome4", Address = "Koloseo" };
            Location l5 = new Location() { Country = "Italy5", City = "Rome5", Address = "Koloseo" };
            Location l6 = new Location() { Country = "Italy6", City = "Rome6", Address = "Koloseo" };
            Location l7 = new Location() { Country = "Italy7", City = "Rome7", Address = "Koloseo" };
            Location l8 = new Location() { Country = "Italy8", City = "Rome8", Address = "Koloseo" };
            Location l9 = new Location() { Country = "Italy9", City = "Rome9", Address = "Koloseo" };
            Location l10 = new Location() { Country = "Italy10", City = "Rome10", Address = "Koloseo" };

            Location l11 = new Location() { Country = "Italy11", City = "Rome11", Address = "Koloseo" };
            Location l12 = new Location() { Country = "Italy12", City = "Rome12", Address = "Koloseo" };
            Location l13 = new Location() { Country = "Italy13", City = "Rome13", Address = "Koloseo" };
            Location l14 = new Location() { Country = "Italy14", City = "Rome14", Address = "Koloseo" };
            Location l15 = new Location() { Country = "Italy15", City = "Rome15", Address = "Koloseo" };
            Location l16 = new Location() { Country = "Italy16", City = "Rome16", Address = "Koloseo" };
            Location l17 = new Location() { Country = "Italy17", City = "Rome17", Address = "Koloseo" };
            Location l18 = new Location() { Country = "Italy18", City = "Rome18", Address = "Koloseo" };
            Location l19 = new Location() { Country = "Italy19", City = "Rome19", Address = "Koloseo" };
            Location l20 = new Location() { Country = "Italy20", City = "Rome20", Address = "Koloseo" };

            Location l21 = new Location() { Country = "Italy21", City = "Rome21", Address = "Koloseo" };
            Location l22 = new Location() { Country = "Italy22", City = "Rome22", Address = "Koloseo" };
            Location l23 = new Location() { Country = "Italy23", City = "Rome23", Address = "Koloseo" };
            Location l24 = new Location() { Country = "Italy24", City = "Rome24", Address = "Koloseo" };
            Location l25 = new Location() { Country = "Italy25", City = "Rome25", Address = "Koloseo" };
            Location l26 = new Location() { Country = "Italy26", City = "Rome26", Address = "Koloseo" };
            Location l27 = new Location() { Country = "Italy27", City = "Rome27", Address = "Koloseo" };
            Location l28 = new Location() { Country = "Italy28", City = "Rome28", Address = "Koloseo" };
            Location l29 = new Location() { Country = "Italy29", City = "Rome29", Address = "Koloseo" };
            Location l30 = new Location() { Country = "Italy30", City = "Rome30", Address = "Koloseo" };

            Location l31 = new Location() { Country = "Italy31", City = "Rome31", Address = "Koloseo" };
            Location l32 = new Location() { Country = "Italy32", City = "Rome32", Address = "Koloseo" };
            Location l33 = new Location() { Country = "Italy33", City = "Rome33", Address = "Koloseo" };
            Location l34 = new Location() { Country = "Italy34", City = "Rome34", Address = "Koloseo" };
            Location l35 = new Location() { Country = "Italy35", City = "Rome35", Address = "Koloseo" };
            Location l36 = new Location() { Country = "Italy36", City = "Rome36", Address = "Koloseo" };
            Location l37 = new Location() { Country = "Italy37", City = "Rome37", Address = "Koloseo" };
            Location l38 = new Location() { Country = "Italy38", City = "Rome38", Address = "Koloseo" };
            Location l39 = new Location() { Country = "Italy39", City = "Rome39", Address = "Koloseo" };
            Location l40 = new Location() { Country = "Italy40", City = "Rome40", Address = "Koloseo" };

            Location l41 = new Location() { Country = "Italy41", City = "Rome41", Address = "Koloseo" };
            Location l42 = new Location() { Country = "Italy42", City = "Rome42", Address = "Koloseo" };
            Location l43 = new Location() { Country = "Italy43", City = "Rome43", Address = "Koloseo" };
            Location l44 = new Location() { Country = "Italy44", City = "Rome44", Address = "Koloseo" };
            Location l45 = new Location() { Country = "Italy45", City = "Rome45", Address = "Koloseo" };
            Location l46 = new Location() { Country = "Italy46", City = "Rome46", Address = "Koloseo" };
            Location l47 = new Location() { Country = "Italy47", City = "Rome47", Address = "Koloseo" };
            Location l48 = new Location() { Country = "Italy48", City = "Rome48", Address = "Koloseo" };
            Location l49 = new Location() { Country = "Italy49", City = "Rome49", Address = "Koloseo" };
            Location l50 = new Location() { Country = "Italy50", City = "Rome50", Address = "Koloseo" };

            context.Locations.AddOrUpdate(x => x.City,
                 l1, l2, l3, l4, l5, l6, l7, l8, l9, l10, l11, l12, l13, l14, l15, l16, l17, l18, l19, l20,
                 l21, l22, l23, l24, l25, l26, l27, l28, l29, l30, l31, l32, l33, l34, l35, l36, l37, l38, l39, l40,
                 l41, l42, l43, l44, l45, l46, l47, l48, l49, l50

                );



            //// PROVIDERS

            Provider p1 = new Provider() { CompanyTitle = "2E Marble", Phone = "", WebSite = "", Email = " ", CompanyPhoto = " " };
            p1.BusinessTypes = new List<BusinessType>() { b1, b4 };
            p1.Location = l1;

            Provider p2 = new Provider() { CompanyTitle = "A.A.T.C. and Co. S.r.l – Italian Marble Company", Phone = "0039 0456 861057", WebSite = "http://www.aatc.it/", Email = "www ", CompanyPhoto = "https://i1.wp.com/marbleguide.com/wp-content/uploads/aatc31.png?zoom=1.25&resize=245%2C70&ssl=1" };
            p2.BusinessTypes = new List<BusinessType>() { b1, b4 };
            p2.Location = l2;

            Provider p3 = new Provider() { CompanyTitle = "Aadhar Primeexim", Phone = "0091 291 2635619", WebSite = "www.aadharexim.com", Email = "www ", CompanyPhoto = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Aadhar-Primeexim-Logo.png?resize=89%2C68&ssl=1" };
            p3.BusinessTypes = new List<BusinessType>() { b1, b2 };
            p3.Location = l3;

            Provider p4 = new Provider() { CompanyTitle = "Abdeen Stone for Marble and Granite", Phone = "002 012 87104990", WebSite = "www.abdeenstone.net", Email = "www ", CompanyPhoto = "https://i1.wp.com/marbleguide.com/wp-content/uploads/abdeen-stone-logo.png?w=484&ssl=1" };
            p4.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };
            p4.Location = l4;

            Provider p5 = new Provider() { CompanyTitle = "ACROPOLE MARBLE", Phone = "+357 9671 9945", WebSite = "www.acropolemarble.com/", Email = "www ", CompanyPhoto = "" };
            p5.BusinessTypes = new List<BusinessType>() { b1 };
            p5.Location = l5;

            Provider p6 = new Provider() { CompanyTitle = "Afrika National Granite", Phone = "0027 11 908 3595", WebSite = "www.ang.co.za", Email = "www ", CompanyPhoto = "https://i1.wp.com/marbleguide.com/wp-content/uploads/AFRIKA-NATIONAL-GRANITE-LOGO.png?zoom=1.25&resize=92%2C109&ssl=1" };
            p6.BusinessTypes = new List<BusinessType>() { b1, b2 };
            p6.Location = l6;

            Provider p7 = new Provider() { CompanyTitle = "AGHIA MARINA MARBLE LTD.", Phone = "+30 210-6039362", WebSite = "www.perrakis.eu", Email = " www", CompanyPhoto = "" };
            p7.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };
            p7.Location = l7;

            Provider p8 = new Provider() { CompanyTitle = "AKROLITHOS Ltd", Phone = "0030 25920 51400", WebSite = "www.akrolithos.gr", Email = " www", CompanyPhoto = "https://i2.wp.com/marbleguide.com/wp-content/uploads/Akrolithos-natural-stones.jpg?w=743&ssl=1" };
            p8.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };
            p8.Location = l8;

            Provider p9 = new Provider() { CompanyTitle = "AL HASSANA MARBLE", Phone = "0020229700402", WebSite = "www.alhassana.com", Email = "www ", CompanyPhoto = "https://i0.wp.com/marbleguide.com/wp-content/uploads/ALHASSANA-LOGO.png?zoom=1.25&resize=200%2C55&ssl=1" };
            p9.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };
            p9.Location = l9;


            Provider p10 = new Provider() { CompanyTitle = "Al Nada Group for Marble & Granite", Phone = "0020 1 118585224", WebSite = "www.alnada-marble.com", Email = "www ", CompanyPhoto = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Al-Nada-Group-for-Marble-Granite.jpg?resize=173%2C106&ssl=1" };
            p10.BusinessTypes = new List<BusinessType>() { b1, b4 };
            p10.Location = l10;


            Provider p11 = new Provider() { CompanyTitle = "Al-Cobra for Marble and Granite", Phone = "0020 2 6909635", WebSite = "www.alcobra2mg.com", Email = "www ", CompanyPhoto = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Al-Cobra-for-Marble-and-Granite-logo.jpg?resize=136%2C250&ssl=1" };
            p11.BusinessTypes = new List<BusinessType>() { b4, b5 };
            p11.Location = l11;


            Provider p12 = new Provider() { CompanyTitle = "Al-Rashad Marble Co.", Phone = "0020 2 29700600", WebSite = "www.alrashadmarble.net", Email = "www ", CompanyPhoto = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Al-Rashad-Marble-Co.-Logo.jpg?resize=169%2C76&ssl=1" };
            p12.BusinessTypes = new List<BusinessType>() { b1, b4 };
            p12.Location = l12;


            Provider p13 = new Provider() { CompanyTitle = "Albadr Marble Stone Co.", Phone = "01003630067", WebSite = "http://www.albadr-marble-stone.com/", Email = " www", CompanyPhoto = "https://i0.wp.com/marbleguide.com/wp-content/uploads/ALBADR-MARBLE-STONE-CO-LOGO.jpg?resize=880%2C183&ssl=1" };
            p13.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };
            p13.Location = l13;


            Provider p14 = new Provider() { CompanyTitle = "Alberti and Alberti S.r.l.", Phone = "00390456260444", WebSite = "www.marmialberti.it", Email = "www ", CompanyPhoto = "https://i2.wp.com/marbleguide.com/wp-content/uploads/logo-aea.png?resize=102%2C64&ssl=1" };
            p14.BusinessTypes = new List<BusinessType>() { b1, b4 };
            p14.Location = l14;


            Provider p15 = new Provider() { CompanyTitle = "Aldur Madencilik", Phone = "0090 0 232 621 34 40", WebSite = "www.aldur.com.tr", Email = "www ", CompanyPhoto = "https://i0.wp.com/marbleguide.com/wp-content/uploads/aldur-madencilik-logo.jpg?resize=880%2C480&ssl=1" };
            p15.BusinessTypes = new List<BusinessType>() { b1 };
            p15.Location = l15;


            Provider p16 = new Provider() { CompanyTitle = "Alfa Stone For Marble and Quarries", Phone = "0020 2 27541379", WebSite = "www.alfa-stone.com", Email = "www ", CompanyPhoto = "https://i2.wp.com/marbleguide.com/wp-content/uploads/Alfa-Stone-For-Marble-and-Quarries-LOGO-MARBLEGUIDE.jpg?resize=147%2C127&ssl=1" };
            p16.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };
            p16.Location = l16;


            Provider p17 = new Provider() { CompanyTitle = "Alpa Hellas Marbles", Phone = "00302103425198", WebSite = "alpahellasmarbles.gr", Email = "www ", CompanyPhoto = "https://i0.wp.com/marbleguide.com/wp-content/uploads/LOGO-ALPA-MARBLES.jpg?w=400&ssl=1" };
            p17.BusinessTypes = new List<BusinessType>() { b1 };
            p17.Location = l17;

            Provider p18 = new Provider() { CompanyTitle = "Alpha Mena, Export Marble and Granite", Phone = "002-0106 2445527", WebSite = "www.alphamena.webs.com", Email = "www ", CompanyPhoto = "https://i2.wp.com/marbleguide.com/wp-content/uploads/Alpha-Mena-logo.jpg?resize=225%2C225&ssl=1" };
            p18.BusinessTypes = new List<BusinessType>() { b1, b4 };
            p18.Location = l18;


            Provider p19 = new Provider() { CompanyTitle = "ALSAMAR A.V.E.E.", Phone = "+30 25410 93752", WebSite = " www.alsamar.gr", Email = "www ", CompanyPhoto = "" };
            p19.BusinessTypes = new List<BusinessType>() { b1, b4, b5 };
            p19.Location = l19;


            Provider p20 = new Provider() { CompanyTitle = "Anjalee Granite", Phone = "0091 98855 66709", WebSite = "www.anjalee.com", Email = "www ", CompanyPhoto = "https://i1.wp.com/marbleguide.com/wp-content/uploads/anjalee-Logo.png?w=500&ssl=1" };
            p20.BusinessTypes = new List<BusinessType>() { b1, b2 };
            p20.Location = l20;


            Provider p21 = new Provider() { CompanyTitle = "Arihant Marbles", Phone = "0091 9414017329", WebSite = "www.arihantmarbles.com", Email = "www ", CompanyPhoto = "https://i2.wp.com/marbleguide.com/wp-content/uploads/Arihant-Marbles-Logo.jpg?w=505&ssl=1" };
            p21.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };
            p21.Location = l21;


            Provider p22 = new Provider() { CompanyTitle = "Aro Granite", Phone = "0091 4344 252100", WebSite = "www.arotile.com", Email = " www", CompanyPhoto = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Aro-Granite-Logo.jpg?resize=880%2C85&ssl=1" };
            p22.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };
            p22.Location = l22;


            Provider p23 = new Provider() { CompanyTitle = "Azul Aran", Phone = "0034 973 64 73 95", WebSite = "www.azularan.com", Email = " www", CompanyPhoto = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Azul-Aran-logo.jpg?resize=401%2C85&ssl=1" };
            p23.BusinessTypes = new List<BusinessType>() { b1, b2 };
            p23.Location = l23;


            Provider p24 = new Provider() { CompanyTitle = "Azul italia", Phone = "0039 02817551", WebSite = "www.azulitalia.it", Email = "www ", CompanyPhoto = "https://i1.wp.com/marbleguide.com/wp-content/uploads/azul-italia-logo1.png?resize=230%2C130&ssl=1" };
            p24.BusinessTypes = new List<BusinessType>() { b1, b2 };
            p24.Location = l24;


            Provider p25 = new Provider() { CompanyTitle = "Bacci Marmi", Phone = "0039 0584757537", WebSite = "www.baccimarmi.it", Email = "www ", CompanyPhoto = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Bacci-Marmi-Logo-e1479318073559.jpg?zoom=2&resize=880%2C480&ssl=1" };
            p25.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };
            p25.Location = l25;


            Provider p26 = new Provider() { CompanyTitle = "Bahavan Granites", Phone = "0091 44 42170696", WebSite = "www.bahavangranites.com", Email = "www ", CompanyPhoto = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Bhavan-Granites-Logo..jpg?resize=256%2C197&ssl=1" };
            p26.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };
            p26.Location = l26;


            Provider p27 = new Provider() { CompanyTitle = "BALKAN SA MARBLE MANUFACTURE", Phone = "+302521068030", WebSite = "", Email = "www ", CompanyPhoto = "" };
            p27.BusinessTypes = new List<BusinessType>() { b1, b2, b3, b4, b5 };
            p27.Location = l27;


            Provider p28 = new Provider() { CompanyTitle = "BORCHARDT STONE", Phone = "0055 27 3732-5048", WebSite = "www.borchardtstone.com", Email = "www ", CompanyPhoto = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Borchardt-logo.png?resize=252%2C251&ssl=1" };
            p28.BusinessTypes = new List<BusinessType>() { b2, b4 };
            p28.Location = l28;


            Provider p29 = new Provider() { CompanyTitle = "Brasigran Granitos", Phone = "005527 2124 1421", WebSite = "www.mcorcovado.com.br", Email = "www ", CompanyPhoto = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Brasigran-Granitos-logo.png?resize=204%2C49&ssl=1" };
            p29.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };
            p29.Location = l29;


            Provider p30 = new Provider() { CompanyTitle = "BVL Granites", Phone = "0091 40 23607488", WebSite = "www.bvlgranites.com", Email = "www ", CompanyPhoto = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Bvl-Granites-logo-e1479991541984.png?resize=200%2C70&ssl=1" };
            p30.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };
            p30.Location = l30;


            Provider p31 = new Provider() { CompanyTitle = "Ceramiche Cerdisa", Phone = "00309 0522 773602", WebSite = "www.ceramichecerdisa.it/en/", Email = "www ", CompanyPhoto = "https://i2.wp.com/marbleguide.com/wp-content/uploads/cerdisa-logo.jpg?resize=246%2C172&ssl=1" };
            p31.BusinessTypes = new List<BusinessType>() { b1 };
            p31.Location = l31;


            Provider p32 = new Provider() { CompanyTitle = "Coex Granite", Phone = "0055 27 2124-3341", WebSite = "www.coexgranite.com", Email = "www ", CompanyPhoto = "https://i0.wp.com/marbleguide.com/wp-content/uploads/coex-granite-logo.jpg?resize=163%2C93&ssl=1" };
            p32.BusinessTypes = new List<BusinessType>() { b2, b4 };
            p32.Location = l32;


            Provider p33 = new Provider() { CompanyTitle = "CRYSTAL FOR MARBLE AND GRANITE", Phone = "00 202 29700 551", WebSite = "www.crystal.com.eg", Email = "www ", CompanyPhoto = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Crystal-Marble-and-Granite-Logo.jpg?resize=176%2C171&ssl=1" };
            p33.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };
            p33.Location = l33;


            Provider p34 = new Provider() { CompanyTitle = "DASKALAKIS MARBLE S.A", Phone = "+30210 6612106, 6610888", WebSite = "www.daskalakismarble.com", Email = "www ", CompanyPhoto = "https://i0.wp.com/marbleguide.com/wp-content/uploads/daskalakis-marble-logo.jpg?zoom=1.25&resize=256%2C144&ssl=1" };
            p34.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };
            p34.Location = l34;


            Provider p35 = new Provider() { CompanyTitle = "DASKALAKIS NATURAL STONES", Phone = "+30 2821 064557", WebSite = "www.daskalakis-stones.gr", Email = "www ", CompanyPhoto = "" };
            p35.BusinessTypes = new List<BusinessType>() { b3, b5 };
            p35.Location = l35;


            Provider p36 = new Provider() { CompanyTitle = "DERMITZAKIS BROS – GREEK WHITE MARBLE", Phone = "+30 25910 24942", WebSite = "", Email = "www ", CompanyPhoto = "https://i1.wp.com/marbleguide.com/wp-content/uploads/DERMITZAKIS-BROS-GREEK-WHITE-MARBLE-LOGO.jpg?resize=225%2C224&ssl=1" };
            p36.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };
            p36.Location = l36;


            Provider p37 = new Provider() { CompanyTitle = "DIONYSSOMARBLE COMPANY SA", Phone = "0030-2106211400", WebSite = "", Email = "www ", CompanyPhoto = "https://i2.wp.com/marbleguide.com/wp-content/uploads/DIONYSSOMARBLE-LOGO.jpg?resize=530%2C480&ssl=1" };
            p37.BusinessTypes = new List<BusinessType>() { b1, b2, b4, b5 };
            p37.Location = l37;


            Provider p38 = new Provider() { CompanyTitle = "Dorgham For Marble and Granite", Phone = "002 0222614415", WebSite = "www.dorghammarble.com", Email = "www ", CompanyPhoto = "https://i2.wp.com/marbleguide.com/wp-content/uploads/Dorgham-logo.gif?resize=334%2C133&ssl=1" };
            p38.BusinessTypes = new List<BusinessType>() { b1, b4 };
            p38.Location = l38;


            Provider p39 = new Provider() { CompanyTitle = "DORIKA MARMARA S.A.", Phone = "+306936608637,(+30) 25210.81601", WebSite = "", Email = "www ", CompanyPhoto = "" };
            p39.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };
            p39.Location = l39;


            Provider p40 = new Provider() { CompanyTitle = "DreamStone – Egyptian Marble Company", Phone = "202 382 43 121", WebSite = "www.dream-stone.com", Email = "www ", CompanyPhoto = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Dream-stone-logo.jpg?zoom=1.25&resize=180%2C78&ssl=1" };
            p40.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };
            p40.Location = l40;


            Provider p41 = new Provider() { CompanyTitle = "El Zomordah for Marble and Granite", Phone = "00 202 275 41 247", WebSite = "www.zomordah.com", Email = "www ", CompanyPhoto = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Logo2.jpg?resize=424%2C161&ssl=1" };
            p41.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };
            p41.Location = l41;


            Provider p42 = new Provider() { CompanyTitle = "Elc Marble, Egyptian Lebanese Co.", Phone = "002 0100 188 66 30", WebSite = "www.elc-eg.com", Email = "www ", CompanyPhoto = "https://i0.wp.com/marbleguide.com/wp-content/uploads/ELC_Marble_logo.png?resize=338%2C97&ssl=1" };
            p42.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };
            p42.Location = l42;


            Provider p43 = new Provider() { CompanyTitle = "Elios Ceramica", Phone = "0039 0536 842411", WebSite = "http://www.eliosceramica.com/", Email = "www ", CompanyPhoto = "https://i1.wp.com/marbleguide.com/wp-content/uploads/elios-ceramica-logo..jpeg?resize=220%2C120&ssl=1" };
            p43.BusinessTypes = new List<BusinessType>() { b5 };
            p43.Location = l43;


            Provider p44 = new Provider() { CompanyTitle = "FHL I.KIRIAKIDIS ~ MARBLES and GRANITES S.A.", Phone = " 0030-6974030383,+30 25210 81360 -3-4-5", WebSite = "www.fhl.gr", Email = "www ", CompanyPhoto = "https://i2.wp.com/marbleguide.com/wp-content/uploads/FHL-I.KIRIAKIDIS-MARBLES-and-GRANITES-S.A-logo.png?zoom=1.25&resize=189%2C143&ssl=1" };
            p44.BusinessTypes = new List<BusinessType>() { b1, b2, b3, b4, b5 };
            p44.Location = l44;


            Provider p45 = new Provider() { CompanyTitle = "FIRST MARBLE", Phone = "", WebSite = "www.first-marble.com", Email = "www ", CompanyPhoto = "https://i2.wp.com/marbleguide.com/wp-content/uploads/first-marble-logo.png?resize=166%2C184&ssl=1" };
            p45.BusinessTypes = new List<BusinessType>() { b5 };
            p45.Location = l45;


            Provider p46 = new Provider() { CompanyTitle = "GALANIS MARBLE S.A.", Phone = "(+30) 27530 22557", WebSite = "www.galanisquarries.com", Email = "www ", CompanyPhoto = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Quarry_GALANIS.jpg?zoom=1.25&resize=860%2C469&ssl=1" };
            p46.BusinessTypes = new List<BusinessType>() { b2, b4 };
            p46.Location = l46;


            Provider p47 = new Provider() { CompanyTitle = "Galleni Gino Marmi", Phone = "0039 0585 844489", WebSite = "www.gallenimarmi.com", Email = "www ", CompanyPhoto = "https://i2.wp.com/marbleguide.com/wp-content/uploads/galleni-marmi-logo.jpg?zoom=1.25&resize=181%2C153&ssl=1" };
            p47.BusinessTypes = new List<BusinessType>() { b2 };
            p47.Location = l47;


            Provider p48 = new Provider() { CompanyTitle = "Geostones", Phone = "+49-(0)-4141-788 18 98", WebSite = "http://geostones.eu", Email = "www ", CompanyPhoto = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Geostones-Logo.jpg?resize=300%2C300&ssl=1" };
            p48.BusinessTypes = new List<BusinessType>() { b1, b2, b4 };
            p48.Location = l48;


            Provider p49 = new Provider() { CompanyTitle = "Giannakis Marble", Phone = "0030 25220 23596", WebSite = "www.giannakis-marble.gr", Email = "www ", CompanyPhoto = "https://i0.wp.com/marbleguide.com/wp-content/uploads/giannakis-marble-logo.jpg?zoom=1.25&resize=860%2C78&ssl=1" };
            p49.BusinessTypes = new List<BusinessType>() { b5 };
            p49.Location = l49;


            Provider p50 = new Provider() { CompanyTitle = "GLOBAL STONES LTD", Phone = "0020227549770", WebSite = "www.gsglobalstones.com", Email = "www ", CompanyPhoto = "https://i0.wp.com/marbleguide.com/wp-content/uploads/global-stone-logo.jpg?zoom=1.25&resize=172%2C71&ssl=1" };
            p50.BusinessTypes = new List<BusinessType>() { b5 };
            p50.Location = l50;


            context.Providers.AddOrUpdate(x => new { x.CompanyTitle, x.CompanyPhoto, x.WebSite },
               p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20,
                p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40,
                p41, p42, p43, p44, p45, p46, p47, p48, p49, p50
                );




            ////MARBLE


            Marble m1 = new Marble() { Name = "AEGEAN WHITE Greek Marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Aegean-Cream-Greek-Marble.jpg?zoom=1.25&resize=860%2C469&ssl=1" }, Country = c70 };
            m1.Providers = new List<Provider>() { p7, p8, p17, p19 };

            Marble m2 = new Marble() { Name = "AGIA MARINA CLOUDED SEMI-WHITE Greek Marble", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Greel_Marble_Agia_Marina_Clouded_Semi_White.jpg?resize=300%2C180&ssl=1" }, Country = c70 };
            m2.Providers = new List<Provider>() { p27, p34, p35 };

            Marble m3 = new Marble() { Name = "AGIOS KYRILLOS (POMPIA) GREY Greek marble", Color = "Grey", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Greek_Marble_Agios-Kyrillos-Pompia-Grey.jpg?resize=300%2C180&ssl=1" }, Country = c70 };
            m3.Providers = new List<Provider>() { p36, p37, p39 };

            Marble m4 = new Marble() { Name = "ALIVERI GREY Greek marble", Color = "Grey", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Greek_Marble_Aliveri_Grey.jpg?resize=300%2C180&ssl=1" }, Country = c70 };
            m4.Providers = new List<Provider>() { p44, p46, p48, p49 };

            Marble m5 = new Marble() { Name = "ALOIDES SEMI WHITE Greek marble", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/ALOIDES-SEMIWHITE.jpg?resize=300%2C180&ssl=1" }, Country = c70 };
            m5.Providers = new List<Provider>() { p7, p8, p17, p19, p36, p37 };

            Marble m6 = new Marble() { Name = "ARAXOVA Greek marble", Color = "Brown", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i2.wp.com/marbleguide.com/wp-content/uploads/Greek_Marble_Araxova.jpg?resize=300%2C180&ssl=1" }, Country = c70 };
            m6.Providers = new List<Provider>() { p44, p46 };

            Marble m7 = new Marble() { Name = "ARGOS BLACK Greek marble ", Color = "Black", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Greek_Marble_Argos_Black.jpg?resize=300%2C180&ssl=1" }, Country = c70 };
            m7.Providers = new List<Provider>() { p36, p37, p48, p49 };

            Marble m8 = new Marble() { Name = "ARIDAIA TRAVERTINO Greek marble ", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i2.wp.com/marbleguide.com/wp-content/uploads/Greek_Marble_Aridaia_Travertino.jpg?resize=300%2C180&ssl=1" }, Country = c70 };
            m8.Providers = new List<Provider>() { p17, p19 };

            Marble m9 = new Marble() { Name = "ARTA PINK Greek marble ", Color = "Pink", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Greek_Marble_Arta_Pink.jpg?resize=300%2C180&ssl=1" }, Country = c70 };
            m9.Providers = new List<Provider>() { p36 };

            Marble m10 = new Marble() { Name = "CHALKEROU CRYSTALLINA SEMI WHITE Greek marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Greel_Marble_Chalkerou-Crystallina-Semi-White.jpg?resize=300%2C180&ssl=1" }, Country = c70 };
            m10.Providers = new List<Provider>() { p7, p8, p17, p19, p36, p37, p44, p46, p48, p49 };



            Marble m11 = new Marble() { Name = "ARABESCATO ALTISSIMO Italian marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/ARABESCATO-ALTISSIMO.jpg?resize=300%2C180&ssl=1" }, Country = c88 };
            m11.Providers = new List<Provider>() { p2, p14 };

            Marble m12 = new Marble() { Name = "ARABESCATO ARNI Italian marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i2.wp.com/marbleguide.com/wp-content/uploads/Arabescato-Arni.jpg?resize=300%2C180&ssl=1" }, Country = c88 };
            m12.Providers = new List<Provider>() { p24, p25 };

            Marble m13 = new Marble() { Name = "ARABESCATO CERVAIOLE Italian marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/ARABESCATO-CERVAIOLE.jpg?resize=300%2C180&ssl=1" }, Country = c88 };
            m13.Providers = new List<Provider>() { p31, p43 };

            Marble m14 = new Marble() { Name = "ARABESCATO CORCHIA Italian marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i2.wp.com/marbleguide.com/wp-content/uploads/Arabescato-Corchia.jpg?resize=300%2C180&ssl=1" }, Country = c88 };
            m14.Providers = new List<Provider>() { p47 };

            Marble m15 = new Marble() { Name = "ARABESCATO Italian marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/ARABESCATO.jpg?resize=300%2C180&ssl=1" }, Country = c88 };
            m15.Providers = new List<Provider>() { p2, p14, p24, p25 };

            Marble m16 = new Marble() { Name = "ARABESCATO MOSSA Italian marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i2.wp.com/marbleguide.com/wp-content/uploads/Arabescato-Mossa-1.jpg?resize=300%2C180&ssl=1" }, Country = c88 };
            m16.Providers = new List<Provider>() { p2, p14, p24, p25, p31, p43 };

            Marble m17 = new Marble() { Name = "ARABESCATO OROBICO GRIGIO Italian marble ", Color = "Grey", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i2.wp.com/marbleguide.com/wp-content/uploads/Arabescato-Orobico-Grigio.jpg?resize=300%2C180&ssl=1" }, Country = c88 };
            m17.Providers = new List<Provider>() { p31, p43 };

            Marble m18 = new Marble() { Name = "ARABESCATO VAGLI Italian marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Arabescato-Vagli.jpg?resize=300%2C180&ssl=1" }, Country = c88 };
            m18.Providers = new List<Provider>() { p2, p24, p25 };

            Marble m19 = new Marble() { Name = "BARDIGLIO COSTA Italian marble ", Color = "Grey", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Bardiglio-Costa.jpg?resize=300%2C180&ssl=1" }, Country = c88 };
            m19.Providers = new List<Provider>() { p24, p25, p31 };

            Marble m20 = new Marble() { Name = "BARDIGLIO IMPERIALE Italian marble ", Color = "Grey", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Bardiglio-Imperiale.jpg?resize=300%2C180&ssl=1" }, Country = c88 };
            m20.Providers = new List<Provider>() { p31 };



            Marble m21 = new Marble() { Name = "ALMERA PINK Egyptian marble ", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/ALMERA-PINK.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            m21.Providers = new List<Provider>() { p4, p9 };

            Marble m22 = new Marble() { Name = "BRECCIA FAWAKHIR Egyptian marble ", Color = "Green", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i2.wp.com/marbleguide.com/wp-content/uploads/Breccia-Fawakir.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            m22.Providers = new List<Provider>() { p10, p11, p12 };

            Marble m23 = new Marble() { Name = "CHANTEUIL JAUNE BLEU French marble ", Color = "Blue", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Chanteuil-Jaune-Bleu.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            m23.Providers = new List<Provider>() { p13, p16 };

            Marble m24 = new Marble() { Name = "GALALA Egyptian marble ", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Galala.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            m24.Providers = new List<Provider>() { p18, p33, p40, p41 };

            Marble m25 = new Marble() { Name = "GIALLO ATLANTIDE Egyptian marble ", Color = "Yellow", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Giallo-Atlantide.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            m25.Providers = new List<Provider>() { p42, p45 };

            Marble m26 = new Marble() { Name = "IVORY CLASSIC Egyptian marble ", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Ivory-Classic.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            m26.Providers = new List<Provider>() { p50 };

            Marble m27 = new Marble() { Name = "MARIGOLD Egyptian marble", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i2.wp.com/marbleguide.com/wp-content/uploads/Marigold.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            m27.Providers = new List<Provider>() { p10, p11, p12, p18, p33, p40, p41 };

            Marble m28 = new Marble() { Name = "GIALLO CLEOPATRA Egyptian marble ", Color = "Yellow", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Giallo-Atlantide.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            m28.Providers = new List<Provider>() { p4, p10, p12, p16, p33, p38, p42, p45, p50 };

            Marble m29 = new Marble() { Name = "ONYX ALABASTER Egyptian onyx ", Color = "Yellow", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Onyx-Alabaster.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            m29.Providers = new List<Provider>() { p9, p11, p13, p18, p38, p41, p45 };

            Marble m30 = new Marble() { Name = "SAMAHA Egyptian marble ", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i2.wp.com/marbleguide.com/wp-content/uploads/Samaha.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            m30.Providers = new List<Provider>() { p9, p33, p38, p45, p50 };

            Marble m31 = new Marble() { Name = "SILVIA ORO ", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i2.wp.com/marbleguide.com/wp-content/uploads/SILVIA-ORO.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            m31.Providers = new List<Provider>() { p10, p11, p12, p42, p45 };

            Marble m32 = new Marble() { Name = "SINAI PEARL Egyptian limestone ", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Sinai-Pearl.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            m32.Providers = new List<Provider>() { p13, p16 };

            Marble m33 = new Marble() { Name = "Sunny marble ", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Sunny_Light.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            m33.Providers = new List<Provider>() { p4, p10, p12, p16, p33 };

            Marble m34 = new Marble() { Name = "YLANG Egyptian marble ", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i2.wp.com/marbleguide.com/wp-content/uploads/Ylang.jpg?resize=300%2C180&ssl=1" }, Country = c56 };
            m34.Providers = new List<Provider>() { p18, p33 };



            Marble m35 = new Marble() { Name = "ADONIS BEIGE Turkish marble ", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adonis-Beige.jpg?resize=300%2C180&ssl=1" }, Country = c189 };
            m35.Providers = new List<Provider>() { p15 };

            Marble m36 = new Marble() { Name = "ADRANOS WHITE Turkish marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Adranos.jpg?resize=300%2C180&ssl=1" }, Country = c189 };
            m36.Providers = new List<Provider>() { p15 };

            Marble m37 = new Marble() { Name = "AEGEAN BORDEAUX Turkish marble ", Color = "Red", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Aegean-Bordeaux.jpg?resize=300%2C180&ssl=1" }, Country = c189 };
            m37.Providers = new List<Provider>() { p24, p25, p31 };

            Marble m38 = new Marble() { Name = "AFYON WHITE Turkish marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/AFYON.jpg?resize=300%2C180&ssl=1" }, Country = c189 };
            m38.Providers = new List<Provider>() { p9, p33, p38, p45, p50 };

            Marble m39 = new Marble() { Name = "AKSEHIR BLACK Turkish marble ", Color = "Black", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Aksehir-black.jpg?resize=300%2C180&ssl=1" }, Country = c189 };
            m39.Providers = new List<Provider>() { p38 };



            Marble m40 = new Marble() { Name = "AMAZONIA BROWN Brazilian marble ", Color = "Brown", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Amazonia-Brown.jpg?resize=300%2C180&ssl=1" }, Country = c25 };
            m40.Providers = new List<Provider>() { p28 };

            Marble m41 = new Marble() { Name = "ARGENTO Brazilian marble ", Color = "Grey", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i2.wp.com/marbleguide.com/wp-content/uploads/Argento.jpg?resize=300%2C180&ssl=1" }, Country = c25 };
            m41.Providers = new List<Provider>() { p29 };

            Marble m42 = new Marble() { Name = "AZUL ACQUAMARINA Brazilian marble ", Color = "Blue", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i2.wp.com/marbleguide.com/wp-content/uploads/Azul-Acquamarina.jpg?resize=300%2C180&ssl=1" }, Country = c25 };
            m42.Providers = new List<Provider>() { p32 };

            Marble m43 = new Marble() { Name = "AZUL BOCQUIRA Brazilian marble ", Color = "Blue", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Azul-Bocchira.jpg?resize=300%2C180&ssl=1" }, Country = c25 };
            m43.Providers = new List<Provider>() { p28, p29 };

            Marble m44 = new Marble() { Name = "BRANCO CACHOEIRO Brazilian marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i2.wp.com/marbleguide.com/wp-content/uploads/Branco-Cachoeiro.jpg?resize=300%2C180&ssl=1" }, Country = c25 };
            m44.Providers = new List<Provider>() { p28, p32 };

            Marble m45 = new Marble() { Name = "ADRBRANCO CARRARINHA Brazilian marbleANOS ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i2.wp.com/marbleguide.com/wp-content/uploads/Branco-Carrarinha.jpg?resize=300%2C180&ssl=1" }, Country = c25 };
            m45.Providers = new List<Provider>() { p29, p32 };

            Marble m46 = new Marble() { Name = "BRANCO COMUM Brazilian marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i2.wp.com/marbleguide.com/wp-content/uploads/Branco-Comum.jpg?resize=300%2C180&ssl=1" }, Country = c25 };
            m46.Providers = new List<Provider>() { p28 };

            Marble m47 = new Marble() { Name = "BRANCO RAJADO Brazilian marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Branco-Rajado.jpg?resize=300%2C180&ssl=1" }, Country = c25 };
            m47.Providers = new List<Provider>() { p28, p29, p32 };



            Marble m48 = new Marble() { Name = "AGRA WHITE Indian sandstone ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Agra-White.jpg?resize=300%2C180&ssl=1" }, Country = c82 };
            m48.Providers = new List<Provider>() { p3, p20 };

            Marble m49 = new Marble() { Name = "BHAINSLANA BLACK indian marble ", Color = "Black", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i2.wp.com/marbleguide.com/wp-content/uploads/Bhainslana-Black-1.jpg?resize=300%2C180&ssl=1" }, Country = c82 };
            m49.Providers = new List<Provider>() { p21, p22 };

            Marble m50 = new Marble() { Name = "BIDASAR BROWN India marble ", Color = "Brown", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i1.wp.com/marbleguide.com/wp-content/uploads/Bidasar-Brown.jpg?resize=300%2C180&ssl=1" }, Country = c82 };
            m50.Providers = new List<Provider>() { p26, p30 };

            Marble m51 = new Marble() { Name = "DHOLPUR WHITE Indian sandstone ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Dholpur-White.jpg?resize=300%2C180&ssl=1" }, Country = c82 };
            m51.Providers = new List<Provider>() { p3, p21 };

            Marble m52 = new Marble() { Name = "HIMACHAL WHITE Indian quartzite ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i2.wp.com/marbleguide.com/wp-content/uploads/Himachal-White.jpg?resize=300%2C180&ssl=1" }, Country = c82 };
            m52.Providers = new List<Provider>() { p3, p20, p21, p22, p26, p30 };

            Marble m53 = new Marble() { Name = "JAIPUR RAINBOW Indian sandstone ", Color = "Multicolor", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Jaipur-Rainbow.jpg?resize=300%2C180&ssl=1" }, Country = c82 };
            m53.Providers = new List<Provider>() { p21, p22, p26 };

            Marble m54 = new Marble() { Name = "LIME GREEN Indian limestone ", Color = "Green", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i2.wp.com/marbleguide.com/wp-content/uploads/Lime-Green.jpg?resize=300%2C180&ssl=1" }, Country = c82 };
            m54.Providers = new List<Provider>() { p3, p20, p21, p22, p26 };

            Marble m55 = new Marble() { Name = "LIME PINK Indian limestone ", Color = "Pink", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i2.wp.com/marbleguide.com/wp-content/uploads/Lime-Pink.jpg?resize=300%2C180&ssl=1" }, Country = c82 };
            m55.Providers = new List<Provider>() { p20 };

            Marble m56 = new Marble() { Name = "MORWAD WHITE Indian marble ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Morwad-White.jpg?resize=300%2C180&ssl=1" }, Country = c82 };
            m56.Providers = new List<Provider>() { p3, p21, p22, p26 };

            Marble m57 = new Marble() { Name = "RAJASTHAN GREEN Indian marble", Color = "Green", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i2.wp.com/marbleguide.com/wp-content/uploads/Rajasthan-Green.jpg?resize=300%2C180&ssl=1" }, Country = c82 };
            m57.Providers = new List<Provider>() { p22 };

            Marble m58 = new Marble() { Name = "TAJ ROSE Indian sandstone ", Color = "Pink", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i0.wp.com/marbleguide.com/wp-content/uploads/Taj-Rose.jpg?resize=300%2C180&ssl=1" }, Country = c82 };
            m58.Providers = new List<Provider>() { p20, p21, p22, p26, p30 };


            Marble m59 = new Marble() { Name = "GIALLA ", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i2.wp.com/marbleguide.com/wp-content/uploads/GIALLA.jpg?zoom=1.25&resize=860%2C469&ssl=1" }, Country = c48 };
            m59.Providers = new List<Provider>() { p5 };



            Marble m60 = new Marble() { Name = "CREMA MARFIL Spanish marble ", Color = "Beige", Photo = new Photo() { PhotoName = "Marmaro1", Url = "https://i2.wp.com/marbleguide.com/wp-content/uploads/CREMA-MARFIL.jpg?resize=880%2C480&ssl=1" }, Country = c172 };
            m60.Providers = new List<Provider>() { p23, p6 };

            context.Marbles.AddOrUpdate(x => x.Name,
               m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16, m17, m18, m19, m20,
               m21, m22, m23, m24, m25, m26, m27, m28, m29, m30, m31, m32, m33, m34, m35, m36, m37, m38, m39, m40,
               m41, m42, m43, m44, m45, m46, m47, m48, m49, m50, m51, m52, m53, m54, m55, m56, m57, m58, m59, m60

                );


            context.SaveChanges();

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

            #region Roles Hector
            //Roles
            //if (!context.Roles.Any(x => x.Name == "Admin"))
            //{
            //    var store = new RoleStore<IdentityRole>(context);
            //    var manager = new RoleManager<IdentityRole>(store);
            //    var role = new IdentityRole { Name = "Admin" };
            //    manager.Create(role);
            //}


            //var PasswordHash = new PasswordHasher();
            //if (!context.Users.Any(x => x.UserName == "admin@admin.net"))
            //{
            //    var store = new UserStore<ApplicationUser>(context);
            //    var manager = new UserManager<ApplicationUser>(store);
            //    var user = new ApplicationUser
            //    {
            //        UserName = "admin@admin.net",
            //        Email = "admin@admin.net",
            //        PasswordHash = PasswordHash.HashPassword("Admin1!")
            //    };



            //    manager.Create(user);
            //    manager.AddToRole(user.Id, "Admin");
            //}
            #endregion






        }
    }
}
