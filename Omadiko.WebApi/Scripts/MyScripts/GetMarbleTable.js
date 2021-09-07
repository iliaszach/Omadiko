function ShowMarbleTable() {
    ClearStatistics()
    HtmlTemplate();
    GetInputMarble();
    ProviderInput();
    GetTableBodyMarble();
    GetDataMarble();
}

function ClearStatistics() {
    let template = $("#jsChartsStatistics")
    template.empty();
}

function ClearTemplateProvider() {
    let template = $("#allProvider");
    template.empty();
}


function CreateMarble() {

    let confirmAction = confirm("Are you sure to execute this action?");
    if (confirmAction) {
        //Get values for Providers and location kai create the provider once!
        var url = "api/Marbles";

        var Name = $('#txtName').val(datamarble.Name).val();
        var MarbleDescription = $('#txtMarbleDescription').val(datamarble.MarbleDescription).val();
        var Photo = $('#txtPhoto').val(datamarble.Photo).val();
        var Color = $('#txtColor').val(datamarble.Color).val();
        var Country = $('#txtCountry').val(datamarble.Country).val();
        var providers = findProviderByIDAsObject('SelectProvidersTable');
        console.log(providers);

        //Make the object
        let marble = {
            Name: `${Name}`,
            MarbleDescription: `${MarbleDescription}`,
            Photo: `${Photo}`,
            Color: `${Color}`,
            Country: `${Country}`,
            Providers: providers
        }
        //check the object
        //console.log(provider);

        if (marble) {
            $.ajax({
                type: "POST",
                url: url,
                dataType: "json",
                data: marble,
                success: function (result) {
                    alert("Marble Created")
                    clearAll();
                    GetDataMarble();
                },
                error: function (request, message, error) {
                    handleException(request, message, error);
                    alert("Error while invoking CreateMarble");
                }
            });
        }
    }
    else {
        alert("Action canceled");
    }
}

function findProviderByIDAsObject(id) {
    var listOfIds = [];

    for (var option of document.getElementById(id)) {
        if (option.selected) {
            listOfIds.push({ ProviderId: option.value });
        }
    }
    return listOfIds;

}


function GetDataMarble() {
    var url = "api/Marbles";
    $.ajax({
        type: "GET",
        url: url,
        dataType: "json",
        success: function (result) {
            if (result) {
                $("#tblMarbleBody").html('');
                var row = '';
                for (let i = 0; i < result.length; i++) {
                    row = row
                        + "<tr>"
                        + "<td>" +
                        "<button class='btn btn-primary' onclick='GetDataMarbleById(" + result[i].MarbleId + ")'data-toggle='modal' data-target='#exampleModal' >Update</button> " +
                        "<button class='btn btn-danger' onclick = 'DeleteMarble(" + result[i].MarbleId + ")'>Delete</button >"
                        + "</td > "
                        + "<td>" + result[i].Name + "</td>"
                        + "<td>" + result[i].MarbleDescription + "</td>"
                        + "<td>" + "<img src=" + result[i].Photo.Url + "alt='Alternate Text' />" + "</td>" +
                        + "<td>" + "</td>"
                        + "<td>" + result[i].Color + "</td>"
                        + "<td>" + result[i].Country.Name + "</td>"
                        + "<td><ul>" + result[i].Providers.map(x => `<li>${x.CompanyTitle}</li>`).join("") + "</ul></td>"
                        + "</tr>";
                }
            }
            if (row != '') {
                $("#tblMarbleBody").append(row);
            }
        },
        error: function (request, message, error) {
            handleException(request, message, error);
            alert("Error while invoking the Web API at GetDataMarble");
        },


    });

}

