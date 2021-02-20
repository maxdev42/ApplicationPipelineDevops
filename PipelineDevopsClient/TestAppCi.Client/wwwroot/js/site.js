// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function runTestApi() {

    fetch("TestApi")
        .then(response => {
            return response.json();
        })
        .then(data => {
            document.getElementById("content").innerHTML = '<p style="font-size: 20px;"><b>Status de l\'API : </b> ' + data["Value"] + '</p>';
        })
        .then(error => console.log('error', error));
}

function runTestSqlServer() {

    fetch("TestSqlServer")
        .then(response => {
            return response.json();
        })
        .then(data => {

            var tableContent = '';

            tableContent += '<table class="table"> <thead class="thead-dark"><tr></th><th scope="col">Values</th><th scope="col">Results</th></tr></thead>';
            tableContent += '<tbody>';
            tableContent += '<tr>';
            tableContent += '<td>' + data["name"] + '</td>';
            tableContent += '<td>' + data["status"] + '</td>';
            tableContent += '</tr>';

            tableContent += '</tbody></table>';

            document.getElementById('content').innerHTML = tableContent;
        })
        .then(error => console.log('error', error));
}

function runTestAwsS3() {

    //TODO code S3 part
}