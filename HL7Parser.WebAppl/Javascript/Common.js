function mshShowSearch() {
    $("#MshSearch").css("display", "block");
    $("#PidSearch").css("display", "none");
    $("#MshGrid").css("display", "none");
    $("#PidGrid").css("display", "none");
}

function pidShowSearch() {
    $("#PidSearch").css("display", "block");
    $("#MshSearch").css("display", "none");
    $("#MshGrid").css("display", "none");
    $("#PidGrid").css("display", "none");
}

function showMshGrid() {
    $("#MshGrid").css("display", "block");
    $("#PidGrid").css("display", "none");
}

function showPidGrid() {
    $("#PidGrid").css("display", "block");
    $("#MshGrid").css("display", "none");
}
