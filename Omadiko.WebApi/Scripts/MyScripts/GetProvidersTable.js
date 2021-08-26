$(document).ready(function () {
    $('#ProvidersTable').click(function () {
        GetInputProviders();
        GetInputLocation();
        MarbleInput();
        BTypesInput();
        GetTableBodyProviders();
        GetDataProviders();

    });
})


//Function that get the selected values from a multiple select list
function findMarbleByID(id) {
    var listOfIds = [];
    for (var option of document.getElementById(id)) {
        if (option.selected) {
            listOfIds.push({ MarbleId : option.value });
        }
    }
    //console.log(listOfIds);    

    //return GetObjects(listOfIds,url);
    return listOfIds;
}
//Function that get the selected values from a multiple select list
function findBTypesByID(id) {
    var listOfIds = [];
    for (var option of document.getElementById(id)) {
        if (option.selected) {
            listOfIds.push({ BusinessTypeId : option.value });
        }
    }
    //console.log(listOfIds);    

    //return GetObjects(listOfIds,url);
    return listOfIds;
}

function GetObjects(listOfIds,url) {
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

function CreateProvider() {
    var url = "api/Providers";
    var urlMarbles = "api/Marbles/";
    var urlBTypes = "api/BusinessTypes/";

    //Get the values
    var CompanyTitle = $('#txtCompanyTitle').val();
    var CompanyDescription = $('#txtCompanyDescription').val();
    var CompanyPhoto = $('#txtCompanyPhoto').val();
    var WebSite = $('#txtWebSite').val();
    var Phone = $('#txtCompanyPhone').val();
    var Email = $('#txtCompanyEmail').val();

    var businessTypes = findBTypesByID('SelectBTypesTable');
    var marbles = findMarbleByID('SelectMarbleTable');
    console.log(businessTypes);
    console.log(marbles);
    
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
            Lng: `${Lng}`,
            //Provider: provider
        },
        BusinessTypes: businessTypes,
        Marbles: marbles
    }
    //initialiaze the new object
    //let location = {
    //    Country: `${Country}`,
    //    City: `${City}`,
    //    Address: `${Address}`,
    //    Lat: `${Lat}`,
    //    Lng: `${Lng}`,
    //    Provider: provider
    //};
    console.log(provider);
    
    if (provider) {
        $.ajax({
            type: "POST",
            url: url,
            dataType: "json",
            data: provider,
            success: function (result) {
                console.log(result);
                alert("SUCCESS");
                clear();
                GetDataProviders();
            },
            error: function (request, message, error) {
                handleException(request, message, error);                
                alert("Error while invoking CreateProvider");
                console.log(provider);
            }
        });
    }
    //Set the values for location
    //SetDataLocation(provider);

}

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
                        <label for="bTypes">Business Types</label>
                    </div >
                        <div  class="col-mid-10">
                        <select name="bTypes" id="SelectBTypesTable" class="BTypes-js" size="6" multiple ">
                            
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
                        <label for="marbles">Marbles</label>
                    </div >
                        <div  class="col-mid-10">
                        <select name="marbles" id="SelectMarbleTable" class="marble-js"size="10" multiple ">
                            
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
                        + "<td>" + result[i].CompanyTitle + "</td>"
                        + "<td>" + result[i].CompanyDescription + "</td>"
                        + "<td>" + result[i].CompanyPhoto + "</td>"
                        + "<td>" + result[i].WebSite + "</td>"
                        + "<td>" + result[i].Location.Country + "</td>"
                        + "<td>" + result[i].Phone + "</td>"
                        + "<td>" + result[i].Email + "</td>"
                        + "<td><ul>" + result[i].BusinessTypes.map(x => `<li>${x.Kind}</li>`).join("") +  "</ul></td>"
                        + "<td><ul>" + result[i].Marbles.map(x => `<li>${x.Name}</li>`).join("") + "</ul></td>"                        
                        + "<td> <button class='btn btn-primary' onclick='DeleteProvider(" + result[i].ProviderId + ")'>Delete</button></td>"
                        + "</tr>";
                }
            }
            if (row != '') {
                $("#tblProviderBody").append(row);
            }
        },
        error: function (request, message, error) {
            handleException(request, message, error);
            alert("Error while invoking the Web API at GetDataProviders");
        }
    });
}

