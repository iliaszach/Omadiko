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
                        var template = `<table id="example-editable-datatables" class="table table-bordered table-hover">
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
                                            <td>${data.CompanyPhoto}</td>
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
                                        </tr>
                                   `;
                                   

                        soma.append(template);
                    }
                    
                };

                makeTableHeaders();               
            }
        });
    });
    $('#btnClear').click(function () {
        counter--;
        allProviders.empty();
    });
});

