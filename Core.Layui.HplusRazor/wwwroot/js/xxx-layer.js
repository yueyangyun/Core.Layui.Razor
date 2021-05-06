


//$.mylayer.confirm("ok", ok);
//$.mylayer.result("success.", true);
//$.mylayer.result("fail.", false);

$.mylayer =
{
    confirm: function (msg, okCallback, cancelCallback) { layerConfirm(msg, okCallback, cancelCallback); }
    , result: function (msg, success) { layerSuccess(msg, success); }
    , resultSuccess: function (msg) { layerSuccess(msg); }
    , resultFail: function (msg) { layerFail(msg); }
    , open: function (url, title, width, height) { open(url, title, width, height); }
};
function layerLoad() {
    var index = layer.load(1, {
        shade: [0.1, '#fff'] //0.1透明度的白色背景
    });
}

function layerConfirm(msg, okCallback, cancelCallback) {
    layer.confirm(msg, {
        btn: ['Confirm', 'cancel'] //按钮
        , title: 'Tips'
    }, function () {
        okCallback();
        layer.closeAll();
    }, function () {
        cancelCallback();
        layer.closeAll();
    });
}

//提示警告
function layerAlter(msg) {
    layer.closeAll();
    layer.alert(msg, { icon: 0, time: 5000, btn: ['OK'] });
}
//提示成功
function layerSuccess(msg, tips) {
    layer.closeAll();
    layer.alert(msg, { icon: 1, title: tips, time: 2000, btn: ['OK'] });
}
//提示失败
function layerFail(msg, tips) {
    layer.closeAll();
    layer.alert(msg, { icon: 2, title: tips, btn: ['OK'] });//, time: 5000 
}


function del(url, id) {
    layerConfirm("Confirm delete?", function () {
        $.get(url + "?id=" + id, function () {
            tableRender();//getPager(1);
        });
    },
        function () {
        }, () => { });
}

function delWithResult(url, id, msg) {
    //debugger
    layerConfirm(msg == undefined ? "Confirm delete？" : msg, function () {
        $.post(url, { id }, function (result) {
            if (result.success) {
                $.mylayer.resultSuccess('Sucess！');
                tableRender();
            }
            else {
                if (result.message) {
                    layerAlter(result.msg, false);
                }
                else {
                    layerAlter('Fail，Please refresh and try again！', false);
                }

            }
        });
    }, function () {
    }, () => { });
}

//width height 支持 %百分比 和 px 像素
function open(url, title, width = '60%', height = '60%', IsScroll = false) {
    var scroll = 'no';
    if (IsScroll)
        scroll = 'yes';
    //通过这种方式弹出的层，每当它被选择，就会置顶。
    var index = layer.open({
        type: 2
        , shade: 0.2 //遮罩透明度
        , shadeClose: true
        , maxmin: true //允许全屏最小化
        , anim: 0 //0-6的动画形式，-1不开启
        , area: [width, height]
        , title: title
        , content: url
    });
}


//function open(url, title, IsScroll = false) {
//    var scroll = 'no';
//    if (IsScroll)
//        scroll = 'yes';
//    //通过这种方式弹出的层，每当它被选择，就会置顶。
//    parent.layer.open({

//        type: 2,
//        title: title,
//        shade: [0.01, "#255,255,255"],
//        shadeClose: true,
//        offset: '60px',
//        area: '70%', //控制页面大小
//        moveOut: true,
//        maxmin: true,
//        content: [url, scroll],//去掉滚动条
//        scrollbar: false,
//        zIndex: layer.zIndex, //重点1

//        success: function (layero, index) {
//            layer.setTop(layero); //重点2
//            layer.iframeAuto(index)

//        }
//    });
//}



