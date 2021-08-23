﻿$(document).ready(function () {
    var allMarble = $('#allMarble');
    var counter = 0;
    $('#btn').click(function () {
        $.ajax({
            type: "GET",
            url: "api/Marbles/",
            dataType: "json",
            success: function (response) {
                allMarble.empty();
                var data = response;

                function makeTableHeaders() {
                    if (counter == 0) {
                        var template = `<table id="example-editable-datatables" class="table table-bordered table-hover">
                                        <thead>
                                               <tr>
                                                   <th class="cell-small"></th>
                                                   <th>Name</th>
                                                   <th>Color</th>
                                                   <th>MarbleDescription</th>
                                                   <th>Country</th>
                                                   <th>Photo</th>
                                                   <th>Providers</th>
                                                   <th>Actions</th>
                                              </tr>
                                        </thead>
                                       <tbody id="soma">

                                      </tbody>
                                   </table>`;

                        counter++;
                        allMarble.append(template);

                    }


                    data.forEach(appendToTable);

                    function appendToTable(data) {
                        var soma = $('#soma');
                        var template = `                                    
                                        <tr >
                                            <td class="text-center">
                                                <a href="javascript:void(0)" id="delRow1" class="btn btn-xs btn-danger delRow"><i class="fa fa-times"></i></a>
                                            </td>
                                            <td>${data.Name}</td>
                                            <td>${data.Color}</td>
                                            <td>${data.MarbleDescription}</td>
                                            <td>${data.Country.Name}</td>
                                            <td>${data.Photo.Url}</td>
                                            <td>
                                                <ul>
                                                        ${data.Providers.map(x => `<li>${x.CompanyTitle}</li>`).join("")}
                                                </ul>
                                            </td>
                                            <td>
                                              <div>
                                                <button class="btn btn-success form-control" onClick="editStudent(${data.MarbleId})" data-toggle="modal" data-target="#myModal")">EDIT</button>
                                                <button class="btn btn-danger form-control" onClick="deleteStudent(${data.MarbleId})">DELETE</button>
                                              </div>
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
        allMarble.empty();
    });
});