var shunshine = {
    configs: {
        pageSize: 10,
        pageIndex: 1,
        rootPathFileManager: "wwwroot/uploaded/images",
        urlControllerFileManager: "FileManager",
        urlFileManagerGetListFile: "/admin/FileManager/GetListFile",
        urlFileManagerUploadFileDZ: "/admin/FileManager/UploadFile",
        rootPathUrl: "https://localhost:5001/",
    },

    dataTimeFormat: function (datetime) {
        let current_datetime = new Date(datetime);
        let formatted_date = current_datetime.getFullYear() + "-" + (current_datetime.getMonth() + 1) + "-" + current_datetime.getDate() + " " + current_datetime.getHours() + ":" + current_datetime.getMinutes() + ":" + current_datetime.getSeconds()

        return formatted_date;
    },

    dateTimeFormatJson: function (datetime) {
        if (datetime == null || datetime == '')
            return '';
        var newdate = new Date(parseInt(datetime.substr(6)));
        var month = newdate.getMonth() + 1;
        var day = newdate.getDate();
        var year = newdate.getFullYear();
        var hh = newdate.getHours();
        var mm = newdate.getMinutes();
        var ss = newdate.getSeconds();
        if (month < 10)
            month = "0" + month;
        if (day < 10)
            day = "0" + day;
        if (hh < 10)
            hh = "0" + hh;
        if (mm < 10)
            mm = "0" + mm;
        if (ss < 10)
            ss = "0" + ss;
        return day + "/" + month + "/" + year + " " + hh + ":" + mm + ":" + ss;
    },
    startLoading: function () {
        $(".shunshine-loader-box").css({ "display": "block" });
    },
    stopLoading: function () {
        $(".shunshine-loader-box").css({ "display": "none" });
    },
    getStatus: function (status) {
        if (status == 1)
            return '<span class="badge badge-pill badge-success">Active</span>';
        else
            return '<span class="badge badge-warning">Block</span>';
    },
    formatNumber: function (number, precision) {
        if (!isFinite(number)) {
            return number.toString();
        }

        var a = number.toFixed(precision).split('.');
        a[0] = a[0].replace(/\d(?=(\d{3})+$)/g, '$&,');
        return a.join('.');
    },
    unflattern: function (arr) {
        var map = {};
        var roots = [];
        for (var i = 0; i < arr.length; i += 1) {
            var node = arr[i];
            node.children = [];
            map[node.id] = i; // use map to look-up the parents
            if (node.parentId !== null) {
                arr[map[node.parentId]].children.push(node);
            } else {
                roots.push(node);
            }
        }
        return roots;
    },

    showMessageSuccess: function(message) {
        alertify.success(message);
    },

    showMessageError: function(message) {
        alertify.error(message);
    },

    converToMultiMenu(datas) {
        var results = new Array();

        $.each(datas, function (key, value) {
            if (!value.ParentId) {
                results[value.ParentId] = value;
            } else {
                results[value.ParentId] = [];
            }
        })
    },
    cutString: function (str, number = 15) {
        if (str.length >= 15) {
            str = str.substr(0, number) + "...";
        }
        return str;
    },

    slug: function(str) {
        var slug;
 
        //Đổi chữ hoa thành chữ thường
        slug = str.toLowerCase();
 
        //Đổi ký tự có dấu thành không dấu
        slug = slug.replace(/á|à|ả|ạ|ã|ă|ắ|ằ|ẳ|ẵ|ặ|â|ấ|ầ|ẩ|ẫ|ậ/gi, 'a');
        slug = slug.replace(/é|è|ẻ|ẽ|ẹ|ê|ế|ề|ể|ễ|ệ/gi, 'e');
        slug = slug.replace(/i|í|ì|ỉ|ĩ|ị/gi, 'i');
        slug = slug.replace(/ó|ò|ỏ|õ|ọ|ô|ố|ồ|ổ|ỗ|ộ|ơ|ớ|ờ|ở|ỡ|ợ/gi, 'o');
        slug = slug.replace(/ú|ù|ủ|ũ|ụ|ư|ứ|ừ|ử|ữ|ự/gi, 'u');
        slug = slug.replace(/ý|ỳ|ỷ|ỹ|ỵ/gi, 'y');
        slug = slug.replace(/đ/gi, 'd');
        //Xóa các ký tự đặt biệt
        slug = slug.replace(/\`|\~|\!|\@|\#|\||\$|\%|\^|\&|\*|\(|\)|\+|\=|\,|\.|\/|\?|\>|\<|\'|\"|\:|\;|_/gi, '');
        //Đổi khoảng trắng thành ký tự gạch ngang
        slug = slug.replace(/ /gi, "-");
        //Đổi nhiều ký tự gạch ngang liên tiếp thành 1 ký tự gạch ngang
        //Phòng trường hợp người nhập vào quá nhiều ký tự trắng
        slug = slug.replace(/\-\-\-\-\-/gi, '-');
        slug = slug.replace(/\-\-\-\-/gi, '-');
        slug = slug.replace(/\-\-\-/gi, '-');
        slug = slug.replace(/\-\-/gi, '-');
        //Xóa các ký tự gạch ngang ở đầu và cuối
        slug = '@' + slug + '@';
        slug = slug.replace(/\@\-|\-\@|\@/gi, '');
        //In slug ra textbox có id “slug”
        return slug;
    }

}

//$(document).ajaxSend(function (e, xhr, options) {
//    if (options.type.toUpperCase() == "POST" || options.type.toUpperCase() == "PUT") {
//        var token = $('form').find("input[name='__RequestVerificationToken']").val();
//        xhr.setRequestHeader("RequestVerificationToken", token);
//    }
//});