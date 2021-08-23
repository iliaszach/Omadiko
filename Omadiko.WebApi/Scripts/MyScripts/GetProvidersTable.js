
$(document).ready(function () {
    var allProviders = $('#allProviders');
    var counter = 0;
    $('#btn').click(function () {
        $.ajax({
            type: "GET",
            url: "api/Providers/",
            dataType: "json",
            success: function (response) {
                allProviders.empty();
                var data = response;

                function makeTableHeaders() {
                    if (counter == 0) {
                        var template = `
                                        <input id="Createbtn" class="btn btn-primary" type="button" value="Create Provider" />
                                        <table id="example-editable-datatables" class="table table-bordered table-hover">
                                        <thead>
                                               <tr>
                                                   <th class="cell-small"></th>
                                                   <th>Title</th>
                                                   <th>Description</th>
                                                   <th>Photo</th>
                                                   <th>Phone</th>
                                                   <th>Website</th>
                                                   <th class="hidden-xs hidden-sm"><i class="fa fa-envelope-o"></i> Email</th>
                                                   <th>Location</th>
                                                   <th>Marbles</th>
                                                   <th>Business Type</th>
                                                   <th>Actions</th>
                                              </tr>
                                        </thead>
                                       <tbody id="soma">

                                      </tbody>
                                   </table>`;

                        counter++;
                        allProviders.append(template);

                    }

                    data.forEach(appendToTable);
                    
                    function appendToTable(data) {
                        var soma = $("#soma");
                        
                        var template = ` <tr >
                                            <td class="text-center">
                                                <a href="javascript:void(0)" id="delRow1" class="btn btn-xs btn-danger delRow"><i class="fa fa-times"></i></a>
                                            </td> 
                        
                                            <td>${data.CompanyTitle}</td>
                                            <td>${data.CompanyDescription}</td>
                                            <td><img src=${data.CompanyPhoto} alt="Alternate Text" /></td>
                                            <td>${data.Phone}</td>
                                            <td>${data.WebSite}</td>
                                            <td id="email1" class="editable-td hidden-xs hidden-sm">${data.Email}</td>
                                            <td>${data.Location.Country}</td>
                                            <td>
                                                <ul>                                                   
                                                     ${data.Marbles.map(x => `<li>${x.Name}</li>`).join("")}
                                                </ul>
                                            </td>
                                            <td>
                                                <ul>                                                   
                                                     ${data.BusinessTypes.map(x => `<li>${x.Kind}</li>`).join("")}
                                                </ul>
                                            </td> 
                                            <td>
                                              <div>
                                                <button class="btn btn-success form-control" ${data.ProviderId}>EDIT</button>
                                                <button data-provider-id="${data.ProviderId}" class="btn btn-danger form-control js-delete" >DELETE</button>
                                              </div>
                                            </td>
                                        </tr>
                                   `;


                        soma.append(template);
                    }

                };

                makeTableHeaders();
                //DELETE
                $(document).ready(function () {
                    console.log("mpka");
                    $("#example-editable-datatables .js-delete").on("click", function () {
                        if (confirm("Are you sure, you want to delete this provider?")) {
                            $.ajax({                                
                                url: "api/Providers/" + $(this).attr("data-provider-id"),
                                method: "DELETE",                                
                                success: function (response) {
                                    console.log(response);
                                }
                            });
                        }
                    });
                });
            }
        });

    });
    $('#btnClear').click(function () {
        counter--;
        allProviders.empty();
    });   
    
});




function deleteProvider(id) {
    var action = confirm("Are you sure you want to delete this student?");  //Είναι το παράθυρο που εμφανίζεται όταν κάνουμε delete , επιστρέφει True αν πατήσουμε Ok, διαφορετικά False
    var msg = "Student deleted successfully!";
    $.ajax({
        type: "DELETE",
        url: "api/Providers/",
        
        dataType: "json",
        success: function (response) {
            console.log(response);
        }
    });
    students.forEach(function (stu, i) {          //Καλούμε την ForEach περνάμε όλους τους employees και ένα ανώνυμο callback, που δέχεται έναν emp και την θέση του στον πίνακα employees
        if (stu.id == id && action != false) {    //Αν έχουμε πατήσει να γίνει delete, και υπάρχει employee με αυτό το id κάνουμε τα παρακάτω
            students.splice(i, 1);               //Διαγράφουμε τον employee με την μέθοδο splice  https://www.w3schools.com/jsref/jsref_splice.asp
            $("table #stu-" + stu.id).remove();   //Πάμε στην γραμμή που έχει το κατάλληλο id και κάνουμε remove
            flashMessage(msg);                    //Eμφανίζουμε μήνυμα
        }
    });
}