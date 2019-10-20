var FileManagerController = function () {

    this.Initial = function () {
        registerEvent();
    }

    var registerEvent = function () {
        swichTab();
        loadListImagePaginate();

        //loadListImage();

        //loadListYear();

        //swichTab();

        $(document).on("click", ".fileManagerCheckboxImage", function () {

            if ($(this).hasClass("isChecked")) {
                $(this).removeClass("isChecked");
            } else {
                $(this).addClass("isChecked");
            }

        })
        $(".fileManagerCheckboxImage").each(function () {
            
        });
        //$(document).on("click", ".image-checkbox", function (e) {
        //    $(this).toggleClass('image-checkbox-checked');
        //    var $checkbox = $(this).find('input[type="checkbox"]');
        //    $checkbox.prop("checked", !$checkbox.prop("checked"))
        //    $checkbox.addClass("checked-value");
        //    e.preventDefault();
        //})

        //$(document).on("click", ".folder-month", function () {
        //    console.log($(this).parent());
        //    loadListImage($(this).parent().data("year") ,$(this).data("folder"));
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


    var swichTab = function () {
        $(document).on("click", "#btnSwichTabListImage", function () {
            $("#tabListImage").css({ "display": "block" });
            $("#tabUploadImage").css({ "display": "none" });
            loadListImagePaginate();
        })

        $(document).on("click", "#btnSwichTabUpload", function () {

            $("#tabListImage").css({ "display": "none" });
            $("#tabUploadImage").css({ "display": "block" });
        })
    }

    var loadListImagePaginate = function () {
        $.ajax({
            type: "GET",
            url: "/admin/FileManager/getListPaginageImage",
            data: {
                pageCurrent: 1,
                pageSize: 20,
                keyword: "",
            },
            success: function (response) {

                var render = "";

                $.each(response.Results, function (key, value) {
                    render += `
                            <li class="animation-fade animation-scale-up" data-idLi="${value.Id}" style="animation-fill-mode: backwards; animation-duration: 250ms; animation-delay: 0ms;">
                                <div class="media-item" style="height:300px" data-toggle="slidePanel" data-url="panel.tpl">
                                    <div class="checkbox-custom checkbox-primary checkbox-lg">
                                        <input type="checkbox" class="selectable-item fileManagerCheckboxImage" data-checkboxId="${value.Id}" id="checkbox-${value.Id}" value="${value.Url}">
                                        <label for="checkbox-${value.Id}"></label>
                                    </div>
                                    <div class="image-wrap">
                                        <img class="image rounded ss-image-file-manager"  src="${value.Url}" alt="${value.Name}">
                                    </div>
                                    <div class="info-wrap">
                                        <div class="dropdown">
                                            <span class="icon wb-settings" data-toggle="dropdown" aria-expanded="false" role="button" data-animation="scale-up"></span>
                                            <div class="dropdown-menu dropdown-menu-right" role="menu">
                                                <a class="dropdown-item" href="javascript:void(0)"><i class="icon wb-pencil" aria-hidden="true"></i>Edit</a>
                                                <a class="dropdown-item" href="javascript:void(0)"><i class="icon wb-download" aria-hidden="true"></i>Download</a>
                                                <a class="dropdown-item" href="javascript:void(0)"><i class="icon wb-trash" aria-hidden="true"></i>Delete</a>
                                            </div>
                                        </div>
                                        <div class="title"><a href="${value.Url}" target="_blank">${shunshine.cutString(value.Name, 13)}</a></div>
                                        <div class="time">1 minutes ago</div>
                                        <div class="media-item-actions btn-group">
                                            <button class="btn btn-icon btn-pure btn-default" data-original-title="Edit" data-toggle="tooltip" data-editImage="${value.Id}" data-container="body" data-placement="top" data-trigger="hover" type="button">
                                                <i class="icon wb-pencil" aria-hidden="true"></i>
                                            </button>
                                            <button class="btn btn-icon btn-pure btn-default" data-original-title="Download" data-toggle="tooltip" data-container="body" data-placement="top" data-trigger="hover" type="button">
                                                <i class="icon wb-download" aria-hidden="true"></i>
                                            </button>
                                            <button class="btn btn-icon btn-pure btn-default" data-original-title="Delete" data-toggle="tooltip" data-deleteId="${value.Id}" data-container="body" data-placement="top" data-trigger="hover" type="button">
                                                <i class="icon wb-trash" aria-hidden="true"></i>
                                            </button>
                                        </div>
                                    </div>
                                </div>
                            </li>
                            `;
                })

                $("#shunshineFileManagerListImageContent").html(render);
            },
            error: function (response) {
                console.log(response);
                alertify.error('Error when loading list image');
            }
        })
    }

}