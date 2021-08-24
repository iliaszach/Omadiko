$(document).ready(function () {
    $('#ProvidersTable').click(function () {
        GetInputProviders();
        GetDataProviders();
        getProvidersData();
    });


})

function SaveProvider() {
    var url = "api/Providers";

    var objectProvider = {}
    objectProvider.CompanyTitle = $('#txtCompanyTitle').val();

    objectProvider.CompanyDescription = $('#txtCompanyDescription').val();

    objectProvider.CompanyPhoto = $('#txtCompanyPhoto').val();

    objectProvider.WebSite = $('#txtWebSite').val();

    objectProvider.Location = $('#txtCompanyLocation').val();

    objectProvider.Phone = $('#txtCompanyPhone').val();

    objectProvider.Email = $('#txtCompanyEmail').val();
    console.log(objectProvider);

    if (objectProvider) {
        $.ajax({
            type: "POST",
            url: url,
            dataType: "json",
            data: JSON.stringify(objectProvider


                //    CompanyTitle = CompanyTitle,
                //    CompanyDescription = CompanyDescription,
                //    CompanyPhoto = CompanyPhoto,
                //    Phone = Phone,
                //    WebSite = WebSite,
                //    Email = Email,
                //    Location = Location
            ),
            success: function (result) {
                clear();
                getProvidersData()
            },
            error: function (msg) {
                alert(msg);
            }
        });
    }


}
function clear() {
    $('#txtCompanyTitle').val('')
    $('#txtCompanyPhone').val('');
    $('#txtCompanyEmail').val('');
}

function getProvidersData() {
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
                        + "<td> <button class='btn btn-primary' onclick='DeleteProvider(" + result[i].ProviderId + ")'>Delete</button></td>"
                        + "</tr>";
                }
            }
            if (row != '') {
                $("#tblProviderBody").append(row);
            }
        }
    });
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
            getProvidersData();
        },
        error: function (request, message, error) {
            handleException(request, message, error);

        }
    });
}

function handleException(request, message, error) {
    var msg = "";

    msg += "Code: " + request.status + "\n";
    msg += "Text: " + request.statusText + "\n";
    if (request.responseJSON != null) {
        msg += "Message: " +
            request.responseJSON.Message + "\n";
    }

    alert(msg);
}

function GetInputProviders() {

    var table = $("#theInputTable");
    var template = `<div class="row">
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
        <div class="row">
            <div class="col-md-2">
                Location
            </div>
            <div class="col-mid-10">
                <input type="text" id="txtCompanyLocation" class="form-control" placeholder="Enter Company Location" />
            </div>
        </div>
        <div class="col-mid-12">
            <button class="btn btn-primary" onclick="SaveProvider()">Save Provider</button>
            <button class="btn btn-danger">Reset</button>
        </div>`
    table.append(template);
}


function GetDataProviders() {
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
                                    <th>Delete</th>
                                </tr>
                            </thead>
                            <tbody id="tblProviderBody">
                            </tbody>
                        </table>
                    </div>`;
    table.append(template);

}