function GetDataMarbleById(id) {

    var url = "api/Marbles/";
    //Get the marble by Id
    $.ajax({
        type: "GET",
        url: url + id,
        dataType: "json",
        success: function (datamarble) {
            // Change Update Button Text

            var MarbleId = datamarble.MarbleId;
            var Name = $('#txtName').val(datamarble.Name).val();
            var MarbleDescription = $('#txtMarbleDescription').val(datamarble.MarbleDescription).val();
            var Photo = $('#txtPhoto').val(datamarble.Photo).val();
            var Color = $('#txtColor').val(datamarble.Color).val();
            var Country = $('#txtCountry').val(datamarble.Country).val();
            var Providers = findProvidersByID('SelectProvidersTable');

            var providersIds = []
            for (var key of datamarble.Providers) {
                providersIds.push(key.ProviderId);
            }


            let marble = {
                MarbleId: `${ProviderId}`,
                Name: `${CompanyTitle}`,
                MarbleDescription: `${CompanyDescription}`,
                Photo: `${CompanyPhoto}`,
                Color: `${WebSite}`,
                Country: `${Phone}`,
                Providers: providers
            }


            GetMarbleProviders(marble, providersIds);
            ChangeButtonToUpdate(marble, providersIds);
            // var jsonObj = ConvertToJSONObject(provider);

            function ChangeButtonToUpdate(marble) {
                jsMarble = JSON.stringify(marble).replace(/"/g, '&quot;');

                var template = $("#updateButton");
                template.empty();
                var table = `<button class='btn btn-primary' onclick='UpdateMarble(${jsMarble})'data-dismiss="modal" >Update Marble</button>
                             <button class='btn btn-danger' onclick=clearAll()>Reset</button>`;
                template.append(table);
            }
        },
        error: function (request, message, error) {
            handleException(request, message, error);
            alert("Error while invoking UpdateMarblefunction / GetMarble by Id");
        },
    })
}

function UpdateMarble(marble) {
    let confirmAction = confirm("Are you sure to execute this action?");
    if (confirmAction) {
        var MarbleId = datamarble.MarbleId;
        var Name = $('#txtName').val(datamarble.Name).val();
        var MarbleDescription = $('#txtMarbleDescription').val(datamarble.MarbleDescription).val();
        var Photo = $('#txtPhoto').val(datamarble.Photo).val();
        var Color = $('#txtColor').val(datamarble.Color).val();
        var Country = $('#txtCountry').val(datamarble.Country).val();
        var Providers = findProvidersByID('SelectProvidersTable');


        provider = {
            MarbleId: `${ProviderId}`,
            Name: `${CompanyTitle}`,
            MarbleDescription: `${CompanyDescription}`,
            Photo: `${CompanyPhoto}`,
            Color: `${WebSite}`,
            Country: `${Phone}`,
            HelperProviders: providers
        }

        var jsMarble = JSON.stringify(marble);


        var url = "api/Marbles/";
        $.ajax({
            type: "Put",
            url: url + marble.MarbleId,
            contentType: "application/json; charset=utf-8",
            dataType: 'json',
            data: jsMarble,
            success: function (result) {
                clearAll();
                alert("Marble Updated");

                GetDataMarble();
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

function DeleteMarble(id) {

    let confirmAction = confirm("Are you sure to execute this action?");
    if (confirmAction) {
        var url = "api/Marbles/" + id;
        $.ajax({
            type: "Delete",
            url: url,
            contentType: "application/json; charset=utf-8",
            dataType: "json",

            success: function (result) {
                clearAll();
                alert("Deleted!");
                GetDataMarble();
            },
            error: function (request, message, error) {
                handleException(request, message, error);
                alert("Error while invoking the Web API at DeleteMarble");
            }
        });
    }
    else {
        alert("Action canceled");
    }
}

function GetMarbleProviders(marble, providersIds) {
    $.ajax({
        type: "GET",
        url: "api/Providers",
        data: "name=John&location=Boston",
        dataType: "json",
        success: function (dataProviders) {

            clearSelectList();
            SetDataProviders(dataProviders);

            function SetDataProviders(dataProviders) {
                var template = $("#SelectProviderTable");
                var table = '';
                for (var key of dataProviders) {
                    if (providersIds.includes(key.ProviderId)) {
                        table += `<option selected value="${key.ProviderId}"> ${key.CompanyTitle} </option>`;
                    }
                    else {
                        table += `<option value="${key.ProviderId}"> ${key.CompanyTitle} </option>`;
                    }
                }
                template.append(table);
            }
            function clearSelectList() {
                var template = $("#SelectProviderTable");
                template.empty();
                var table = '';
                template.append(table);
            }

            ids = $('#SelectProviderTable').val();

            var providers = []
            for (var i of ids) {
                providers.push({ ProviderId: i })
            }

            marble.Providers = providers;

        },
        error: function (request, message, error) {
            handleException(request, message, error);
            alert("Error while invoking UpdateMarble function / GetMarbleProvidersby Id");
        },
    });
}



function findProviderByID(id) {
    var listOfIds = [];

    for (var option of document.getElementById(id)) {
        if (option.selected) {
            listOfIds.push(option.value);
        }
    }
    return listOfIds;
}

function findCountryrByIDA(id) {
    var numberOfId;

    for (var option of document.getElementById(id)) {
        if (option.selected) {
            numberOfId = ({ CountryId: option.value });
        }
    }
    return numberOfId;

}

function findPhotorByIDA(id) {
    var findPhotoId;

    for (var option of document.getElementById(id)) {
        if (option.selected) {
            findPhotoId = ({ PhotoId: option.value });
        }
    }
    return findPhotoId;
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

function HtmlTemplate() {

    let table = $("#allMarble");
    let template = `<div >

            <button type="button" onclick="InitializeMarbleForm()"; class="btn btn-primary" data-toggle="modal" data-target="#exampleModal">
                Create Marble
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

function InitializeMarbleForm() {
    clearAll();
    let template = $("#updateButton");
    template.empty();
    let html = `
                <button class="btn btn-primary" onclick="CreateMarble()"data-dismiss="modal">Save Marble</button>
                <button class="btn btn-danger" onclick="clearAll()">Reset</button>
                `;
    template.append(html);


}


function ProviderInput() {

    $.ajax({
        type: "GET",
        url: "api/providers",
        dataType: "json",
        success: function (response) {
            data = response;
            appendToTable();
            function appendToTable() {

                var table = $("#ProviderTable");
                var template = `
                    <hr />
                    <h4>Select Providers</h4>
                        
                    <div id="base" class="col-md - 2">
                        <label for="providers"></label>
                    </div >
                        <div  class="col-mid-10">
                        <select name="providers" id="SelectProviderTable" class="form-control"size="10" multiple ">
                            
                        </select>
                    </div>`;
                table.append(template);
            }

            SetDataProvider(data);

            function SetDataProvider(data) {
                var template = $("#SelectProviderTable");
                var table = '';
                for (var key of data) {
                    table += `<option value="${key.ProviderId}"> ${key.CompanyTitle} </option>`;
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

function GetInputMarble() {

    var table = $("#theInputTable");
    var template = `  <hr />
        
          <div>
            <h4>Create Marble</h4>            
                <div class="col-md-2">
                    Name
                </div>
                <div class="col-mid-10">
                    <input type="text" id="txtName" class="form-control" placeholder="Enter Name" />
                </div>
                <div class="col-md-2">
                    Marble Description
                </div>
                <div class="col-mid-10">
                    <input type="text" id="txtMarbleDescription" class="form-control" placeholder="Enter Marble Description" />
                </div>
                <div class="col-md-2">
                    Marble Photo
                </div>
                <div class="col-mid-10">
                    <input type="text" id="txtPhoto" class="form-control" placeholder="Enter Marble Photo" />
                </div>
                <div class="col-md-2">
                    Origin
                </div>
                <div class="col-mid-10">
                    <input type="text" id="txtCountry" class="form-control" placeholder="Enter Origin" />
                </div>
     
        </div>   
        <div id="ProviderTable">   
        </div>    
        <div class="col-mid-12" id="updateButton">  
        </div>
        
        <br/>`
    table.append(template);
}

function GetTableBodyMarble() {
    var table = $("#theDataTable");
    var template = ` <div class="row">
                        <table class="table table-bordered table-striped table-responsive">
                            <thead>
                                <tr>
                                    <th>Actions</th>
                                    <th>Name</th>
                                    <th>MarbleDescription</th>
                                    <th>Photo</th>
                                    <th>Color</th>
                                    <th>Country</th>
                                    <th>Providers</th>
                                </tr>
                            </thead>
                            <tbody id="tblMarbleBody">
                            </tbody>
                        </table>
                    </div>`;
    table.append(template);

}

function clearAll() {
    //$("#updateButton").text("Save Provider");
    $('#txtName').val('')
    $('#txtMarbleDescription').val('');
    $('#txtPhoto').val('');
    $('#txtColor').val('');
    $('#txtCountry').val('');
    $('#SelectProviderTable').val('');
}
















