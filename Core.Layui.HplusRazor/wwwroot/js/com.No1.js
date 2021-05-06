/// <reference path="jquery-1.8.2.min.js" />

var email = "/^\w+((-\w+)|(\.\w+))*\@[A-Za-z0-9]+((\.|-)[A-Za-z0-9]+)*\.[A-Za-z0-9]+$/"; //邮箱

var zs = "/^-?\d+$/"; //整数

var zs1 = "/^[1-9]+(\.\d+)?|0\.{1}0?[1-9]+$/"; //正数

var zzs = "/^[0-9]*[1-9][0-9]*$/"; //正整数

var fds = "/^(-?\d+)(\.\d+)?$/"; //浮点数



var letter = "/^[A-Za-z]+$/"; //由26个英文字母组成的字符串

var url = "/^[a-zA-z]+://(\w+(-\w+)*)(\.(\w+(-\w+)*))*(\?\S*)?$/"; //url

var cn = "/[u4e00-u9fa5]/"; //中文

var r1 = "/^[a-zA-Z][a-zA-Z0-9_]{4,15}$/"; //匹配帐号是否合法(字母开头，允许5-16字节，允许字母数字下划线)

var tel = "/d{3}-d{8}|d{4}-d{7}/"; //匹配国内电话号码 匹配形式如 0511-4405222 或 021-87888822

var postcode = "/[1-9]d{5}(?!d)/"; //国内邮编

var ID = "/d{15}|d{18}/"; //中国的身份证为15位或18位

//以上正则，供参考

// 所有函数
// [ 0.执行正则表达式  ] Zz
// [ 1.获取文本框的值 - 去掉两边空格 -> TrimVal ]
// [ 2.设置readonly]  ReadOnly
// [ 3.移除readonly] RemoveReadOnly
// [ 4.判断是正整数(integer)] IsInteger
// [ 5.判断是小数(可以带小数位数，也可以不带)] IsDecimal
// [ 6.判断不能为空字符串（false - > ""/null/" "） ] NotNull
// [ 7.判断邮箱格式 ] IsEmail
// [ 8.转换json形式的日期格式为 yyyy-MM-dd ] JsonDate
// [ 9.密码为6-18位的数字和字母 ] IsPwd
// [ 10.列表中鼠标移上去某一行的颜色设置 ] HoverColor
// [ 11.Url跳转 ] UrlRedirect
// [ 12.全选/反选 ] check/uncheck
// [ 13.重置 ]    Reset
// [ 14.弹出一个新窗口 ] OpenUrl
// [ 15.编码 ] EnCode
// [ 16.解码 ] DeCode
// [ 99.其他 ]


var FixedValue = {
    TRUE: "TRUE"
};

$.No1 =
{
    Zz: function (val, reg) { return Zz(val, reg); },
    IsInteger: function (val) { return IsInteger(val); },
    IsDecimal: function (val) { return IsDecimal(val); },
    IsZDecimal: function (val) { return IsZDecimal(val); },
    NotNull: function (val) { return NotNull(val); },
    IsEmail: function (val) { return IsEmail(val); },
    JsonDate: function (val) { return JsonDate(val); },
    IsPwd: function (value) { return IsPwd(value); },
    UrlRedirect: function (url) { UrlRedirect(url); },
    OpenUrl: function (url) { OpenUrl(url); },
    Escape: function (val) { Escape(val); },
    UnEscape: function (val) { UnEscape(val); }
};

// [ 0.执行正则表达式  ]
function Zz(val, reg) {
    return null != val.match(reg);
}
// [ 1.获取文本框的值 - 去掉两边空格 ]
(function ($) {
    $.fn.Val = function (isTrim) {
        var v = $(this).val();
        if (isTrim)
            return $.trim(v);
        else
            return v;
    }
})(jQuery);

// [ 2.设置readonly ]
(function ($) {
    $.fn.ReadOnly = function () {
        return $(this).attr("readonly", "readonly").addClass("bdc1");
    }
})(jQuery);

