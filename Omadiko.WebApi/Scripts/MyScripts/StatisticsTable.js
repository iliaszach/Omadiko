$(document).ready(function () {
    ShowStatistics();
})

function ShowStatistics() {
    ClearTemplateProviders();
    ClearTemplateMarble();
    ClearStatistics();
    TemplateForStatistics();
    AllFunctions();
    InitializeStatistics();
}

function ClearTemplateProviders() {
    let template = $("#allProviders");
    template.empty();
}

function ClearTemplateMarble() {
    let template = $("#allMarble");
    template.empty();
}
function ClearStatistics() {
    let template = $("#jsChartsStatistics")
    template.empty();
}
function TemplateForStatistics() {

    let template = $("#jsChartsStatistics")
    let data =
        `<div class="dash-tiles row">
    <!-- Column 1 of Row 1 -->
    <div class="col-sm-3">
        <!-- Total Users Tile -->
        <div class="dash-tile dash-tile-ocean clearfix animation-pullDown">
            <div class="dash-tile-header">
                <div class="dash-tile-options">
                    <div class="btn-group">
                        <a href="javascript:void(0)" class="btn btn-default" data-toggle="tooltip" title="Manage Users"><i class="fa fa-cog"></i></a>
                        <a href="javascript:void(0)" class="btn btn-default" data-toggle="tooltip" title="Statistics"><i class="fa fa-bar-chart-o"></i></a>
                    </div>
                </div>
                Total Users
            </div>
            <div class="dash-tile-icon"><i class="fa fa-users"></i></div>
            <div id="TotalUsers"  class="dash-tile-text">-</div>
        </div>
        <!-- END Total Users Tile -->
        <!-- Total Profit Tile -->
        <div class="dash-tile dash-tile-leaf clearfix animation-pullDown">
            <div class="dash-tile-header">
                <span class="dash-tile-options">
                    <a href="javascript:void(0)" class="btn btn-default" data-toggle="tooltip" title="Statistics"><i class="fa fa-bar-chart-o"></i></a>
                </span>
                Total Providers
            </div>
            <div class="dash-tile-icon"><i class="fa fa-line-chart " aria-hidden="true"></i></div>
            <div id="TotalProviders" class="dash-tile-text">-</div>
        </div>
        <!-- END Total Profit Tile -->
    </div>
    <!-- END Column 1 of Row 1 -->
    <!-- Column 2 of Row 1 -->
    <div class="col-sm-3">
        <!-- Total Sales Tile -->
        <div class="dash-tile dash-tile-flower clearfix animation-pullDown">
            <div class="dash-tile-header">
                <div class="dash-tile-options">
                    <div class="btn-group">
                        <a href="javascript:void(0)" class="btn btn-default" data-toggle="tooltip" title="View new orders"><i class="fa fa-shopping-cart"></i></a>
                        <a href="javascript:void(0)" class="btn btn-default" data-toggle="tooltip" title="Statistics"><i class="fa fa-bar-chart-o"></i></a>
                    </div>
                </div>
                Total Marble
            </div>
            <div class="dash-tile-icon"><i class="fa fa-tags"></i></div>
            <div id="AllMarbles" class="dash-tile-text">-</div>
        </div>
        <!-- END Total Sales Tile -->
        <!-- Total Downloads Tile -->
        <div class="dash-tile dash-tile-fruit clearfix animation-pullDown">
            <div class="dash-tile-header">
                <div class="dash-tile-options">
                    <a href="javascript:void(0)" class="btn btn-default" data-toggle="tooltip" title="View popular downloads"><i class="fa fa-asterisk"></i></a>
                </div>
                Total Downloads [NO USE]
            </div>
            <div class="dash-tile-icon"><i class="fa fa-cloud-download"></i></div>
            <div class="dash-tile-text">360k</div>
        </div>
        <!-- END Total Downloads Tile -->
    </div>
    <!-- END Column 2 of Row 1 -->
    <!-- Column 3 of Row 1 -->
    <div class="col-sm-3">
        <!-- Popularity Tile -->
        <div class="dash-tile dash-tile-oil clearfix animation-pullDown">
            <div class="dash-tile-header">
                <div class="dash-tile-options">
                    
                </div>
                Most Popular Marble
            </div>
            <div id="MarbleName" class="h6 text-muted">-</div><br />
            <div id="Marblelikes" class="dash-tile-text">-</div>
        </div>
        <!-- END Popularity Tile -->
        <!-- Server Downtime Tile -->
        <!--<div class="dash-tile dash-tile-dark clearfix animation-pullDown">
            <div class="dash-tile-header">
                <div class="dash-tile-options">
                    <a href="javascript:void(0)" class="btn btn-default" data-toggle="tooltip" title="Monthly report"><i class="fa fa-bar-chart-o"></i></a>
                </div>
                Server Downtime
            </div>
            <div class="dash-tile-icon"><i class="fa fa-hdd-o"></i></div>
            <div class="dash-tile-text">0.1%</div>
        </div>-->
        <!-- END Server Downtime Tile -->
    </div>
    <!-- END Column 3 of Row 1 -->
    <!-- Column 4 of Row 1 -->
    <div class="col-sm-3">
        <!-- RSS Subscribers Tile -->
        <div class="dash-tile dash-tile-balloon clearfix animation-pullDown">
            <div class="dash-tile-header">
                <div class="dash-tile-options">
                    <a href="javascript:void(0)" class="btn btn-default" data-toggle="tooltip" title="Manage subscribers"><i class="fa fa-cog"></i></a>
                </div>
                RSS Subscribers
            </div>
            <div class="dash-tile-icon"><i class="fa fa-rss"></i></div>
            <div class="dash-tile-text">160k</div>
        </div>
        <!-- END RSS Subscribers Tile -->
        <!-- Total Tickets Tile -->
        <div class="dash-tile dash-tile-doll clearfix animation-pullDown">
            <div class="dash-tile-header">
                <div class="dash-tile-options">
                    <a href="javascript:void(0)" class="btn btn-default" data-toggle="tooltip" title="Open tickets"><i class="fa fa-file-o"></i></a>
                </div>
                Total Tickets
            </div>
            <div class="dash-tile-icon"><i class="fa fa-wrench"></i></div>
            <div class="dash-tile-text">1.5k</div>
        </div>
        <!-- END Total Tickets Tile -->
    </div>
    <!-- END Column 4 of Row 1 -->
</div>

<div class="row">
    <!-- Column 1 of Row 2 -->
    <div class="col-sm-6">
        <!-- Statistics Tile -->
        <div class="dash-tile dash-tile-2x">
            <div class="dash-tile-header">
                <div class="dash-tile-options">
                    <div id="example-advanced-daterangepicker" class="btn btn-default">
                        <i class="fa fa-calendar"></i>
                        <span></span>
                        <b class="caret"></b>
                    </div>
                </div>
                <i class="fa fa-bar-chart-o"></i>
            </div>
            <div class="dash-tile-content">
                <div id="dash-example-stats" class="dash-tile-content-inner"></div>
            </div>
        </div>
        <!-- END Statistics Tile -->
    </div>
    <!-- END Column 1 of Row 2 -->
    <!-- Column 2 of Row 2 -->
    <div class="col-sm-6">
        <!-- Projects Tile -->
        
         <h3 class="page-header-sub">Pie</h3>
         <div id="example-chart-pie" class="chart"></div>
</div>
    <!--</div>-->
    <!-- END Column 3 of Row 2 -->
</div>



`;

    template.append(data);
}


