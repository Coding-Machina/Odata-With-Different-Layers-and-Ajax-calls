$(document).ready(function () {
    ShowBatches();
    $("#Save").click(function () {
        var Batch = new Object();
        //Batch.BatchId = $('#BatchId').val();
        Batch.BatchName = $('#BatchName').val();
        Batch.TotalHours = $('#TotalHours').val();
        Batch.HoursTaken = $('#HoursTaken').val();
        $.ajax({
            url: "/OdataApi/Batch",
            type: "POST",
            dataType: "json",
            data: Batch,
            
        });
        ShowBatches();
    });
});

function ShowBatches() {
    $.ajax({
        url: "/OdataApi/Batch",
        type: "GET",
        dataType: "json",
        success: function (data) {
            let batches = data.value;
            var html = '';
            $.each(batches, function (i, itemData) {
                html += "<tr>";
                html += "<td>" + itemData.BatchId + "</td>";
                html += "<td>" + itemData.BatchName + "</td>";
                html += "<td>" + itemData.TotalHours + "</td>";
                html += "<td>" + itemData.HoursTaken + "</td>";
                html += "</tr>";
            });
            $("#Batchtable > tbody").html(html);
        }
    });
}