function GetInputLocation() {
    var table = $("#LocationTable");
    var template = `
                    <hr />
                    <h4>Create Location</h4>
                        
                    <div class="col-md - 2">
                        Country
                    </div >
                        <div class="col-mid-10">
                        <input type="text" id="txtLocationCountry" class="form-control" placeholder="Enter Company Location" />
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
                        <input type="text" id="txtLocationAddress" class="form-control" placeholder="Enter Company Location" />
                    </div>
                    <div class="col-md - 2">
                        Lat
                    </div >
                        <div class="col-mid-10">
                        <input type="text" id="txtLocationLat" class="form-control" placeholder="Enter Company Location" />
                    </div>
                    <div class="col-md - 2">
                        Lng
                    </div >
                        <div class="col-mid-10">
                        <input type="text" id="txtLocationLng" class="form-control" placeholder="Enter Company Location" />
                    </div>
                    `
        ;
    table.append(template);
}

function GetInputProviders() {

    var table = $("#theInputTable");
    var template = `  <hr />
        <h4>Create Provider</h4>
                        
        <div class="row">
            <div class="col-md-2">
                CompanyTitle
            </div>
            <div class="col-mid-10">
                <input type="text" id="txtCompanyTitle" class="form-control" placeholder="Enter Company Title" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-2">
                Company Description
            </div>
            <div class="col-mid-10">
                <input type="text" id="txtCompanyDescription" class="form-control" placeholder="Enter Company Description" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-2">
                Company Photo
            </div>
            <div class="col-mid-10">
                <input type="text" id="txtCompanyPhoto" class="form-control" placeholder="Enter Company Photo" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-2">
                Phone
            </div>
            <div class="col-mid-10">
                <input type="text" id="txtCompanyPhone" class="form-control" placeholder="Enter Company Phone" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-2">
                WebSite
            </div>
            <div class="col-mid-10">
                <input type="text" id="txtWebSite" class="form-control" placeholder="Enter Company WebSite" />
            </div>
        </div>
        <div class="row">
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
            
        <br/>
        <div class="col-mid-12">
            <button class="btn btn-primary" onclick="CreateProvider()">Save Provider</button>
            <button class="btn btn-danger">Reset</button>
        </div>
        <br/>
        <br/>`
    table.append(template);
}

function GetTableBodyProviders() {
    var table = $("#theDataTable");
    var template = ` <div class="row">
                        <table class="table table-bordered table-striped table-responsive">
                            <thead>
                                <tr>
                                    <th>CompanyTitle</th>
                                    <th>CompanyDescription</th>
                                    <th>CompanyPhoto</th>
                                    <th>WebSite</th>
                                    <th>Location</th>
                                    <th>Phone</th>
                                    <th>Email</th>
                                    <th>Marbles</th>
                                    <th>Business Type</th>
                                    <th>Delete</th>
                                </tr>
                            </thead>
                            <tbody id="tblProviderBody">
                            </tbody>
                        </table>
                    </div>`;
    table.append(template);

}

function DeleteProvider(id) {
    var url = "api/Providers/" + id;
    $.ajax({
        type: "Delete",
        url: url,
        contentType: "application/json; charset=utf-8",
        dataType: "json",

        success: function (result) {
            clear();
            alert("Are you sure?");
            GetDataProviders();
        },
        error: function (request, message, error) {
            handleException(request, message, error);
            alert("Error while invoking the Web API at DeleteProvider");
        }
    });
}

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

function clear() {
    $('#txtCompanyTitle').val('')
    $('#txtCompanyPhone').val('');
    $('#txtCompanyEmail').val('');
}
