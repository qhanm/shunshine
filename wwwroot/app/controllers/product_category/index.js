var ProductCategoryController = function () {
    this.Initial = function () {
        registerEvent();
    }

    var registerEvent = function () {
        loadListCategory();
        registerHadle();
    }

    var registerHadle = function () {

        $("#paginateShowLimit").on("change", function () {
            loadListCategory(true);
        })

        $("#btnSearchCategory").on("click", function () {
            loadListCategory(true);
        })

        $(".selectable-all").on("click", function () {
            $("#tbodyContent").find('input:checkbox').not(this).prop('checked', this.checked);
            //$(".checkbox-row").prop("checked");
        })

        $(document).on("click", "#btnSaveChange", function () {

            var data = $("#frmCreateCategory").serialize();

            saveChagnes(data);
        })

        $("#txtName").blur(function () {
            
            $("#txtSeoAlias").val(shunshine.slug($("#txtName").val()));
        })

        $(document).on("click", ".btnView", function() {
            var id = $(this).data("idcategory");
            getCategoryById(id);
        })

        $(document).on("click", ".modalClose", function() {
            $("#modalViewCategoryDetail").modal("hide");
            setTimeout(function() {
                $("#modalShowCategoryDetail").html("");
            }, 500);
        })

        $(document).on("click", ".btnDelete", function () {
            var categoryId = $(this).data("idcategory");
            alertify.confirm("Are you sure delete category?", function (e) {
                if (e) {
                    deleteCategoryById(categoryId);
                    //alertify.success("You've clicked OK");
                }
            });
        })
    }

    var loadListCategory = function (ischangePageSize = false) {

        let pageSize = $("#paginateShowLimit").val();

        let keyword = $("#txtSearchCategory").val();

        $.ajax({
            type: "GET",
            url: "/admin/productcategory/GetAllPaginate",
            data: {
                pageCurrent: shunshine.configs.pageIndex,
                pageSize: pageSize,
                keyword: keyword
            },
            beforeSend: function() {
                shunshine.startLoading();
            },
            success: function (response) {
                var render = "";
                $.each(response.Results, function (key, value) {
                    
                    render += `
                            <tr>
                                <td>
                                    <span class="checkbox-custom checkbox-primary">
                                        <input class="selectable-item checkbox-row" data-id="${value.Id}" type="checkbox" id="row-${value.Id}" value="${value.Id}">
                                        <label for="row-${value.Id}"></label>
                                    </span>
                                </td>
                                <td>${value.Id}</td>
                                <td>${value.Name}</td>
                                <td>${value.SeoAlias}</td>
                                <td>${shunshine.dataTimeFormat(value.DateCreated)}</td>
                                <td>${shunshine.getStatus(value.Status)}</td >
                                <td class="text-nowrap">
                                    <button type="button" class="btn btn-sm btn-icon btn-flat btn-default btnView" data-idCategory="${value.Id}" data-toggle="tooltip" data-original-title="View" aria-describedby="tooltip662061">
                                        <i class="icon wb-eye" aria-hidden="true"></i>
                                    </button><button type="button" class="btn btn-sm btn-icon btn-flat btn-default btnEdit" data-idCategory="${value.Id}" data-toggle="tooltip" data-original-title="Edit" aria-describedby="tooltip662061">
                                        <i class="icon wb-wrench" aria-hidden="true"></i>
                                    </button>
                                    <button type="button" class="btn btn-sm btn-icon btn-flat btn-default btnDelete"  data-idCategory="${value.Id}" data-toggle="tooltip" data-original-title="Delete">
                                        <i class="icon wb-close" aria-hidden="true"></i>
                                    </button>
                                </td>
                            </tr>
                            `;
                })

                $("#tbodyContent").html(render);
                
                ShunshinePaginate(response.PageCount, response.CurrentPage, function () {
                    
                    loadListCategory();
                }, ischangePageSize);
                shunshine.stopLoading();
            },
            error: function(response) {
                shunshine.stopLoading();
                alert("Error loading ...");
                console.log(response);
            }
        })
    }

    var saveChagnes = function(data) {

        $.ajax({
            type: "POST",
            url: "/admin/productcategory/SaveEntity",
            data: data,
            beforeSend: function (data) {
                shunshine.startLoading();
            },
            success: function(data) {
                if (!data.Success) {
                    if (data.Data.hasOwnProperty("modelErrors")) {
                        var dataArray = data.Data.modelErrors;

                        var render = "";

                        $.each(dataArray[0], function(key, value) {
                            if (value) {
                                render += "<li class='shunshine-activeRed'>" + value + "</li>";
                            }
                        })

                        $("#frmCategoryShowMessage").html(render);
                    } else {
                        var render = "";
                        $.each(data.Data, function(key, value) {
  
                            if (value != "" || value != null) {
                                render += "<li class='shunshine-activeRed'>" + value + "</li>";
                            }
                        })

                        $("#frmCategoryShowMessage").html(render);

                    }
                    shunshine.showMessageError('Create category not success');
                } else {
                    shunshine.showMessageSuccess('Create category success');
                    $("#frmCreateCategory").trigger("reset");
                    loadListCategory(true);
                }
                
                shunshine.stopLoading();
            },
            error: function (data) {
                console.log(data);
                shunshine.showMessageError("Error when create product category");
            }
        })
    }


    var ShunshinePaginate = function (totalPage, currentPage, callBack, isChangePageSize = false) {

        if (isChangePageSize == true) {
            $('#paginateCategory').empty();
            $('#paginateCategory').removeData("twbs-pagination");
            $('#paginateCategory').unbind("page");
        }

        $('#paginateCategory').twbsPagination({
            totalPages: totalPage,
            startPage: currentPage,
            visiblePages: 5,
            initiateStartPageClick: true,
            href: false,
            hrefVariable: '{{number}}',
            first: 'First',
            prev: 'Previous',
            next: 'Next',
            last: 'Last',
            loop: false,
            onPageClick: function (event, p) {
                shunshine.configs.pageIndex = p;
                setTimeout(callBack(), 200);
            },
            //onPageClick: function (event, page) {
            //    $('.page-active').removeClass('page-active');
            //    $('#page' + page).addClass('page-active');
            //},

            // pagination Classes
            paginationClass: 'pagination',
            nextClass: 'next',
            prevClass: 'prev',
            lastClass: 'last',
            firstClass: 'first',
            pageClass: 'page',
            activeClass: 'active',
            disabledClass: 'disabled'

        });

        $("#paginateCategory").find("li").removeClass("page");
    }

    var getCategoryById = function(id) {

        $.ajax({
            type: "GET",
            url: "/admin/productcategory/getbyid/"+id,
            beforeSend: function() {
                shunshine.startLoading();
            },
            async: false, 
            success: function(response) {
                if (response.hasOwnProperty("Success") && response.Success == false) {
                    shunshine.showMessageError("Product category not found");
                } else {
                    result = true;
                    $("#modalShowCategoryDetail").html(response);
                    $('#modalViewCategoryDetail').modal({ backdrop: 'static', keyboard: false })
                    setTimeout(function() {
                        $("#modalViewCategoryDetail").modal("show");
                    }, 1000);
                }
                shunshine.stopLoading();
            },
            error: function(response) {
                console.log(response);
                shunshine.showMessageError("Error when loading category detail");
                shunshine.stopLoading();
            }
            
        })
    }

    var deleteCategoryById = function (id) {
        $.ajax({
            type: "POST",
            url: "/admin/productcategory/deletecategorybyid",
            data: {
                Id: id
            },
            beforeSend: function () {
                shunshine.startLoading();
            },
            success: function (response) {
                if (response.Success) {
                    shunshine.showMessageSuccess("Delete category success");
                    loadListCategory(true);
                } else {
                    shunshine.showMessageError("An error occurred while deleting");
                }
                shunshine.stopLoading();
            },
            error: function (response) {
                console.log(response);
                shunshine.showMessageError("An error occurred while deleting");
                shunshine.stopLoading();
            }
        })
    }
}