// [ 3.移除readonly ]
(function ($) {
    $.fn.RemoveReadOnly = function () {
        return $(this).removeAttr("readonly").removeClass("bdc1");
    }
})(jQuery);

// [ 4.判断是正整数(integer) ]

function IsInteger(val) {
    var reg = /^\d*$/;
    return null != val.match(reg);
}

(function ($) {
    $.fn.IsInteger = function () {
        return IsInteger($(this).val());
    }
})(jQuery);

function IsZInteger(val) {
    var reg = /^[1-9]+\d*$/;
    return null != val.match(reg);
}

(function ($) {
    $.fn.IsZInteger = function () {
        return IsZInteger($(this).val());
    }
})(jQuery);


// [ 5.判断是小数(可以带小数位数，也可以不带) ]

function IsDecimal(val) {
    var reg = /^\d+(\.{0,1}\d+)?$/;
    return null != val.match(reg);
}

(function ($) {
    $.fn.IsDecimal = function () {
        return IsDecimal($(this).val());
    }
})(jQuery);

// [ 5.1判断是小数(可以带小数位数，也可以不带) ]

function IsZDecimal(val) {
    var reg = /(^[1-9][0-9]*\.[0-9]+)$|(^0\.[0-9]+$)|(^[1-9][0-9]*$)|^0$/;
    return null != val.match(reg);
}

(function ($) {
    $.fn.IsZDecimal = function () {
        return IsZDecimal($(this).val());
    }
})(jQuery);

// [ 6.判断不能为空字符串（false - > ""/null/" "） ]
function NotNull(val) {
    return null != val && $.trim(val).length > 0;
}

(function ($) {
    $.fn.NotNull = function () {
        return NotNull($(this).val());
    }
})(jQuery);

// [ 7.判断邮箱格式 ]
function IsEmail(val) {
    var reg = /^(\w_?-?)+(\.\w+)*@(\w-?_?)+((\.\w+)+)$/;
    var s = val.match(reg);
    return null != val.match(reg);
}

(function ($) {
    $.fn.IsEmail = function () {
        return IsEmail($.trim((this).val()));
    }
})(jQuery);

// [ 7.判断邮政编码 ]var postcode = "/[1-9]d{5}(?!d)/"; //国内邮编
function IsPostCode(val) {
    var reg = /^\d{6}$/;
    return null != val.match(reg);
}

(function ($) {
    $.fn.IsPostCode = function () {
        return IsPostCode($(this).val());
    }
})(jQuery);

// [ 7.判断是否包含字母 ]var postcode = "/[1-9]d{5}(?!d)/"; //国内邮编
function IsSingnByte(val) {
    var regExp = /^[a-zA-Z]*$/;
    if (!regExp.test(val)) {
        return false;
    }
    return true;
}

(function ($) {
    $.fn.IsSingnByte = function () {
        return IsSingnByte($(this).val());
    }
})(jQuery);


// [ 7.判断是否包含字母 ]var postcode = "/[1-9]d{5}(?!d)/"; //国内邮编
function IsCodeOrNumberByte(val) {
    val = $.trim(val);
    var regExp = /^([a-zA-Z]|[0-9])*$/;
    if (!regExp.test(val)) {
        return false;
    }
    return true;
}

(function ($) {
    $.fn.IsCodeOrNumberByte = function () {
        return IsCodeOrNumberByte($(this).val());
    },
     $.fn.setCode = function () {
         $(this).keyup(function () {
             this.value = this.value.replace(/[^\d]/g, '');
         });
     }
})(jQuery);


// [ 8.转换json形式的日期格式为 yyyy-MM-dd ]
function p(s) {
    return s < 10 ? '0' + s : s;
}


function JsonDate(str) {
    if (null != str && str != "" && str != "undefined") {
        var matches = str.match(/([0-9]+)/);
        var d = parseInt(matches[0]);
        var obj = new Date(d);
        var year = obj.getFullYear();
        var month = obj.getMonth() + 1;
        var day = obj.getDate();
        var sec = obj.getSeconds();
        var mytime = year + "-" + p(month) + "-" + p(day) + " " + p(obj.getHours()) + ":" + p(obj.getMinutes()) + ":" + p(sec);
        return mytime;
    }
}

