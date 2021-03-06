function ShowProvidersTable() {    
    ClearTemplateProviders();
    ClearStatistics();
    HtmlTemplate();
    GetInputProviders();
    GetInputLocation();
    MarbleInput();
    BTypesInput();
    GetTableBodyProviders();
    GetDataProviders();
    
}
function ClearTemplateProviders() {
    let template = $("#allProviders");
    let temalte1 = $("#MarbleTable");
    temalte1.empty();
    template.empty();
}

function ClearStatistics() {
    let template = $("#jsChartsStatistics")
    template.empty();
}

function ClearTemplateMarble() {
    let template = $("#allMarble");
    template.empty();
}

//=======CRUD OPERATIONS METHODS=======
//Create Provider 
function CreateProvider() {

    let confirmAction = confirm("Are you sure to execute this action?");
    if (confirmAction) {
        //Get values for Providers and location kai create the provider once!
        var url = "api/Providers";

        //Get the values for Provider
        var CompanyTitle = $('#txtCompanyTitle').val();
        var CompanyDescription = $('#txtCompanyDescription').val();
        var CompanyPhoto = $('#txtCompanyPhoto').val();
        var WebSite = $('#txtWebSite').val();
        var Phone = $('#txtCompanyPhone').val();
        var Email = $('#txtCompanyEmail').val();

        var businessTypes = findBTypesByIDAsObject('SelectBTypesTable');
        console.log(businessTypes);
        var marbles = findMarbleByIDAsObject('SelectMarbleTable');
        console.log(marbles);

        //Get the values for Location
        var Country = $("#txtLocationCountry").val();
        var City = $("#txtLocationCity").val();
        var Address = $("#txtLocationAddress").val();
        var Lat = $("#txtLocationLat").val();
        var Lng = $("#txtLocationLng").val();


        //Make the object
        let provider = {
            CompanyTitle: `${CompanyTitle}`,
            CompanyDescription: `${CompanyDescription}`,
            CompanyPhoto: `${CompanyPhoto}`,
            WebSite: `${WebSite}`,
            Phone: `${Phone}`,
            Email: `${Email}`,
            Location: {
                Country: `${Country}`,
                City: `${City}`,
                Address: `${Address}`,
                Lat: `${Lat}`,
                Lng: `${Lng}`
            },
            BusinessTypes: businessTypes,
            Marbles: marbles
        }
        //check the object
        //console.log(provider);

        if (provider) {
            $.ajax({
                type: "POST",
                url: url,
                dataType: "json",
                data: provider,
                success: function (result) {
                    alert("Provider Created")
                    clearAll();
                    GetDataProviders();
                },
                error: function (request, message, error) {
                    handleException(request, message, error);
                    alert("Error while invoking CreateProvider");
                }
            });
        }
    }
    else {
    alert("Action canceled");
}
}

function findMarbleByIDAsObject(id) {
    var listOfIds = [];

    for (var option of document.getElementById(id)) {
        if (option.selected) {
            listOfIds.push({ MarbleId: option.value });
        }
    }
    return listOfIds;

}
//Function that get the selected values from a multiple select list
function findBTypesByIDAsObject(id) {
    var listOfIds = [];
    for (var option of document.getElementById(id)) {
        if (option.selected) {
            listOfIds.push({ BusinessTypeId: option.value });
        }
    }    
    return listOfIds;
}

