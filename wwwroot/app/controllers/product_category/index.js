var ProductCategoryController = function (urlListTreeCategory, urlListTableCategory, urlListParentCategory) {
    this.inital = function () {
        registetEvent();
        registerHandle();
    }

    var registetEvent = function () {
        loadTreeCagegory();
        loadTableCategory();
    }

    var registerHandle = function () {
        $(document).on("change", "#pageSize", function () {
            loadTableCategory();
        })
    }

    var loadTreeCagegory = function () {
        $.ajax({
            url: urlListTreeCategory,
            type: "GET",
            success: function (response) {
                var render = "<ul class='menu-muilty'>";

                $.each(response, function (key, value) {
                    render += "<li><i class='fa fa-folder' aria-hidden='true'></i><a href='javascript:void(0)' data-id='" + value.parent.Id + "'>"+ "  " + value.parent.Name + "</a></li>";
                    
                    if (value.chirld.length > 0) {
                        render += "<ul>";
                        $.each(value.chirld, function (k, v) {
                            render += "<li><i class='fa fa-folder' aria-hidden='true'><a href='javascript:void(0)' data-id='" + v.Id + "'>" + v.Name + "</a></li>";
                        })
                        render += "</ul>";
                    }
                })

                render += "</ul>";

                $("#categoryLeft").html(render);
            },
            error: function (response) {
                alertify.error("An error occurred during loading");
                console.log(response);
            }
        })
    }

    var loadTableCategory = function () {

        let pageSize = $("#pageSize").val();

        let pageCurrent = $("#pageCurrentId").data("idx");

        if (pageCurrent == undefined) {
            pageCurrent = 1;
        }

        let keyword = $("#txtSearch").val();

        $.ajax({
            type: "get",
            url: urlListTableCategory,
            data: {
                pageCurrent: pageCurrent,
                pageSize: pageSize,
                keyword: keyword
            },
            success: function (response) {
                let render = "";

                $.each(response.Results, function (key, value) {

                    let classTr = key % 2 == 0 ? "even" : "odd";
                    // <td class=" "><img width="50px" height="50px" src="${value.Image ? value.Image : '/admin/images/null.png'}" /></td>
                    render += `
                    <tr class="${key % 2 == 0 ? "even" : "odd"} pointer">
                        <td class="a-center ">
                            <input type="checkbox" name="category[${value.Id}]" id="${value.Id}" value="run" class="flat" />
                        </td>
                        <td class=" ">${value.Name} </td>
                        <td class=" ">${value.SeoAlias}</td>
                        <td class=" ">${shunshine.getStatus(value.SeoAlias)}</td>
                        <td class="a-right a-right ">${shunshine.dateTimeFormatJson(value.DateCreated)}</td>
                        <td class="a-right a-right ">${shunshine.dateTimeFormatJson(value.DateModified)}</td>
                        <td class=" last">
                             <a class="btn  btn-sm btn-edit" data-id="{{Id}}"><i class="fa fa-pencil"></i></a>
                            <a class="btn  btn-sm btn-delete" data-id="{{Id}}"><i class="fa fa-trash"></i></a>
                        </td>
                    </tr>
                    `;
                })

                $("#tblContent").html(render);
                var renderPage = shunshinePaginate.page(response.CurrnetPage, response.PageCount);
                //var renderPage = shunshinePaginate.page(2, 9);
                $("#paginationContent").html(renderPage);
                shunshinePaginate.showInfoPage(response.CurrnetPage, pageSize, response.RowCount, "#pageInfo");
            },
            error: function (response) {
                alertify.error("An error occurred during loading");
                console.log(response);
            }
        })
    }

    var loadListParent = function(){
        $.ajax({
            type: "GET",
            url: urlListParentCategory,
            success: function (response) {

            },
            error: function (response) {
                console.log(response);
                alertify.error("An error occurred during loading");
            }
        })
    }

}