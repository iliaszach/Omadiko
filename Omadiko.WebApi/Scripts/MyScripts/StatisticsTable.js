function ShowStatistics(){
    alert('edo');
    ClearTemplateProviders();
    ClearTemplateMarble();
    TemplateHTHMLStatistics();
}


function ClearTemplateProviders() {
    let template = $("#somaProvider");
    template.remove();
}

function ClearTemplateMarble() {
    let template = $("#allMarble");
    template.remove();
}

function TemplateHTHMLStatistics(){
    let template = $("jsChartsStatistics");
    console.log(template);
    let data = '<h1>fafasf</h1>';
    template.append(data);
}


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
            var users = [];  
            for (var key of data) {
                if (key.ApplicationUsers.length > 0) {
                    users.push(key);
                }
            }
            let numberOfUsers = users.length;
            resolve(numberOfUsers);
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