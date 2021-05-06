/// <reference path="./dialogNo1.js" />

$(function () {
    $("#btnSearch").click(function () { getPager(1); });
    $("#btnReset").click(function () { $(this).Reset(); });
    $("#btnSave").click(function () { submit(); });
    $("#btnAdd").click(function () {
        let title = "";
        if (this.getAttribute('title') == null) {
            title = "Add";
        }
        else {
            title = this.getAttribute('title');
        }
        myOpen(
            {
                title: title,
                width: pageConfig.AddWidth,
                height: pageConfig.AddHeight,
                url: pageConfig.Add
            }
        );
    });
});


function submit() {
    $("form").submit();
}

function edit(url, title) {
    if (title == null) {
        title = "Update";
    }
    myOpen({
        title: title,
        width: pageConfig.ModifyWidth,
        height: pageConfig.ModifyHeight,
        url: url
    });
}

// 提交并且继续/返回
function submitThen(control) {
    $("#SubmitControl").val($(control).attr("name"));
    $("form").submit();
}

function getPager(pageIndex) {
    $.post(pageConfig.ListPager + "?pageIndex=" + pageIndex, $("form").serialize(), function (partialView) {
        $("#divPager").html(partialView);
    });
}


function successAnimate(success) {
    if (success.toUpperCase() == FixedValue.TRUE) {
        $("#SuccessMsg").animate({ opacity: 0 }, 8000);
    }
}

function deleteById(url, id) {
    MyConfirmMsg("Confirm Delete ？", function () {
        $.post(url, { Id: id }, function (data) {
            if (data.Success) {
                dialogNo1.popMsg("Delete Success。");
                getPager(1);
            }
            else {
                dialogNo1.popMsg("Delete Fail ！", false);
            }
        }, "json");
    });
}


// HPlus 点击 按钮 打开一个新页面
function page(url, title) {
    var nav = $(window.parent.document).find('.J_menuTabs .page-tabs-content ');
    $(window.parent.document).find('.J_menuTabs .page-tabs-content ').find(".J_menuTab.active").removeClass("active");
    $(window.parent.document).find('.J_mainContent').find("iframe").css("display", "none");
    var iframe = '<iframe class="J_iframe" name="iframe10000" width="100%" height="100%" src="' + url + '" frameborder="0" data-id="' + url
        + '" seamless="" style="display: inline;"></iframe>';
    $(window.parent.document).find('.J_menuTabs .page-tabs-content ').append(
        ' <a href="javascript:;" class="J_menuTab active" data-id="' + url + '">' + title + ' <i class="fa fa-times-circle"></i></a>');
    $(window.parent.document).find('.J_mainContent').append(iframe);
}

function closeTab_Active() {
    $(".J_menuTab.active", window.top.document).find(".fa.fa-times-circle").click();
}