//[ 9.密码为6-18位的数字和字母 ]
function IsPwd(value) {
    var reg = /^[a-z0-9A-Z]{6,18}$/;
    return null != value.match(reg);
}
(function ($) {
    $.fn.IsPwd = function () {
        return IsPwd($(this).val());
    }
})(jQuery);


(function ($) {
    $.fn.CheckLength = function () {
        var objStr = $(this);
        objlength = GetLength($.trim(objStr.val()));
        if (objlength > objStr.attr("maxlength")) {
            return false;
        } else {
            return true;
        }
    }
})(jQuery);


function GetLength(str) {
    var realLength = 0, len = str.length, charCode = -1;
    for (var i = 0; i < len; i++) {
        charCode = str.charCodeAt(i);
        if (charCode >= 0 && charCode <= 128) realLength += 1;
        else realLength += 2;
    }
    return realLength;
};


// [ 10.列表中鼠标移上去某一行的颜色设置 ]
(function ($) {
    $.fn.HoverColor = function (hoverclass) {
        $(this).hover(function () {
            $(this).addClass(hoverclass)
        }, function () {
            $(this).removeClass(hoverclass)
        });
    }
})(jQuery);

// [ 11.Url跳转 ]
function UrlRedirect(url) {
    top.widow.location = url;
}

// [ 12.全选/反选 ]
jQuery.fn.extend({
    check: function () {
        return this.each(function () { this.checked = true; });
    },
    uncheck: function () {
        return this.each(function () { this.checked = false; });
    }
});
// [ 13.重置 ]
(function ($) {
    $.fn.Reset = function () {
        $c = $(this).parentsUntil("form");
        $c.find("input:text,input:password,textarea").val("");
        $c.find("select").each(function (i) {
            $(this).find("option:eq(0)").prop("selected", "selected").change();
        });

        $("form").find("select").each(function () {
            $(this).find("option:first").prop("selected", "selected").change();
        });

    }
})(jQuery);

// [ 14.弹出一个新窗口 ]

function OpenUrl(url) {
    window.open(url);
}

// [ 15.编码 ]
function Escape(val) {
    escape(val);
}

// [ 16.解码 ]
function UnEscape(val) {
    unescape(val);
}

// [ 17.复制到剪贴板 ]
function CopyToClipboard(txt) {

    if (window.clipboardData) {

        window.clipboardData.clearData();

        window.clipboardData.setData("Text", txt);

        alert("已经成功复制到剪帖板上！");

    } else if (navigator.userAgent.indexOf("Opera") != -1) {

        window.location = txt;

    } else if (window.netscape) {

        try {

            netscape.security.PrivilegeManager.enablePrivilege("UniversalXPConnect");

        } catch (e) {

            alert("被浏览器拒绝！\n请在浏览器地址栏输入'about:config'并回车\n然后将'signed.applets.codebase_principal_support'设置为'true'");

        }

        var clip = Components.classes['@mozilla.org/widget/clipboard;1'].createInstance(Components.interfaces.nsIClipboard);

        if (!clip) return;

        var trans = Components.classes['@mozilla.org/widget/transferable;1'].createInstance(Components.interfaces.nsITransferable);

        if (!trans) return;

        trans.addDataFlavor('text/unicode');

        var str = new Object();

        var len = new Object();

        var str = Components.classes["@mozilla.org/supports-string;1"].createInstance(Components.interfaces.nsISupportsString);

        var copytext = txt;

        str.data = copytext;

        trans.setTransferData("text/unicode", str, copytext.length * 2);

        var clipid = Components.interfaces.nsIClipboard;

        if (!clip) return false;

        clip.setData(trans, null, clipid.kGlobalClipboard);

        alert("已经成功复制到剪帖板上！");

    }
}



// [ 99.其他 ]  
String.prototype.trim = function () {
    return this.replace(/(^\s*)|(\s*$)/g, "");
}
String.prototype.ltrim = function () {
    return this.replace(/(^\s*)/g, "");
}
String.prototype.rtrim = function () {
    return this.replace(/(\s*$)/g, "");
}


