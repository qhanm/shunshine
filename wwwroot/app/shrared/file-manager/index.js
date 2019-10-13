var FileManagerController = function (urlGetListFolder) {

    this.Initial = function () {
        registerEvent();
    }

    var registerEvent = function () {

        loadListImage();

        loadListYear();

        swichTab();

        //loadListRootPath(true, shunshine.configs.rootPathFileManager, "level1");

        //$(document).unbind("click", ".fileManangetFolderSub").on("click", ".fileManangetFolderSub", function (e) {

        //    e.preventDefault();

        //    if (e.handled !== true) // This will prevent event triggering more then once
        //    {
        //        var isClicked = false;

        //        if ($(this).hasClass("shunshine-cliecked")) {
        //            isClicked = true;
        //        } else {
        //            $(this).addClass("shunshine-cliecked");
        //        }

                

        //        var folderName = $(this).data("folder");

        //        var selecttorId = $(this).data("id");

        //        let level = "level2";

        //        let levelResult = $(this).parent().parent().data("level");

        //        if (levelResult == "level1") {
        //            let level = "level2";
        //            folderName = $("#" + selecttorId).parent().parent().data("folder") + "/" + folderName;

        //        } else if (levelResult == "level2") {
        //            //console.log("vao day");
        //            level = "level3";
        //            folderName = $("#" + selecttorId).parent().parent().parent().parent().data("folder")
        //                + "/" + $("#" + selecttorId).parent().parent().data("folder")
        //                + "/" + folderName;
        //        }

        //        folderName = shunshine.configs.rootPathFileManager + "/" + folderName;

        //        loadListRootPath(false, folderName, level, selecttorId, isClicked);

        //        e.handled = true;
        //    }

            
        //})

        //$(document).on("click", ".active-change", function() {

        //    $("#contentListFile").find(".shunshine-active").removeClass("shunshine-active");

        //    $(this).addClass("shunshine-active");
        //})

        //$(document).on("click", ".folder-year", function() {

        //    if ($(this).data("toggle") == "active") {
        //        $(this).parent().find("ul").css({ "display": "none" })
        //        $(this).data("toggle", "null");
        //    } else {
        //        $(this).parent().find("ul").css({ "display": "block" })
        //        $(this).data("toggle", "active");
        //    }   
        //})


        $(document).on("click", "#btnAddUpload", function (event) {
            $("#txtAddUpload").click();
        })

        var formData = new FormData();

        var count = 0;

        $(document).on("change", "#txtAddUpload", function () {

            files = document.getElementById('txtAddUpload');

            fileData = files.files;
            count += fileData.length;
            $.each(fileData, function (key, value) {
                formData.append("file[]", value, value.name);

            })

            $("#total-file-upload").html(count + " files upload");
        })

        $("#btnStartUpload").click(function() {

            if (count == 0) {
                $("#total-file-upload").html("You have not selected the file to upload");
                return false;
            }

            $.ajax({
                url: "/admin/filemanager/uploadimage",
                type: "POST",
                contentType: false,
                processData: false,
                data: formData,
                success: function (response) {
                    $("#total-file-upload").html("Upload success");
                },
                error: function (response) {
                    $("#total-file-upload").html(response.Message);
                }
            })
            formData.delete('file[]');
            count = 0;
        })
    }
    var loadListYear  = function () {
        $.ajax({
            type: "GET",
            url: "/admin/filemanager/getlistyeas",
            success: function (response) {
                var render = "<ul class='menu-muilty file-manager-folder'>";

                $.each(response, function(key, value) {
                    render += "<li data-folder='" + value + "' class='active-change folder-year' data-yearp='" + value + "'><i class='fa fa-folder' aria-hidden='true'></i>" + " " + value + "</li>";
                    render += loadListMonth(value);
                    
                })

                render += "</ul>";
                $("#fileManagerSideberContent").html(render);
                //loadListFile(folderRoot);
            },
            error: function (response) {
                console.log(response);
            }
        })
    }

    var loadListMonth = function(year) {

        var result = "";

        $.ajax({
            type: "GET",
            url: "/admin/filemanager/getlistmonths",
            data: {
                year: year
            },
            async: false,
            success: function(response) {
                
                if (response) {

                    var render = "<ul class='menu-muilty sub-menu-folder-month toggle-folder-sub' data-year='" + year + "'>";

                    $.each(response, function(k, v) {

                        render += "<li data-folder='" + v + "' class='active-change folder-month'><i class='fa fa-folder' aria-hidden='true'></i>" + " " + v + "</li>";
                    })

                    render += "</ul>";

                    result = render;
                }
                
            },
            error: function(response) {
                console.log(response);
            }
        })

        return result;
    }

    var loadListImage = function (query = "all") {
        $.ajax({
            type: "GET",
            url: "/admin/filemanager/getlistimage",
            data: {
                query: query
            },
            success: function (response) {

                var render = "";

                $.each(response, function (key, value) {
                    render += `
                            <div class="col-xs-4 col-sm-3 col-md-2 nopad text-center" data-idimage="${value.Id}" >
                                <label class="image-checkbox">
                                    <img class="img-responsive" src="${value.Url}" />
                                    <input type="checkbox" name="image[]" value="" />
                                    <i class="fa fa-check hidden"></i>
                                </label>
                            </div>
                                `;
                })
                console.log(render);
                $("#rowConentImageList").html(render);
            },
            error: function (response) {
                console.log(response);
            }
        })
    }

    var swichTab = function () {
        $(document).on("click", "#btnSwichFileList", function () {
            $("#contentListFile").css({ "display": "block" });
            $("#contentFileUpload").css({ "display": "none" });
        })

        $(document).on("click", "#btnSwichUpload", function() {
            console.log("1313");
            $("#contentListFile").css({ "display": "none" });
            $("#contentFileUpload").css({ "display": "block" });
        })
    }
}