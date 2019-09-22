
$('.BugDetails').click(function ($event) {
    var bug = $event.target.id;
    $.ajax({
        type: 'POST',
        url: 'Bugs/SingleBug',
        data: {bugId: bug},

        success: function (data) {
            $('#BugInformation').html(data);
            $('#myModal').modal('show');
        }
    });
});

window.onclick = function (event) {
    var modal = document.getElementById('myModal');
    if (event.target === modal) {
        modal.style.display = "none";
    }
}