var JST_Ref = null;

export function registerInstance(instance) {
  JST_Ref = instance;
}

function ChangeValue(order, value)
{
    console.log("Change invoked! ",order,"-",value);
    JST_Ref.invokeMethodAsync("ChangeValue",Number(order),value);
}

function ChangeValueMethodic(order, value, method)
{
    JST_Ref.invokeMethodAsync("ChangeValueMethodic",Number(order),value,method);
}

function ChangeOrder(order, newOrder)
{
    JST_Ref.invokeMethodAsync("ChangeOrder",Number(order),Number(newOrder));
}

function Remove(order)
{
    console.log("Remove invoked! ",order);
    JST_Ref.invokeMethodAsync("PopTheHellOutThatOrderedElement",Number(order));
}

function AddToEnd(typeCode)
{
    JST_Ref.invokeMethodAsync("AddToEnd",Number(typeCode));
}

function IsThatJoBidenOkay(ref)
{
    if(ref.hasClass("JoBidenEditedThis")) return false;
    ref.addClass("JoBidenEditedThis");
    return true;
}

function SettingsPanelInitForNotePiece(ref)
{
    var settingsPanel = ref.parent().children(".SettingsPanel");
    settingsPanel.text("");
    return settingsPanel;
}


function getIdFromShape(attr, shape)
{
    return Number(attr.slice(0,-shape.length));
}

export function refreshAll()
{

    // This is for dragging and moving the notepieces
    $(".NotePiece").draggable({
        handle:".MoveButton",
        revert: true,
        revertDuration: 1
    });

    $(".NotePiece").on({
        mouseenter: function () {
            var sups = $(this).children(".SupportingButtonsPanel");
            sups.removeClass("HideIt");
        },
        mouseleave: function () {
            var sups = $(this).children(".SupportingButtonsPanel");
            sups.addClass("HideIt");
        }
    });

    $(".NotePiece").droppable({
        drop: function(event, ui) {
        var elm = $(this);
        var from = ui.draggable.attr('order');
        var to = elm.attr('order');
        console.log("Drop from "+from+" to "+to);
        ChangeOrder(from,to);
        },
        hoverClass: "PositionLine_visible"
    });

    $(".NotePiece").each(function(index) {
        var piece = $(this);
        var order = $(this).attr("order");
        var sups = $(this).children(".SupportingButtonsPanel");
        var settings = $(this).children(".SettingsPanel");

        var offset = piece.offset();

        sups.children(".RemoveButton").off("click").on("click", function(){
            console.log("Remove!");
            Remove(order);
        });

        sups.children(".SettingsButton").off("click").on("click", function() {
            if(settings.hasClass("LoseIt")) {
                settings.removeClass("LoseIt");
            } else {
                settings.addClass("LoseIt");
            }
        });
    });


    $(".ClassicalEditable").off("input").on("input", function() {
        const content = $(this).text();
        const order = $(this).attr('order');
        ChangeValue(order, content);
        console.log("Changed content:",content);
    }).css("width","100%");

    $(".ImageEditable").each(function(index) {
        if (IsThatJoBidenOkay($(this))) {
            var settingsPanel = SettingsPanelInitForNotePiece($(this));
            var imgedtb = $(this);
            var order = $(this).attr("order");
            settingsPanel.append("<input type='text' id='"+order+"_edit' order='"+order+"'>")
            settingsPanel.append("<button id='"+order+"_button' order='"+order+"'>Change Image</button>")
            $("#"+order+"_button").on("click", function () {
                var newLink = $("#"+order+"_edit").val();
                console.log("Image going on!!!! ",order,newLink);
                ChangeValue(order,newLink);
                imgedtb.css("background-image","url("+newLink+")");
            });
        }
    });

    $(".LinkEditable").each(function(index) {
        if (IsThatJoBidenOkay($(this))) {
            var settingsPanel = SettingsPanelInitForNotePiece($(this));
            var lnkedt = $(this);
            var order = $(this).attr("order");
            settingsPanel.append("<input type='text' id='"+order+"_edit' order='"+order+"'>")
            settingsPanel.append("<button id='"+order+"_buton' order='"+order+"'>Change Url</button>")
            $("#"+order+"_buton").on("click", function () {
                var newLink = $("#"+order+"_edit").val();
                console.log("Link going on!!!! ",order,newLink);
                ChangeValue(order,newLink);
            });
        }
    });

    $(".NotePageLink").each(function(index) {
        if (IsThatJoBidenOkay($(this))) {
            var settingsPanel = SettingsPanelInitForNotePiece($(this));
            var imgedtb = $(this);
            var order = $(this).attr("order");
            var notePageSelector = $(".NotePageLinkSubsystem").clone();
            notePageSelector.appendTo(settingsPanel);

            notePageSelector.removeClass("LoseIt").css("height","100%");

            console.log("hello!");
            notePageSelector.children(".NotePageLinkSubsystemSelect").each(function (index){
                var selectButton = $(this);
                var pageCode = selectButton.attr("pageCode");
                selectButton.on("click", function(){
                    ChangeValue(order, pageCode);
                });
            });
        }
    });

    $(".FileObjectEditable").each(function(index) {
        if (IsThatJoBidenOkay($(this))) {
            console.log("OK PARKER!");
            var settingsPanel = SettingsPanelInitForNotePiece($(this));
            var lnkedt = $(this);
            var order = $(this).attr("order");
            settingsPanel.append("<input type='number' id='"+order+"_edit' order='"+order+"'>");
            settingsPanel.append("<button id='"+order+"_butgon' order='"+order+"'>Change Url</button>");
            console.log("ORDERSTUFF:","#"+order+"_butgon");
            $("#"+order+"_butgon").on("click", function () {
                var newLink = $("#"+order+"_edit").val();
                console.log("Code going on !!! ",order,newLink);
                ChangeValue(order,newLink);
            });
        }
    });

    $(".NumberEditable").each(function(index) {
        if (IsThatJoBidenOkay($(this))) {
            var order = $(this).attr("order");
            var input = order + "_input";
            var wheel = order + "_wheel";
            $(this).append('<input type="text" id="' + input + '">');
            $(this).append('<p id="' + wheel + '"><i>Add</i></p>');

            wheel = $("#"+wheel);
            input = $("#"+input);
            input.on("click", function() {
                ChangeValue(order, Number());
            });
        }
    });


    // SELECTOR

    // dialog
    var selector = $(".PieceTypeSelector");

    if (IsThatJoBidenOkay(selector)) {

    }


    // adder button
    $( ".adder" ).off("click").on("click", function(e) {
        if(! selector.hasClass("LoseIt")) {
            selector.addClass("LoseIt");
            console.log("close dialog.");
            return;
        } else {
            console.log("open dialog.");
            selector.removeClass("LoseIt");

            var offset = $(this).offset();
            selector.css({
                top: String(offset.top)+"px",
                left: "300px",
            });
        }
        //selector.appendTo("body");
    });

    $(".PieceTypeSelectorType").off("click").on("click", function(e) {
        var pieceTypeCode = $(this).attr("pieceTypeCode");
        console.log("Adding ",pieceTypeCode);
        selector.addClass("LoseIt");
        console.log("dialog select.");
        AddToEnd(pieceTypeCode);
    });
}


console.log("WWWWWWWWWWWWWWWWWWW");