function AllFunctions() {

    //Total Providers
    var AllProviders = new Promise(function (resolve, reject) {
        var dataSize;
        $.ajax("/api/providers")
            .done(function (data) {
                dataSize = (Object.keys(data).length).toString();
                resolve(dataSize);
            })
            .fail(function () {
                reject("error");
            })
    });
    AllProviders.then(function (result) {
        $("#TotalProviders").text(result);
    }, function (err) {
        $("#TotalProviders").text(err);
    });

    var AllMarble = new Promise(function (resolve, reject) {
        var dataSize;
        $.ajax("/api/marbles")
            .done(function (data) {
                dataSize = (Object.keys(data).length).toString();
                resolve(dataSize);
            })
            .fail(function () {
                reject("error");
            })
    });
    AllMarble.then(function (result) {
        $("#AllMarbles").text(result);
    }, function (err) {
        $("#AllMarbles").text(err);
    });

    //Most popular marble
    //MarbleName
    var MarbleName = new Promise(function (resolve, reject) {
        $.ajax("/api/marbles")
            .done(function (data) {
                var appUsers = [];
                var marbles = [];
                for (var key of data) {
                    if (key.ApplicationUsers.length > 0) {
                        appUsers.push(key.ApplicationUsers.length);
                        marbles.push(key);
                    }
                }

                let MaxNum = appUsers.reduce((a, b) => appUsers[a] > appUsers[b] ? a : b);

                let obj;
                for (var marble of marbles) {

                    if (marble.ApplicationUsers.length == MaxNum) {
                        obj = marble;
                    }
                }
                let objName = obj.Name;
                resolve(objName);
            })
            .fail(function () {
                reject("error");
            })

    });
    MarbleName.then(function (result) {
        $("#MarbleName").text(result);
    }, function (err) {
        $("#MarbleName").text(err);
    });

    //MarbleLikes
    var MarbleLikes = new Promise(function (resolve, reject) {

        $.ajax("/api/marbles")
            .done(function (data) {
                var appUsers = [];
                var marbles = [];
                for (var key of data) {
                    if (key.ApplicationUsers.length > 0) {
                        appUsers.push(key.ApplicationUsers.length);
                        marbles.push(key);
                    }
                }
                let MaxNum = appUsers.reduce((a, b) => appUsers[a] > appUsers[b] ? a : b);
                let obj;
                for (var marble of marbles) {

                    if (marble.ApplicationUsers.length == MaxNum) {
                        obj = marble;
                    }
                }
                let objlikes = obj.ApplicationUsers.length;

                resolve(objlikes);
            })
            .fail(function () {
                reject("error");
            })

    });
    MarbleLikes.then(function (result) {
        $("#Marblelikes").text(result);
    }, function (err) {
        $("#Marblelikes").text(err);
    });

    //Total Active Users
    var TotalUsers = new Promise(function (resolve, reject) {

        $.ajax("/api/marbles")
            .done(function (data) {
                let users = new Set()

                var marbles = [];
                for (let marble of data) {
                    if (marble.ApplicationUsers.length > 0) {
                        marbles.push(marble);
                    }
                }

                for (let marble of marbles) {
                    for (var user of marble.ApplicationUsers) {
                        users.add(user.UserName);
                    }

                }
                var size = users.size;
                console.log(size);

                resolve(size);
            })
            .fail(function () {
                reject("error");
            })

    });
    TotalUsers.then(function (result) {
        $("#TotalUsers").text(result);
    }, function (err) {
        $("#TotalUsers").text(err);
    });
}