function HotKey() {
    var a = window.event.keyCode;
    if ((a == 49) && (event.ctrlKey)) {
        var newwin = window.open("/Help", "_blank");
        //        newwin.moveTo(0, 0)
        //        newwin.location = "/Help"
        //        newwin.focus();
    }
}

// 初始化加载
//$(document).ready(function () {
//    //$("input[name='reset']").click(function () { $("[id='reset']").Reset(); });
//    //$(".Hover > tbody tr").HoverColor("bgc1");
//    document.onkeydown = HotKey;
//});


(function ($) {
    $.fn.FocusChange4Label = function (defaultVal) {
        var $input = $(this);
        var id = $input.attr("id");

        //$input.focus(function () {
        //    var val = $.trim($input.val());
        //    if (val != defaultVal)
        //        $("label[for='" + id + "']").text("");
        //    else
        //        $("label[for='" + id + "']").text(defaultVal);
        //});
        $input.keydown(function () {
            $("label[for='" + id + "']").text("");
        });

        //失去焦点
        $input.blur(function () {
            var curVal = $.trim($input.val());
            if (curVal == "") {
                $("label[for='" + id + "']").text(defaultVal);
            }
            else {
                $("label[for='" + id + "']").text("");
            }
        });
    }
})(jQuery);

var isIE = "W";
function getBrowserInfo() {
    if (isIE == "W") {
        var agent = navigator.userAgent.toLowerCase();
        var regStr_ie = /msie [\d.]+;/gi;
        var regStr_ff = /firefox\/[\d.]+/gi
        var regStr_chrome = /chrome\/[\d.]+/gi;
        var regStr_saf = /safari\/[\d.]+/gi;
        //IE
        if (agent.indexOf("msie") > 0) {
            if (navigator.userAgent.indexOf("MSIE 6.0") > 0) {
                isIE = "Y";
            } else if (navigator.userAgent.indexOf("MSIE 7.0") > 0) {
                isIE = "Y";
            } else if (navigator.userAgent.indexOf("MSIE 8.0") > 0) {
                isIE = "Y";
            } else if (navigator.userAgent.indexOf("MSIE 9.0") > 0) {
                isIE = "Y";
            } else {
                isIE = "N";
            }
        } else {
            isIE = "N";
        }
        return isIE;
    }
}



(function ($) {
    $.fn.setTipValue = function (strDf) {
        getBrowserInfo();
        if (isIE == "Y") {
            var $input = $(this);
            var id = $input.attr("id");
            $("#lt_" + id).remove();
            $input.after("<span  class='df1' id='lt_" + id + "'  >" + strDf + "</span>")
            $lt = $("#lt_" + id);
            if (navigator.userAgent.indexOf("MSIE 6.0") > 0) {//如果为IE6设置宽度 方式提示信息不能完全显示
                $lt.width(strDf.length * 13);
            }
            function resetPosition() {
                $lt.offset({
                    top: $input.offset().top + $input.height() / 2 - 5,
                    left: $input.offset().left + 5
                });
                $lt.css({
                    display: "block",
                    visibility: "visible"
                });
            }

            resetPosition();
            if ($.trim($input.val()) < 1) {
                $lt.show();
            } else {
                $lt.hide();
            }

            $lt.click(function () {
                $input.focus();
            });

            $input.keydown(function () {
                $("#lt_" + id).text("");
                $("#lt_" + id).hide();
            });

            $input.change(function () {
                var curVal = $.trim($(this).val());
                ShowLaber(curVal)
            });

            //失去焦点
            $input.blur(function () {
                var curVal = $.trim($(this).val());
                ShowLaber(curVal)
            });

            $input.focus(function () {
                $("#lt_" + id).text("");
                $("#lt_" + id).hide();
            })

            function ShowLaber(curVal) {
                if (curVal.length < 1) {
                    $("#lt_" + id).text(strDf);
                    $("#lt_" + id).show();
                }
                else {
                    $("#lt_" + id).text("");
                    $("#lt_" + id).hide();
                }
            }
        } else {
            $(this).attr("placeholder", strDf);
        }
    }
})(jQuery);

