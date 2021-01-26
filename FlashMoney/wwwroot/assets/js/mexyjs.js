inpformat();

function inpformat() {
  
    //$("form input#examdate").each(function (index) {
    //    debugger
    //    // $(this).attr("id", "cleave-date-" + index);
    //    var cleave = new Cleave("#examdate", {
    //        //date: true,
    //        delimiters: ['/', '/', ' ', ':'],
    //        blocks: [2, 2, 4, 2, 2]
    //    });
    //})
    var cleave = new Cleave('#examduration', {
        time: true,
        timePattern: ['h', 'm']
    });
}

$('#examrequired').on('click', function (e) {
    $("body div#examdependent").prop("hidden", false);
    $("body div#examdependent2").prop("hidden", true);
    $("body div#examdependent.test").prop("hidden", true);
})

$('#noexamrequired').on('click', function (e) {
    $("body div#examdependent").prop("hidden", true);
    $("body div#examdependent2").prop("hidden", false);
})

$('#dntprovide').on('click', function (e) {
    $("body div#examdependent.test").prop("hidden", false);
})

$('#provide').on('click', function (e) {
    $("body div#examdependent.test").prop("hidden", true);
 
})

$('#selprocess').on('change', function (e) {
    debugger
    var selected = $('#selprocess').val();
    if (selected==1) {
        $('body div#selUpload').prop("hidden", true);
    } else if (selected == 2 || selected==3) {
        $('body div#selUpload').prop("hidden", false);
    }
    
})
$('#amteach').on('blur', function (e) {
   
    var num = $('#appno').val();
    var amt = $('#amteach').val();
    amt = amt.replace(',', '');
    amt = amt.replace(',', '');
    amt = amt.replace(',', '');
    amt = amt.replace(',', '');
    amt = amt.replace(',', '');
    amt = amt.replace(',', '');
    $('#totamount').val(totamt);
    if (num != null && num != "" && amt!=null && amt!="") { 
        num = parseInt(num);
        amt = parseFloat(amt);
        var totamt = num * amt;
        $('#totamount').val(totamt);
        var cleave = new Cleave('#totamount', {
            numeral: true,
            numeralThousandsGroupStyle: 'thousand'
        });
    }
})
var cleave = new Cleave('#amteach', {
    numeral: true,
    numeralThousandsGroupStyle: 'thousand'
});
$('#appno').on('blur', function (e) {
    debugger
    var num = $('#appno').val();
    var amt = $('#amteach').val();
    amt = amt.replace(',', '');
    amt = amt.replace(',', '');
    amt = amt.replace(',', '');
    amt = amt.replace(',', '');
    amt = amt.replace(',', '');
    amt = amt.replace(',', '');
    $('#totamount').val(totamt);
    if (num != null && num != "" && amt != null && amt != "") {
        num = parseInt(num);
        amt = parseFloat(amt);
        var totamt = num * amt;
        $('#totamount').val(totamt);
        var cleave = new Cleave('#totamount', {
            numeral: true,
            numeralThousandsGroupStyle: 'thousand'
        });
    }
    
})
