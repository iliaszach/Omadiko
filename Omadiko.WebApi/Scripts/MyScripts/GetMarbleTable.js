$(document).ready(function () {
    var allMarble = $('#allMarble');

    $('#btn').click(function () {
        $.ajax({
            type: "GET",
            url: "api/Marbles/",
            dataType: "json",
            success: function (response) {
                allMarble.empty();
                var data = response;
                console.log(data);
                data.forEach(appendToTable);

                function appendToTable(data) {
                    var template = `
                                    <table id="example-editable-datatables" class="table table-bordered table-hover">
                                        <thead>
                                               <tr>
                                                   <th class="cell-small"></th>
                                                   <th>Name</th>
                                                   <th>Color</th>
                                                   <th>MarbleDescription</th>
                                                   <th>Country</th>
                                                   <th>Photo</th>
                                                   <th>Providers</th>
                                              </tr>
                                        </thead>
                                        <tbody id="soma">
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
                                        </tr>
                                    </tbody>
                                  </table>`
                    allMarble.append(template);
                }
            }
        });
    });
    $('#btnClear').click(function () {
        allMarble.empty();
    });
});