function InitializeStatistics() {
    $(function () {


        $.ajax({
            type: "get",
            url: "api/marbles",
            data: "name=John&location=Boston",
            dataType: "json",
            success: function (marbles) {

                var marbleUsers = [];
                /* Pie Chart */
                var pieData = [];
                
                for (var marble of marbles) {
                    if (marble.ApplicationUsers.length > 1) {
                        marbleUsers.push(marble);
                    }
                }
                var pieSeries = Math.floor(Math.random() * 10) + 1;
                for (let i = 0; i < marbleUsers.length; i++)

                    pieData[i] = {
                        label: 'Data ' + marbleUsers[i].Name,
                        data: marbleUsers[i].ApplicationUsers.length
                    };
                //Initialize chart-pie
                var chartPie = $('#example-chart-pie');

                $.plot(chartPie, pieData,
                    {
                        series: {
                            pie: {
                                show: true,
                                radius: 1,
                                label: {
                                    show: true,
                                    radius: 3 / 4,
                                    formatter: function (label, pieSeries) {
                                        return '<div class="chart-pie-label">' + label + '<br>' + Math.round(pieSeries.percent) + '%</div>';
                                    },
                                    background: {
                                        opacity: 0.5,
                                        color: '#000000'
                                    }
                                }
                            }
                        },
                        colors: ['#39a8db', '#db4a39', '#a8db39', '#39d5db'],
                        legend: {
                            show: false
                        }
                    });
            }
        });




        // Initialize dash Datatables
        $('#dash-example-orders').dataTable({
            columnDefs: [{ orderable: false, targets: [0] }],
            pageLength: 6,
            lengthMenu: [[6, 10, 30, -1], [6, 10, 30, "All"]]
        });
        $('.dataTables_filter input').attr('placeholder', 'Search');

        // Dash example stats
        var dashChart = $('#dash-example-stats');
        var dashChartData1 = [
            [0, 200],
            [1, 250],
            [2, 360],
            [3, 584],
            [4, 1250],
            [5, 1100],
            [6, 1500],
            [7, 1521],
            [8, 1600],
            [9, 1658],
            [10, 1623],
            [11, 1900],
            [12, 2100],
            [13, 1700],
            [14, 1620],
            [15, 1820],
            [16, 1950],
            [17, 2220],
            [18, 1951],
            [19, 2152],
            [20, 2300],
            [21, 2325],
            [22, 2200],
            [23, 2156],
            [24, 2350],
            [25, 2420],
            [26, 2480],
            [27, 2320],
            [28, 2380],
            [29, 2520],
            [30, 2590]
        ];
        var dashChartData2 = [
            [0, 50],
            [1, 180],
            [2, 200],
            [3, 350],
            [4, 700],
            [5, 650],
            [6, 700],
            [7, 780],
            [8, 820],
            [9, 880],
            [10, 1200],
            [11, 1250],
            [12, 1500],
            [13, 1195],
            [14, 1300],
            [15, 1350],
            [16, 1460],
            [17, 1680],
            [18, 1368],
            [19, 1589],
            [20, 1780],
            [21, 2100],
            [22, 1962],
            [23, 1952],
            [24, 2110],
            [25, 2260],
            [26, 2298],
            [27, 1985],
            [28, 2252],
            [29, 2300],
            [30, 2450]
        ];

        // Initialize Chart
        $.plot(dashChart, [
            { data: dashChartData1, lines: { show: true, fill: true, fillColor: { colors: [{ opacity: 0.05 }, { opacity: 0.05 }] } }, points: { show: true }, label: 'All Visits' },
            { data: dashChartData2, lines: { show: true, fill: true, fillColor: { colors: [{ opacity: 0.05 }, { opacity: 0.05 }] } }, points: { show: true }, label: 'Unique Visits' }],
            {
                legend: {
                    position: 'nw',
                    backgroundColor: '#f6f6f6',
                    backgroundOpacity: 0.8
                },
                colors: ['#555555', '#db4a39'],
                grid: {
                    borderColor: '#cccccc',
                    color: '#999999',
                    labelMargin: 5,
                    hoverable: true,
                    clickable: true
                },
                yaxis: {
                    ticks: 5
                },
                xaxis: {
                    tickSize: 2
                }
            }
        );

        // Create and bind tooltip
        var previousPoint = null;
        dashChart.bind("plothover", function (event, pos, item) {

            if (item) {
                if (previousPoint !== item.dataIndex) {
                    previousPoint = item.dataIndex;

                    $("#tooltip").remove();
                    var x = item.datapoint[0],
                        y = item.datapoint[1];

                    $('<div id="tooltip" class="chart-tooltip"><strong>' + y + '</strong> visits</div>')
                        .css({ top: item.pageY - 30, left: item.pageX + 5 })
                        .appendTo("body")
                        .show();
                }
            }
            else {
                $("#tooltip").remove();
                previousPoint = null;
            }
        });
    });
}