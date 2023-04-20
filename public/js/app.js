// Handling filter buttons & field

$('#pt').on('click', () => {
    $('#pt').addClass("selectedmodulebutton");
    $('#pt').removeClass("unselectedmodulebutton");
    $('#re').addClass("unselectedmodulebutton");
    $('#re').removeClass("selectedmodulebutton");

    $('#filtertext').attr("placeholder", " mega.nz")
})

$('#re').on('click', () => {
    $('#re').addClass("selectedmodulebutton");
    $('#re').removeClass("unselectedmodulebutton");
    $('#pt').addClass("unselectedmodulebutton");
    $('#pt').removeClass("selectedmodulebutton");

    $('#filtertext').attr("placeholder", " ([A-Z])\w+")
})

// Handling appearance options

$('#li').on('click', () => {
    $('#li').addClass("selectedmodulebutton");
    $('#li').removeClass("unselectedmodulebutton");
    $('#da').addClass("unselectedmodulebutton");
    $('#da').removeClass("selectedmodulebutton");
})

$('#da').on('click', () => {
    $('#da').addClass("selectedmodulebutton");
    $('#da').removeClass("unselectedmodulebutton");
    $('#li').addClass("unselectedmodulebutton");
    $('#li').removeClass("selectedmodulebutton");
})

// Handling module selection

$('#rentry_co').on('click', () => {
    if ($('#rentry_co').attr("class") === "selectedmodulebutton") {
        $('#rentry_co').addClass("unselectedmodulebutton");
        $('#rentry_co').removeClass("selectedmodulebutton");
    } else {
        $('#rentry_co').addClass("selectedmodulebutton");
        $('#rentry_co').removeClass("unselectedmodulebutton");
    }
})

$('#pasteall_org').on('click', () => {
    if ($('#pasteall_org').attr("class") === "selectedmodulebutton") {
        $('#pasteall_org').addClass("unselectedmodulebutton");
        $('#pasteall_org').removeClass("selectedmodulebutton");
    } else {
        $('#pasteall_org').addClass("selectedmodulebutton");
        $('#pasteall_org').removeClass("unselectedmodulebutton");
    }
})

$('#paste_in').on('click', () => {
    if ($('#paste_in').attr("class") === "selectedmodulebutton") {
        $('#paste_in').addClass("unselectedmodulebutton");
        $('#paste_in').removeClass("selectedmodulebutton");
    } else {
        $('#paste_in').addClass("selectedmodulebutton");
        $('#paste_in').removeClass("unselectedmodulebutton");
    }
})

$('#paste_ee').on('click', () => {
    if ($('#paste_ee').attr("class") === "selectedmodulebutton") {
        $('#paste_ee').addClass("unselectedmodulebutton");
        $('#paste_ee').removeClass("selectedmodulebutton");
    } else {
        $('#paste_ee').addClass("selectedmodulebutton");
        $('#paste_ee').removeClass("unselectedmodulebutton");
    }
})