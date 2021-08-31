// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
    function AddValuesTB(clicked_id) {
            document.getElementById('FirstTB').value += document.getElementById(clicked_id).innerText;
    }
    function SelectChar(clicked_id) {
         if (document.getElementById('FirstTB').value !== "") {
            document.getElementById('ResultTB').value = document.getElementById('FirstTB').value + document.getElementById(clicked_id).innerText;
            document.getElementById('FirstTB').value = "";
         }
    }
    function ClearClick() {
        document.getElementById('ResultTB').value = "";
        document.getElementById('FirstTB').value = "";
    }
    function PointClick(clicked_id) {
        var numberValue = document.getElementById('FirstTB').value;
            if (numberValue.indexOf(',') == -1 && numberValue != "")
                document.getElementById('FirstTB').value += document.getElementById(clicked_id).innerText;
    }

