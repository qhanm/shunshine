var shunshinePaginate = {
    page: function (currentPage = 1, pageCount) {

        var activeCurrentPageFirst = "";

        var activeCurrentPageLast = "";

        var first = "";

        var last = "";

        var PageFor = "";

        var pageContent = "";

        var render = "";

        if (currentPage == 1) {
            activeCurrentPageFirst = "disabled";
            first = 1;
        } else {
            first = currentPage - 1;
        }

        let firstPage = '<li class="paginate_button previous ' + activeCurrentPageFirst + '" id="datatable-responsive_previous"><a href = "javascript:void(0)" aria-controls="datatable-responsive" data-dt-idx="1" >‹‹</a></li>';


        if (currentPage == pageCount) {
            activeCurrentPageLast = "disabled";
            last = pageCount;
        } else {
            last = currentPage + 1;
        }

        let lastPage = '<li class="paginate_button previous ' + activeCurrentPageLast + '" id="datatable-responsive_previous"><a href = "javascript:void(0)" aria-controls="datatable-responsive" data-dt-idx="' + pageCount + '" >››</a></li>';

        if (pageCount <= 5) {
            PageFor = pageCount;
        } else {
            if (currentPage == 1) {
                PageFor = 1;
            } else if (currentPage == 2) {
                PageFor = 1;
            } else if (pageCount - currentPage == 0) {
                PageFor = pageCount - 4;
            } else if ((pageCount - currentPage) == 1) {
                PageFor = pageCount - 4;
            } else if ((pageCount - currentPage) == 2) {
                PageFor = pageCount - 4;
            } else {
                PageFor = currentPage - 2;
            }
        }

        let key = 0;

        for (i = PageFor; i <= (PageFor + 5); i++) {

            var active = "";

            var pageCurrentId = "";

            if (i == currentPage) {
                active = "active";
                pageCurrentId = "pageCurrentId";
            }

            if (i > pageCount || key >= 5) break;

            pageContent += '<li class="paginate_button ' + active + ' "><a href="javascript:void(0)" id="' + pageCurrentId + '" aria-controls="datatable-responsive" data-idx="' + i + '" tabindex = "0" >' + i + '</a></li>';
            key = key + 1;
        }
        // next page
        // truong hop pageCount < 3
        // truong hop pageCount > 3


        // last page
        // truong hop pageCount < 3
        // truong hop pageCount > 3

        let disableFirstOne = "";

        if (currentPage - first <= 0) {
            disableFirstOne = "disabled";
        }

        let disableLastOne = "";

        if (pageCount - last <= 0) {
            disableLastOne = "disabled";
        }

        let firstOne = '<li class="paginate_button previous ' + disableFirstOne + '" id="datatable-responsive_previous"><a href = "javascript:void(0)" aria-controls="datatable-responsive" data-dt-idx="' + first + '" >‹</a></li>';

        let lastOne = '<li class="paginate_button previous ' + disableLastOne + '" id="datatable-responsive_previous"><a href = "javascript:void(0)" aria-controls="datatable-responsive" data-dt-idx="' + last + '" >›</a></li>';


        render = firstPage + firstOne + pageContent + lastOne + lastPage;

        return render;
    },
    showInfoPage: function (pageCurrent, pageSize, RowCount, elementSelector) {
        var from = (pageCurrent - 1) * pageSize;

        if (from <= 0) {
            from = 1;
        }

        var to = pageCurrent * pageSize;

        if (to > RowCount) {
            to = RowCount;
        }

        $(elementSelector).html("show " + from + " - " + to + " of " + RowCount);
    }
}