//Read Provider
function GetDataProviders() {
    var url = "api/Providers";
    $.ajax({
        type: "GET",
        url: url,
        dataType: "json",
        success: function (result) {

            if (result) {
                $("#tblProviderBody").html('');
                var row = '';
                for (let i = 0; i < result.length; i++) {
                    row = row
                        + "<tr>"
                        + "<td>" +
                        "<button class='btn btn-primary' onclick='GetDataProviderById(" + result[i].ProviderId + ")'data-toggle='modal' data-target='#exampleModal' >Update</button> " +
                        "<button class='btn btn-danger' onclick = 'DeleteProvider(" + result[i].ProviderId + ")'>Delete</button >"
                        + "</td > "
                        + "<td>" + result[i].CompanyTitle + "</td>"
                        + "<td>" + result[i].CompanyDescription + "</td>"
                        + "<td>" + '<img src="' + result[i].CompanyPhoto.replace('~', '') + '" style="max-height:100px; text-align:center;" alt="Alternate Text display:block;" />' + "</td>" +
                        
                        + "<td>"  + "</td>"
                        + "<td>" + result[i].WebSite + "</td>"
                        + "<td>" + result[i].Location.Country + "</td>"
                        + "<td>" + result[i].Phone + "</td>"
                        + "<td>" + result[i].Email + "</td>"
                        + "<td><ul>" + result[i].BusinessTypes.map(x => `<li>${x.Kind}</li>`).join("") + "</ul></td>"
                        + "<td><ul>" + result[i].Marbles.map(x => `<li>${x.Name}</li>`).join("") + "</ul></td>"
                        + "</tr>";
                    
                }

            }
            console.log(row);
            if (row != '') {
                $("#tblProviderBody").append(row);
            }
        },
        error: function (request, message, error) {
            handleException(request, message, error);
            alert("Error while invoking the Web API at GetDataProviders");
        },
        

    });
   
}
//Get By Id Provider
function GetDataProviderById(id) {
    
    var url = "api/Providers/";
    //Get the provider by Id
    $.ajax({
        type: "GET",
        url: url + id,
        dataType: "json",
        success: function (dataprovider) {
            // Change Update Button Text

            var ProviderId = dataprovider.ProviderId;
            var CompanyTitle = $('#txtCompanyTitle').val(dataprovider.CompanyTitle).val();
            var CompanyDescription = $('#txtCompanyDescription').val(dataprovider.CompanyDescription).val();
            var CompanyPhoto = $('#txtCompanyPhoto').val(dataprovider.CompanyPhoto).val();
            var Phone = $('#txtCompanyPhone').val(dataprovider.Phone).val();
            var WebSite = $('#txtWebSite').val(dataprovider.WebSite).val();
            var Email = $('#txtCompanyEmail').val(dataprovider.Email).val();
            var LocationId = dataprovider.Location.LocationId;
            var Country = $('#txtLocationCountry').val(dataprovider.Location.Country).val();
            var City = $('#txtLocationCity').val(dataprovider.Location.City).val();
            var Address = $('#txtLocationAddress').val(dataprovider.Location.Address).val();
            var Lat = $('#txtLocationLat').val(dataprovider.Location.Lat).val();
            var Lng = $('#txtLocationLng').val(dataprovider.Location.Lng).val();
            var businessTypes = findBTypesByID('SelectBTypesTable');
            var marbles = findMarbleByID('SelectMarbleTable');

            var businessTypesIds = []
            for (var key of dataprovider.BusinessTypes) {
                businessTypesIds.push(key.BusinessTypeId);
            }
            var marblesIds = []
            for (var key of dataprovider.Marbles) {
                marblesIds.push(key.MarbleId);
            }


            let provider = {
                ProviderId: `${ProviderId}`,
                CompanyTitle: `${CompanyTitle}`,
                CompanyDescription: `${CompanyDescription}`,
                CompanyPhoto: `${CompanyPhoto}`,
                WebSite: `${WebSite}`,
                Phone: `${Phone}`,
                Email: `${Email}`,
                Location: {
                    LocationId: `${LocationId}`,
                    Country: `${Country}`,
                    City: `${City}`,
                    Address: `${Address}`,
                    Lat: `${Lat}`,
                    Lng: `${Lng}`
                },
                BusinessTypes: businessTypes,
                Marbles: marbles
            }

            GetProviderMarbles(provider, marblesIds);
            GetProviderBTypes(provider, businessTypesIds);
            ChangeButtonToUpdate(provider, businessTypesIds, marblesIds);
            // var jsonObj = ConvertToJSONObject(provider);
            function ChangeButtonToUpdate(provider) {
                jsProvider = JSON.stringify(provider).replace(/"/g, '&quot;');

                var template = $("#updateButton");
                template.empty();
                var table = `<button class='btn btn-primary' onclick='UpdateProvider(${jsProvider})'data-dismiss="modal" >Update Provider</button>
                             <button class='btn btn-danger' onclick=clearAll()>Reset</button>`;
                template.append(table);
            }



        },
        error: function (request, message, error) {
            handleException(request, message, error);
            alert("Error while invoking UpdateProvider function / GetProvider by Id");
        },
    })
}
//Update Provider
function UpdateProvider(provider) {
    let confirmAction = confirm("Are you sure to execute this action?");
    if (confirmAction) {
        var ProviderId = provider.ProviderId;
        var CompanyTitle = $('#txtCompanyTitle').val();
        var CompanyDescription = $('#txtCompanyDescription').val();
        var CompanyPhoto = $('#txtCompanyPhoto').val();
        var Phone = $('#txtCompanyPhone').val();
        var WebSite = $('#txtWebSite').val();
        var Email = $('#txtCompanyEmail').val();
        var LocationId = provider.Location.LocationId;
        var Country = $('#txtLocationCountry').val();
        var City = $('#txtLocationCity').val();
        var Address = $('#txtLocationAddress').val();
        var Lat = $('#txtLocationLat').val();
        var Lng = $('#txtLocationLng').val();
        var businessTypes = findBTypesByID('SelectBTypesTable');
        var marbles = findMarbleByID('SelectMarbleTable');




        provider = {
            ProviderId: `${ProviderId}`,
            CompanyTitle: `${CompanyTitle}`,
            CompanyDescription: `${CompanyDescription}`,
            CompanyPhoto: `${CompanyPhoto}`,
            WebSite: `${WebSite}`,
            Phone: `${Phone}`,
            Email: `${Email}`,
            Location: {
                LocationId: `${LocationId}`,
                Country: `${Country}`,
                City: `${City}`,
                Address: `${Address}`,
                Lat: `${Lat}`,
                Lng: `${Lng}`
            },
            HelperMarbles: marbles,
            HelperBusinessTypes: businessTypes,

        }

        var jsProvider = JSON.stringify(provider);


        var url = "api/Providers/";
        $.ajax({
            type: "Put",
            url: url + provider.ProviderId,
            contentType: "application/json; charset=utf-8",
            dataType: 'json',
            data: jsProvider,
            success: function (result) {                
                clearAll();
                alert("Provider Updated");

                GetDataProviders();
            },
            error: function (request, message, error) {
                handleException(request, message, error);
                alert("Error while invoking the Web API at PutProvider");

            }
        });
    } else {
        alert("Action canceled");
    }
}
//Delete Provider
function DeleteProvider(id) {

    let confirmAction = confirm("Are you sure to execute this action?");
    if (confirmAction) {
        var url = "api/Providers/" + id;
        $.ajax({
            type: "Delete",
            url: url,
            contentType: "application/json; charset=utf-8",
            dataType: "json",

            success: function (result) {
                clearAll();
                alert("Deleted!");
                GetDataProviders();
            },
            error: function (request, message, error) {
                handleException(request, message, error);
                alert("Error while invoking the Web API at DeleteProvider");
            }
        });
    }
    else {
        alert("Action canceled");
    }
}

function GetProviderMarbles(provider, marblesIds) {
    //Get the unselected and the selected BusinessTypes
    $.ajax({
        type: "GET",
        url: "api/Marbles",
        data: "name=John&location=Boston",
        dataType: "json",
        success: function (dataMarbles) {

            clearSelectList();
            SetDataMarbles(dataMarbles);

            function SetDataMarbles(dataMarbles) {
                var template = $("#SelectMarbleTable");
                var table = '';
                for (var key of dataMarbles) {
                    if (marblesIds.includes(key.MarbleId)) {
                        table += `<option selected value="${key.MarbleId}"> ${key.Name} </option>`;
                    }
                    else {
                        table += `<option value="${key.MarbleId}"> ${key.Name} </option>`;
                    }
                }
                template.append(table);
            }
            function clearSelectList() {
                var template = $("#SelectMarbleTable");
                template.empty();
                var table = '';
                template.append(table);
            }

            ids = $('#SelectMarbleTable').val();

            var marbles = []
            for (var i of ids) {
                marbles.push({ MarbleId: i })
            }

            provider.Marbles = marbles;

        },
        error: function (request, message, error) {
            handleException(request, message, error);
            alert("Error while invoking UpdateProvider function / GetProviderMarbles by Id");
        },
    });
}

function GetProviderBTypes(provider, businessTypesIds) {
    //Get the unselected and the selected BusinessTypes
    $.ajax({
        type: "GET",
        url: "api/BusinessTypes",
        data: "name=John&location=Boston",
        dataType: "json",
        success: function (dataBTypes) {

            clearSelectList();
            SetDataBTypes(dataBTypes);

            function SetDataBTypes(dataBTypes) {
                var template = $("#SelectBTypesTable");
                var table = '';
                for (var key of dataBTypes) {
                    if (businessTypesIds.includes(key.BusinessTypeId)) {
                        table += `<option selected value="${key.BusinessTypeId}"> ${key.Kind} </option>`;
                    }
                    else {
                        table += `<option value="${key.BusinessTypeId}"> ${key.Kind} </option>`;
                    }
                }
                template.append(table);
            }

            ids = $('#SelectBTypesTable').val();

            var bTypes = []
            for (var i of ids) {
                bTypes.push({ BusinessTypeId: i })
            }
            provider.BusinessTypes = bTypes;

            function clearSelectList() {
                var template = $("#SelectBTypesTable");
                template.empty();
                var table = '';
                template.append(table);
            }
        },
        error: function (request, message, error) {
            handleException(request, message, error);
            alert("Error while invoking UpdateProvider function / GetProviderBTypes by Id");
        },
    });
}

//=======General Data Manipulation Data Methods
//Function that get the selected values from a multiple select list
function findMarbleByID(id) {
    var listOfIds = [];

    for (var option of document.getElementById(id)) {
        if (option.selected) {
            listOfIds.push(option.value);
        }
    }
    return listOfIds;

}
//function findMarbleByID(id) {
//    var listOfIds = [];
//    var listOfMarbles = new Array();

//    for (var option of document.getElementById(id)) {
//        if (option.selected) {
//            //listOfIds.push({ MarbleId: option.value });
//            //listOfIds.push(parseInt(option.value));
//            var _id = parseInt(option.value)
//            $.ajax({
//                type: "get",
//                url: "api/marbles/" + _id,
//                dataType: "json",
//                success: function (data) {                   
//                    listOfMarbles.push(JSON.stringify(
//                        {
//                            MarbleId: data.MarbleId,
//                            Name: data.Name,
//                            Color: data.Color,
//                            MarbleDescription: data.MarbleDescription,
//                            Country: data.Country,
//                            Photo: data.Photo,
//                            Providers: data.Providers
//                        })
//                    );
                  
                  
//                },
//                error: function (request, message, error) {
//                    handleException(request, message, error);
//                    alert("Error while invoking the Web API at findMarbleByID");
//                }
//            });
          
//        }
//    }
//    console.log(listOfMarbles);
//    //return listOfIds;
//    return listOfMarbles;

//}
//Function that get the selected values from a multiple select list
function findBTypesByID(id) {
    var listOfIds = [];
    for (var option of document.getElementById(id)) {
        if (option.selected) {
            listOfIds.push(option.value);
        }
    }
    //console.log(listOfIds);    

    //return GetObjects(listOfIds,url);
    return listOfIds;
}
//Handle Exception Method
function handleException(request, message, error) {
    var msg = "";

    msg += "Code: " + request.status + " " + message + "\n";
    msg += "Text: " + request.statusText + " " + message + "\n";
    if (request.responseJSON != null) {
        msg += "Message: " +
            request.responseJSON.Message + "\n";
    }

    console.log(msg);
    console.log(message);
    console.log(error);
}
//SOMA GIA HTML STO TEMPLATE
function HtmlTemplate() {

    let table = $("#allProviders");
    let template = `<div >

            <button type="button" onclick="InitializeProviderForm()"; class="btn btn-primary" data-toggle="modal" data-target="#exampleModal">
                Create Provider
            </button>

            <!-- Modal -->
            <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title" id="exampleModalLabel"></h5>
                            
                        </div>
                        <div id="theInputTable" class="modal-body">



                            
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                    </div>
                </div>
            </div>
                    </div>
                    <div id="theDataTable">
 
                    </div>
                   `;
    table.append(template);
}


function InitializeProviderForm() {
    clearAll();
    let template = $("#updateButton");
    template.empty();
    let html = `
                <button class="btn btn-primary" onclick="CreateProvider()"data-dismiss="modal">Save Provider</button>
                <button class="btn btn-danger" onclick="clearAll()">Reset</button>
                `;
    template.append(html);
   

}

//=======Methods InputForms=======
//Business Types Input form
function BTypesInput() {

    $.ajax({
        type: "GET",
        url: "api/BusinessTypes",
        data: "name=John&location=Boston",
        dataType: "json",
        success: function (response) {
            data = response;
            appendToTable();
            function appendToTable() {
                var table = $("#BTypesTable");
                var template = `
                    <hr />
                    <h4>Select Business Types</h4>
                        
                    <div id="base" class="col-md - 2">
                        <label for="bTypes"></label>
                    </div >
                        <div  class="col-mid-10">
                        <select name="bTypes" id="SelectBTypesTable" class="form-control" size="6" multiple ">
                            
                        </select>
                    </div>`;
                table.append(template);
            }

            SetDataBTypes(data);

            function SetDataBTypes(data) {
                var template = $("#SelectBTypesTable");
                var table = '';
                for (var key of data) {
                    table += `<option value="${key.BusinessTypeId}"> ${key.Kind} </option>`;
                }
                template.append(table);
            }


        },
        error: function (request, message, error) {
            handleException(request, message, error);
            alert("Error while invoking the Web API at BusinessTypeInput");

        }
    });

}
//Marbles Input form
function MarbleInput() {

    $.ajax({
        type: "GET",
        url: "api/marbles",
        data: "name=John&location=Boston",
        dataType: "json",
        success: function (response) {
            data = response;
            appendToTable();
            function appendToTable() {

                var table = $("#MarbleTable");
                var template = `
                    <hr />
                    <h4>Select Marbles</h4>
                        
                    <div id="base" class="col-md - 2">
                        <label for="marbles"></label>
                    </div >
                        <div  class="col-mid-10">
                        <select name="marbles" id="SelectMarbleTable" class="form-control"size="10" multiple ">
                            
                        </select>
                    </div>`;
                table.append(template);
            }

            SetDataMarble(data);

            function SetDataMarble(data) {
                var template = $("#SelectMarbleTable");
                var table = '';
                for (var key of data) {
                    table += `<option value="${key.MarbleId}"> ${key.Name} </option>`;
                }
                template.append(table);
            }


        },
        error: function (request, message, error) {
            handleException(request, message, error);
            alert("Error while invoking the Web API at MarbleInput");
        }
    });
}
//Location Types Input form
function GetInputLocation() {
    var table = $("#LocationTable");
    var template = `
                    <hr />
                    <h4>Create Location</h4>
                        
                    <div class="col-md - 2">
                        Country
                    </div >
                        <div class="col-mid-10">
                        <input type="text" id="txtLocationCountry" class="form-control" placeholder="Enter Company Country" />
                    </div>
                    <div class="col-md - 2">
                        City
                    </div >
                        <div class="col-mid-10">
                        <input type="text" id="txtLocationCity" class="form-control" placeholder="Enter Company Location" />
                    </div>
                    <div class="col-md - 2">
                        Address
                    </div >
                        <div class="col-mid-10">
                        <input type="text" id="txtLocationAddress" class="form-control" placeholder="Enter Company Address" />
                    </div>
                    <div class="col-md - 2">
                        Lat
                    </div >
                        <div class="col-mid-10">
                        <input type="text" id="txtLocationLat" class="form-control" placeholder="Enter Company Lat" />
                    </div>
                    <div class="col-md - 2">
                        Lng
                    </div >
                        <div class="col-mid-10">
                        <input type="text" id="txtLocationLng" class="form-control" placeholder="Enter Company Lng" />
                    </div>
                    `
        ;
    table.append(template);
}
//Provider Input form
function GetInputProviders() {

    var table = $("#theInputTable");
    var template = `  <hr />
        
          <div>
            <h4>Create Provider</h4>            
                <div class="col-md-2">
                    CompanyTitle
                </div>
                <div class="col-mid-10">
                    <input type="text" id="txtCompanyTitle" class="form-control" placeholder="Enter Company Title" />
                </div>
                <div class="col-md-2">
                    Company Description
                </div>
                <div class="col-mid-10">
                    <input type="text" id="txtCompanyDescription" class="form-control" placeholder="Enter Company Description" />
                </div>
                <div class="col-md-2">
                    Company Photo
                </div>
                <div class="col-mid-10">
                    <input type="text" id="txtCompanyPhoto" class="form-control" placeholder="Enter Company Photo" />
                </div>
                <div class="col-md-2">
                    Phone
                </div>
                <div class="col-mid-10">
                    <input type="text" id="txtCompanyPhone" class="form-control" placeholder="Enter Company Phone" />
                </div>
                <div class="col-md-2">
                    WebSite
                </div>
                <div class="col-mid-10">
                    <input type="text" id="txtWebSite" class="form-control" placeholder="Enter Company WebSite" />
                </div>           
                <div class="col-md-2">
                    Email
                </div>
                <div class="col-mid-10">
                    <input type="email" id="txtCompanyEmail" class="form-control" placeholder="Enter Company Email" />
                </div>
           
        </div>
        <div id="LocationTable">
            
        </div>    
        <div id="MarbleTable">
            
        </div>    
        <div id="BTypesTable">
            
        </div>       
            
        <div class="col-mid-12" id="updateButton">
           
        </div>
        
        <br/>`
    table.append(template);
}
//Table Headers for Providers
function GetTableBodyProviders() {
    var table = $("#theDataTable");
    var template = ` <div class="row">
                        <table class="table table-bordered table-striped table-responsive">
                            <thead>
                                <tr>
                                    <th>Actions</th>
                                    <th>CompanyTitle</th>
                                    <th>CompanyDescription</th>
                                    <th>CompanyPhoto</th>
                                    <th>WebSite</th>
                                    <th>Location</th>
                                    <th>Phone</th>
                                    <th>Email</th>
                                    <th>Business Type</th>
                                    <th>Marbles</th>
                                </tr>
                            </thead>
                            <tbody id="tblProviderBody">
                            </tbody>
                        </table>
                    </div>`;
    table.append(template);

}
//Clear Input from user
function clearAll() {
    //$("#updateButton").text("Save Provider");
    $('#txtCompanyTitle').val('')
    $('#txtCompanyDescription').val('');
    $('#txtCompanyPhoto').val('');
    $('#txtCompanyPhone').val('');
    $('#txtWebSite').val('');
    $('#txtCompanyEmail').val('');
    $('#txtLocationCountry').val('');
    $('#txtLocationCity').val('');
    $('#txtLocationAddress').val('');
    $('#txtLocationLat').val('');
    $('#txtLocationLng').val('');
    $('#SelectMarbleTable').val('');
    $('#SelectBTypesTable').val('');
}







//========ATTENTION DO NOT TOUCH!!!========
//!==== INACTIVE METHODS =====
function SetDataLocation(provider) {
    var Country = $("#txtLocationCountry").val();
    var City = $("#txtLocationCity").val();
    var Address = $("#txtLocationAddress").val();
    var Lat = $("#txtLocationLat").val();
    var Lng = $("#txtLocationLng").val();

    //initialiaze the new object
    let location = {
        Country: `${Country}`,
        City: `${City}`,
        Address: `${Address}`,
        Lat: `${Lat}`,
        Lng: `${Lng}`,
        Provider: provider
    };

    var url = "api/Locations";
    //$.ajax({
    //    type: "POST",
    //    url: url,
    //    data: location,
    //    dataType: "json",
    //    success: function (response) {            
    //    },
    //    error: function (request, message, error) {
    //        handleException(request, message, error);
    //        alert("Error while invoking the create LOcation");
    //    }
    //});

}
function GetObjects(listOfIds, url) {
    var listIfObjects = []
    //=====Find the marbles - push to the list  
    for (var id of listOfIds) {
        $.ajax({
            type: "GET",
            url: url + id,

            dataType: "json",
            success: function (response) {
                listIfObjects.push(response)
            },
            error: function (request, message, error) {
                handleException(request, message, error);
                alert("Error while invoking GetObjects function");

            }

        });
    }

    return listIfObjects;
}
function GetProviderLocation(provider, id) {
    console.log('Eimai sthn GetProviderLocation');
    //Get the location by Id
    $.ajax({
        type: "get",
        url: "/api/locations/" + id,
        dataType: "json",
        success: function (datalocation) {
            var Country = $('#txtLocationCountry').val(datalocation.Country).val();
            var City = $('#txtLocationCity').val(datalocation.City).val();
            var Address = $('#txtLocationAddress').val(datalocation.Address).val();
            var Lat = $('#txtLocationLat').val(datalocation.Lat).val();
            var Lng = $('#txtLocationLng').val(datalocation.Lng).val();

            provider.Location = {
                Country: `${Country}`,
                City: `${City}`,
                Address: `${Address}`,
                Lat: `${Lat}`,
                Lng: `${Lng}`
            }
        },
    })
}