if (navigator.userAgent.indexOf("MSIE 6.0") > 0
    || navigator.userAgent.indexOf("MSIE 7.0") > 0
    || navigator.userAgent.indexOf("MSIE 8.0") > 0 ||
    navigator.userAgent.indexOf("MSIE 9.0") > 0) {
    window.onresize = function () {
        changeTipLaber();
    }
}

//当浏览器窗口大小改变时，设置显示内容的高度   


function changeTipLaber() {
    $(".df1").each(function () {
        var tId = $(this).attr("id").replace(/^lt_/g, "");
        var $input = $("#" + tId);
        $(this).offset({
            top: $input.offset().top + $input.height() / 2 - 5,
            left: $input.offset().left + 5
        });
    });
}



(function ($) {
    $.fn.Hover = function (hoverClass) {
        var $tabl = $(this);
        $tabl.find("tr:even").css("background-color", "#ffffff");
        $tabl.find("tr:odd").css("background-color", "#F8F8F8");
        $tabl.find("tbody tr").hover(
          function () {
              $(this).addClass(hoverClass);
          },
          function () {
              $(this).removeClass(hoverClass);
          }
        );
    }
})(jQuery);

(function ($) {
    $.fn.Error = function (message) {
        var html = "<span id='spanMessage' style=' border: 1px solid #FF8000; margin-left:10px; color: red; padding: 3px 20px 5px; '>" + message + "</span>";
        html += "<script type=\"text/javascript\">setTimeout(function () {$(\"#spanMessage\").animate({ opacity: \"hide\" }, \"slow\");}, 2000)</script>";
        $(this).html(html);

    }
})(jQuery);


(function ($) {
    $.fn.SetFixed = function () {
        var $this = $(this);
        var dTop = $this.offset().top;
        if (dTop < 0) {
            dTop = 0;
        }
        var $top = $("#totop");
        window.onscroll = function () {
            var scrolltop = $(document).scrollTop() - 55;
            if (navigator.userAgent.indexOf("MSIE 6.0") > 0
               || navigator.userAgent.indexOf("MSIE 7.0") > 0
                ) {
                if (dTop < scrolltop) {
                    $this.offset({ top: $(document).scrollTop() });
                } else {
                    $this.offset({ top: dTop });
                }
            } else {
                if (dTop < scrolltop) {
                    $this.css("position", "fixed").css("top", "0px");
                } else {
                    $this.css("position", "absolute").css("top", "0px");
                }
            }

            var scrolltop1 = $(this).scrollTop();
            if (scrolltop1 >= 150) {
                $top.show();
            }
            else {
                $top.hide();
            }
            // alert(scrolltop);
        }
    };

    $.fn.addSpace = function (len) {
        $thisS = $(this);
        var pSpace = "";
        if (len) {
            for (var i = 0; i < len; i++) {
                pSpace += "&nbsp;";
            }
        } else {
            pSpace += "&nbsp;&nbsp;&nbsp;&nbsp;";
        }
        for (var i = 0; i < $thisS.length; i++) {
            var text = $thisS[i].innerHTML;
            if (/^ /.test(text)) {
                $thisS[i].innerHTML = text.replace(/^ +/, "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;");
            }
        }
    };
})(jQuery);

$.extend({
    loading: function () {
        $loading = $("#divLoading");
        if (!$loading || $loading.length < 1) {
            var outHtml = '<div  id="divLoading"  style="cursor: wait; position:absolute;  left: 45%; top:45%; width: auto; height: 57px; line-height: 57px; padding-left: 50px; padding-right: 50px; background: #fff url(/Content/Scripts/Js-loading/loading.gif) no-repeat scroll 5px 10px; border: 2px solid #95B8E7; color: #696969; font-family:\'Microsoft YaHei\';">'
                        + '页面加载中，请等待...</div>';
            $("body").append(outHtml);
        }
        $loading.show();
    },
    loadingClose: function () {
        $("#divLoading").hide();
    }
});
