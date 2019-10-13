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
    notify: function (message, type) {
        $.notify(message, {
            // whether to hide the notification on click
            clickToHide: true,
            // whether to auto-hide the notification
            autoHide: true,
            // if autoHide, hide after milliseconds
            autoHideDelay: 5000,
            // show the arrow pointing at the element
            arrowShow: true,
            // arrow size in pixels
            arrowSize: 5,
            // position defines the notification position though uses the defaults below
            position: '...',
            // default positions
            elementPosition: 'top left',
            globalPosition: 'top right',
            // default style
            style: 'bootstrap',
            // default class (string or [string])
            className: type,
            // show animation
            showAnimation: 'slideDown',
            // show animation duration
            showDuration: 400,
            // hide animation
            hideAnimation: 'slideUp',
            // hide animation duration
            hideDuration: 200,
            // padding between element and notification
            gap: 2
        })
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
        if ($('.dv-loading').length > 0)
            $('.dv-loading').removeClass('hide');
    },
    stopLoading: function () {
        if ($('.dv-loading').length > 0)
            $('.dv-loading')
                .addClass('hide');
    },
    getStatus: function (status) {
        if (status == 1)
            return '<span class="badge bg-green">Kích hoạt</span>';
        else
            return '<span class="badge bg-red">Khoá</span>';
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

    // ussing input
    checkAndShowError : function (selector, attribute) {
        if ($(selector).val() === null || $(selector).val() === "") {
            $("#error" + attribute).text(attribute + " can't be blank");
            return null;
        }
        return $(selector).val();
    },
    showMessage: function (selector, message) {
        $(selector).text(message);
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
    }

}

//$(document).ajaxSend(function (e, xhr, options) {
//    if (options.type.toUpperCase() == "POST" || options.type.toUpperCase() == "PUT") {
//        var token = $('form').find("input[name='__RequestVerificationToken']").val();
//        xhr.setRequestHeader("RequestVerificationToken", token);
//    }
//});