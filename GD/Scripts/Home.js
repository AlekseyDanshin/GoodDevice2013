<<<<<<< HEAD
<<<<<<< HEAD
$img_name = rnd();
$(document).ready(function () {
	
$("#uploadify").uploadify({
'uploader': '/Scripts/uploadify.swf',
'script': 'Content/UploadFile/' + $img_name.val(),
//'cancelImg': '/Content/cancel.png',
'fileDesc': 'Только файлы в формате jpg или jpeg',
'auto': true,
'multi': false,
'fileExt': '*.jpg;*.jpeg;',
'width': '32',
'height': '32',
'queueSizeLimit': '1',
//'buttonImg': '/Content/add.png',
'onComplete': function (event, queueID, fileObj, response, data) {
var timestamp = new Date().getTime();
$('#my_image').attr("src", response + '?' + timestamp);
$('#my_image').width(200).height(200);
}});
});
=======
=======
>>>>>>> c7e45a48a6cf0f4860bd4cf8d431898ccfac393c
$img_name = rnd();
$(document).ready(function () {
	
$("#uploadify").uploadify({
'uploader': '/Scripts/uploadify.swf',
'script': 'Content/UploadFile/' + $img_name.val(),
//'cancelImg': '/Content/cancel.png',
'fileDesc': 'Только файлы в формате jpg или jpeg',
'auto': true,
'multi': false,
'fileExt': '*.jpg;*.jpeg;',
'width': '32',
'height': '32',
'queueSizeLimit': '1',
//'buttonImg': '/Content/add.png',
'onComplete': function (event, queueID, fileObj, response, data) {
var timestamp = new Date().getTime();
$('#my_image').attr("src", response + '?' + timestamp);
$('#my_image').width(200).height(200);
}});
});
<<<<<<< HEAD
>>>>>>> c7e45a48a6cf0f4860bd4cf8d431898ccfac393c
=======
>>>>>>> c7e45a48a6cf0f4860bd4cf8d431898ccfac393c
