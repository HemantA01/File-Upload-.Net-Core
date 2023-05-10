$(document).ready(function () {
    //alert('1');
});

$('#btnsubmit').click(function () {
    var model = new FormData();
    var file = $('#postedfile').prop('files')[0];
    if (file == null) {
        $('#spnfile').text('Please select file to upload');
        return false;
    } else {
        $('#spnfile').text('');
    }
    model.append('formFile', file);
    $.ajax({
        type: 'post',
        url: '/Home/UploadFilePage',
        cache: false,
        data: model,
        contentType: false,
        processData: false,
        success: function (result) {
            alert('file uploaded successfully');
            window.location.href = '../Home/Index';

        },
        error: function (err) {
            alert('Error occured');
        }
    })
});