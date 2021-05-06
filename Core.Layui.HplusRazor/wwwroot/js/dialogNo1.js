; (function ($, widndow, document, undefind) {
    var defaltOption = {
        skin: 'mydialog',
        okValue: '确定',
        title: "提示信息",
        cancelValue: "取消",
        content: "",
        ok: undefined,
        cancel: undefined,
        url: undefined,
        padding: ' 20px 50px 20px 50px ',
        type: "error",
        data: ""
    }


    function getTitle(title) {
        if (!title || title.length < 1) {
            title = "提示信息"
        }
    }

    widndow.dialogNo1 = {
        //弹出框
        alert: function (option) {
            if (typeof option === "string") {
                option = { content: option }
            }
            option = $.extend({}, defaltOption, { skin: 'mydialog width-fexd' }, option);
            var outHtml = "<div class='" + option.type + "' >" + option.content + "</div>";
            option = $.extend({}, defaltOption, option)
            this.removeAllDialog();
            var d = dialog({
                title: option.title,
                skin: option.skin,
                padding: ' 20px 50px 10px 50px ',
                //cancelValue: option.cancelValue,
                //cancel: function () { },
                okValue: option.okValue,
                ok: function () {
                    return true;
                },
                content: outHtml
            }).showModal();
        },
        ///询问信息
        comfirm: function (option, myself) {
            this.removeAllDialog();
            if (typeof option === "string") {
                option = { content: option }
            }
            var outHtml = "";
            if (!myself) {
                outHtml = "<div class='confirm' >" + option.content + "</div>";
            } else {
                outHtml = option.content;
            }
            option = $.extend({}, defaltOption, option);
            dialog({
                title: option.title,
                skin: option.skin,
                padding: ' 20px 50px 20px 50px ',
                okValue: option.okValue,
                content: outHtml,
                ok: function () {
                    if (option.ok) {
                        return option.ok(option.data);
                    }
                },
                cancelValue: option.cancelValue,
                cancel: function () {
                    if (option.cancel) {
                        option.cancel(option.data);
                    }
                    return true;
                }
            }).showModal();
        },
        open: function (option) {
            if (typeof option === "string") {
                option = { url: option }
            }
            option = $.extend({}, { skin: 'mydialog frame' }, option)
            dialog(
                option
               ).showModal();
        },
        ///清楚所有弹出框
        removeAllDialog: function () {
            $(".ui-dialog-close").click();
        },
        popMsg: function (data, success) {
            var err=false;
            var content = "操作成功。";
            if (data) {
                if (typeof data === "string") {
                    content = data
                }
                if (success === false) {
                    content = "<i class='icon-remove' ></i> " + data;
                    err=true;
                } else {
                    content = "<i class='icon-ok' ></i> " + data;
                }
            } else {
                if (typeof data === "undefined") {
                    content = "<i class='icon-ok' ></i> " + content;
                } else {
                    content = "<i class='icon-remove' ></i> " + "操作失败！";
                    err=true;
                }
            }
            d = dialog({
                skin: 'mypop' + (err ? "-err" : ""),
                content: "<div class='pop-operate' > " + content + "</div>"
            }).show();
            setTimeout(function () {
                d.close().remove();
            }, 2000);
        }
    }

})(jQuery, window, document)



function myAlert(option) {
    dialogNo1.alert(option);
}
function myComfirm(option, myself) {
    dialogNo1.comfirm(option, myself);
}
function myOpen(option) {
    dialogNo1.open(option);
}


function loading() {
    myOpen({
        title: "正在努力加载···",
        width: 50,
        height: 50,
        url: "/Content/Scripts/js-loading/loading.gif",
        padding: '50px 100px 50px 100px',
    });
}

function closetips() {
    dialogNo1.removeAllDialog();
}

function MyAlertMsg(msg) {
    myAlert({
        title: "提示",
        fixed: true,
        content: msg
    });
}

function MyConfirmMsg(msg, callback) {
    myComfirm({
        title: "提示",
        width: 400,
        height: 400,
        fixed: true,
        content: msg,
        ok: function () { callback(); }
    });
}

