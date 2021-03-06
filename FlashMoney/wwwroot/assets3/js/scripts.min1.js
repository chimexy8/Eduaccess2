var mPoint = 768;
var actionView = true;
var MinFundAmount = 100;

$(function () {
    $.ajaxSetup({
        error: function (jqXHR, textStatus, errorThrown) {
            if (jqXHR.status === 401) {
                location.reload(true);
            } else {
                $('.modal').modal('hide');
                $('#modal-catch-errors .errorWrap').removeClass('.d-none');
                if (textStatus) {
                    $('#modal-catch-errors .errorText').text(textStatus + ' ( ' + jqXHR.status + ' )');
                } else if (errorThrown) {
                    $('#modal-catch-errors .errorText').text(errorThrown + ' ( ' + jqXHR.status+' )');
                } else {
                    $('#modal-catch-errors .errorWrap').addClass('.d-none');
                }
                $('#modal-catch-errors').modal('show');
            }
        }
    });


  $(".dropdown-toggle").dropdown();
  $('[data-toggle="tooltip"]').tooltip();

  //Admin Menu
    $(".open-trigger").click(function (e) {


    e.preventDefault();
    if ($(window).width() > 1024) {
      $(".page .sidebar").toggleClass("nav-shrinked");
    } else {
      $(".page .sidebar").toggleClass("nav-opened");
    }
  });

  $(window).resize(function (e) {
    $(".page .sidebar")
      .removeClass("nav-opened")
      .removeClass("nav-shrinked");
  });

    $('.main .auth').on('click', '.toggle_pwd_field', function (e) {
        var x = $(this).siblings('.home_pwd_in_box');
        if (x.attr("type") === "password") {
            x.attr("type", "text");
            
        } else {
            x.attr("type", "password");
        }
        $(this).find('.icon').toggleClass('d-none');
    });
    

  //Landing Form
  setFormPosition();
  setBgPosition();
  $(window).resize(function (e) {
    setFormPosition(); setBgPosition();
  })

  $(window).scroll(function (e) {
    if ($(window).width() > mPoint && $(".home .info .how-info").length > 0) {
      var howTop = $(".home .info .how-info").offset().top - 800;
      var scrollTop = $(window).scrollTop();
      if (scrollTop > howTop) {
        $(".home .auth").css({
          top: (140 + howTop),
          position: "absolute"
        });
      }
      else {
        $(".home .auth").css({
          top: 140,
          position: "fixed"
        });
      }
    }
  })

  //Landing Scroll Btn
  $(".home .intro .btn-round").click(function (e) {
    e.preventDefault();

    var _top = $(".home .info").offset().top + 100;

    $("html,body").animate({
      scrollTop: _top
    })
  })

  //Input Index Adjust
  $(".input.password-check input").focus(function () {
    $(".input").removeClass("elevate");
    $(this).parent().addClass("elevate");
  })

    $(".form-card .page-reload").click(function (e) {
        e.preventDefault();
        e.stopPropagation();
        location.reload(true);
    })
  //Home Form Movement
    
    //$(".form-card .form-link").click(function (e) {
    $('.m-content-wrap').on('click', '.form-card .form-link', function (e) {
    e.preventDefault();
      e.stopPropagation();
      //debugger
    var idLink = $(this).data("link");
    var option = $(this).data("option");
      $(this).parents(".m-content-wrap").find(".form-card .form-section").removeClass("active");
    if (idLink === "alert") {
        $(this).parents(".m-content-wrap").find(".form-card .form-section." + idLink).removeClass("success");
        $(this).parents(".m-content-wrap").find(".form-card .form-section." + idLink).removeClass("error");
        $(this).parents(".m-content-wrap").find(".form-card .form-section." + idLink).addClass("active " + option);
    }
    else if (option === "load") {
        $(this).parents(".m-content-wrap").find(".form-card .form-section.loading").addClass("active");
      setTimeout(function (e) {
          $(this).parents(".m-content-wrap").find(".form-card .form-section").removeClass("active");
          $(this).parents(".m-content-wrap").find(".form-card .form-section." + idLink).addClass("active");
      }, 3000);
    }
    else {
        $(this).parents(".m-content-wrap").find(".form-card .form-section." + idLink).addClass("active");
    }
  })


  //Overview Promotion Slide
  if ($(".promo-slide").length > 0) {
    $(".promo-slide").slick({
      dots: false,
      infinite: false,
      fade: true,
      slidesToShow: 1,
      prevArrow: '<a class="arrow-prev"><i class="icon auto"><svg width="10" height="14" viewBox="0 0 10 14" fill="none" xmlns="http://www.w3.org/2000/svg"><path d="M9.99805 1.63895L4.431 6.95456L9.99805 12.2701L8.28157 13.9091L0.998047 6.95456L8.28157 0L9.99805 1.63895Z" fill="#5D2684"/></svg></i></a>',
      nextArrow: '<a class="arrow-next"><i class="icon auto"><svg width="9" height="14" viewBox="0 0 9 14" fill="none" xmlns="http://www.w3.org/2000/svg"><path d="M0 12.361L5.56705 7.04544L0 1.72986L1.71647 0.09091L9 7.04544L1.71647 14L0 12.361Z" fill="#5D2684" /></svg></i></a>',
    })
  }

  //Overview Action Toggle
  $(".admin .overview .action-trigger").click(function (e) {
    e.preventDefault();
    if (!actionView) {
      $(this).addClass("hide");
      $(".admin .overview .content-action").removeClass("hide");
    }
    actionView = true;
  })
  $(".admin .overview .content-action .action-close").click(function (e) {
    e.preventDefault();
    if (actionView) {
      $(".admin .overview .content-action").addClass("hide");
      $(".admin .overview .action-trigger").removeClass("hide");
    }
    actionView = false;
  })

  if ($(window).width() <= mPoint) {
    actionView = false;
    $(".admin .overview .action-trigger").removeClass("hide");
    $(".admin .overview .content-action").addClass("hide");
  }

  //Load Overview Charts
  loadCharts();

    /*if ($('#Pin').val() !== "") {
    
        var p = $('#Pin').val();
        $('#UsersNewPin').html(p);
        $('#modal-auth-generate').modal('toggle');
    }*/


    //Overview Fund File Upload
    if ($("#modal-fund-trn-multiple").get(0) != null) {
        
        //$(".fund-trn-file-template .select-list .upload-btn").click(function (e) {
        //    debugger
        $("#modal-fund-trn-multiple").on("click", ".fund-trn-file-template .select-list .upload-btn", function (e) {
            e.preventDefault();
            $(".fund-trn-file-template .file-input").trigger("click");
        })

        //$(".fund-trn-file-template .file-input").change(function (e) {
        $("#modal-fund-trn-multiple").on("change", ".fund-trn-file-template .file-input", function (e) {
            var fInputEle = $('this');
            fInputEle.parents('.form-section.fund-trn-file-template').find('.error_message').text("");
            //var file = e.target.files[0];
            var file = this.files[0];
            if (file !== null) {
                //debugger
                console.log(file.type);
                filename = file.name;
                var ext = filename.split('.').pop().toLowerCase();
                if (file.type.match("application.*") || file.type.match("text/csv") || ext == "csv" || ext == "xlsx" || ext == "xls") {

                    var formData = new FormData();
                    formData.append('file', file);
                    //debugger
                    $("#modal-fund-trn-multiple .form-card .form-section").removeClass("active");
                    $("#modal-fund-trn-multiple .form-card .form-section.loading").addClass("active");

                    $.ajax({
                        url: '/Transaction/UploadCSV',
                        type: 'POST',
                        data: formData,
                        processData: false,
                        contentType: false,
                        success: function (data) {
                            $("#modal-fund-trn-multiple .modal-content").html(data);
                        },
                        error: function (jqXHR, textStatus, errorThrown) {
                            if (jqXHR.status === 401) {
                                location.reload(true);
                            }
                            $("#modal-fund-trn-multiple .form-card .form-section.loading").removeClass("active");
                            $("#modal-fund-trn-multiple .form-card .form-section .fund-trn-file-template").addClass("active");
                            fInputEle.parents('.form-section.fund-trn-file-template').find('.error_message').html("Upload failed, kindly re-upload file.<br/>Reason:" + errorThrown);
                        }
                    });



                    var _next = $(".fund-trn-file-template .select-list .upload-btn").data("link");

                    //setTimeout(function () {
                    //    $('#modal-fund-trn-multiple .form-card .form-section').removeClass("active");
                    //    $('#modal-fund-trn-multiple .form-card .form-section.' + _next).addClass("active");
                    //}, 2500);
                }
            } else {
                fInputEle.parents('.form-section.fund-trn-file-template').find('.error_message').text("Uploaded file is invalid, kindly upload a valid file");
            }
        
        })
    }
    

    if ($("#hasresetpin").text() == "0") {
        $('#modal-auth-generate').modal('toggle');
        setTimeout(function () {
            $('#modal-auth-generate .form-card .form-section.loading').removeClass("active");
            $('#modal-auth-generate .form-card .form-section.auth-pin').addClass("active");
        }, 800);
    }

    $("#cont .form-link-pin").click(function (e) {
       // debugger
        e.preventDefault();
        e.stopPropagation();
        $('#modal-auth-generate .form-card .form-section.auth-pin').removeClass("active");
        $('#modal-auth-generate .form-card .form-section.loading').addClass("active");
        $("#modal-auth-generate .form-card .form-section.alert.sub .respmessage").html("");
        var p1 = $("#p1").val();
        var p2 = $("#p2").val();
        var p3 = $("#p3").val();
        var p4 = $("#p4").val();
        var p5 = $("#p5").val();
        var p6 = $("#p6").val();
        var p7 = $("#p7").val();
        var p8 = $("#p8").val();
        if (p1 === p5 && p2 === p6 && p3 === p7 && p4 === p8) {
            $("#modal-auth-generate .form-card .form-section.alert.sub .errorchange").addClass("d-none");
            $("#modal-auth-generate .form-card .form-section.alert.sub .successchange").addClass("d-none");
            $("#modal-auth-generate .form-card .form-section.alert.sub .networkchange").addClass("d-none");

            $.ajax({

                url: "/Wallet/CreateAuthPin",
                type: "POST",

                data: {
                    pin: p1+p2+p3+p4,
                },

                success: function (data) {
                    if (data.result == "success") {
                        $('#modal-auth-generate .form-card .form-section.loading').removeClass("active");
                        //$(".form-section.alert.sub.message").removeClass("success");
                        $("#modal-auth-generate .form-card .form-section.alert.sub.message").removeClass("error");
                        $("#modal-auth-generate .form-card .form-section.alert.sub .d-none.successchange").removeClass("d-none");
                        $('#modal-auth-generate .form-card .form-section.alert').addClass("active success");
                    } else if (data.result == "failed") {
                        $('#modal-auth-generate .form-card .form-section.loading').removeClass("active");
                        $("#modal-auth-generate .form-card .form-section.alert.sub.message").removeClass("success");
                        //$(".form-section.alert.sub.message").removeClass("error");
                        $("#modal-auth-generate .form-card .form-section.alert.sub .respmessage").html(data.message);
                        $("#modal-auth-generate .form-card .form-section.alert.sub .d-none.errorchange").removeClass("d-none");
                        $('#modal-auth-generate .form-card .form-section.alert').addClass("active error");
                    } else if (data.result == "network") {
                        $('#modal-auth-generate .form-card .form-section.loading').removeClass("active");
                        $("#modal-auth-generate .form-card .form-section.alert.sub.success.message").removeClass("success");
                        //$(".form-section.alert.sub.success.message").removeClass("error");
                        $("#modal-auth-generate .form-card .form-section.alert.sub .d-none.networkchange").removeClass("d-none");
                        $('#modal-auth-generate .form-card .form-section.alert').addClass("active error");
                    }

                },
                error: function (xhr, textStatus, error) {
                    if (xhr.status === 401) {
                        location.reload(true);
                    }
                    $('#modal-auth-generate .form-card .form-section.loading').removeClass("active");
                    $("#modal-auth-generate .form-card .form-section.alert.sub.success.message").removeClass("success");
                    //$(".form-section.alert.sub.success.message").removeClass("error");
                    $("#modal-auth-generate .form-card .form-section.alert.sub .d-none.networkchange").removeClass("d-none");
                    $("#modal-auth-generate .form-card .form-section.alert.sub .respmessage").html("Error occured while processing your request,kindly try again.<br/>Reason: " + error);
                    $('#modal-auth-generate .form-card .form-section.alert').addClass("active error");
                }
            });
        } else if (p1 == "" || p2 == "" || p3 == "" || p4 == "" || p5 == "" || p6 == "" || p7 == "" || p8 == "") {
            $('#modal-auth-generate .form-card .form-section.loading').removeClass("active");
            $("#modal-auth-generate .form-card .form-section.alert.sub.message").removeClass("success");
            //$("#modal-auth-generate .form-card .form-section.alert.sub.message").removeClass("error");
            $("#modal-auth-generate .form-card .form-section.alert.sub .d-none.errorchange").removeClass("d-none");
            $("#modal-auth-generate .form-card .form-section.alert.sub .respmessage").html("Please fill in all the boxes to complete the required 4 numbers ");
            $('#modal-auth-generate .form-card .form-section.alert').addClass("active error");
            $('#modal-auth-generate .form-card .form-section.alert.sub .continue-alert-btn').addClass("d-none");
            $('#modal-auth-generate .form-card .form-section.alert.sub .try-pin-again').removeClass("d-none");
        }
        else {
            $('#modal-auth-generate .form-card .form-section.loading').removeClass("active");
            $("#modal-auth-generate .form-card .form-section.alert.sub.message").removeClass("success");
            //$("#modal-auth-generate .form-card .form-section.alert.sub.message").removeClass("error");
            $("#modal-auth-generate .form-card .form-section.alert.sub .d-none.errorchange").removeClass("d-none");
            $("#modal-auth-generate .form-card .form-section.alert.sub .respmessage").html("Your new pin and confirmation pin doesn't match,kindly check and try again ");
            $('#modal-auth-generate .form-card .form-section.alert').addClass("active error");
            $('#modal-auth-generate .form-card .form-section.alert.sub .continue-alert-btn').addClass("d-none");
            $('#modal-auth-generate .form-card .form-section.alert.sub .try-pin-again').removeClass("d-none");
        }
    })

    $(".modals").on("click", "#modal-auth-generate .form-card .form-section.alert.sub .try-pin-again", function (e) {

        $(this).addClass("d-none");
        $('#modal-auth-generate .form-card .form-section.alert.sub .continue-alert-btn').removeClass("d-none");
        $("#modal-auth-generate .form-card .form-section.alert.sub .respmessage").html("");
        $('#modal-auth-generate .form-card .form-section.alert').removeClass("active");
        $('#modal-auth-generate .form-card .form-section.auth-pin').addClass("active");
        $("#modal-auth-generate .form-card .form-section.alert.sub .errorchange").addClass("d-none");
    });


  //Setting Load
  setSettingActive();

  //Setting Trans PIN Modal
  $(".settings .empty-info .btn").click(function (e) {
    setTimeout(function (e) {
      $('#modal-setup-transpin .form-card .form-section').removeClass("active");
      $('#modal-setup-transpin .form-card .form-section.setting-transpin-setup').addClass("active");
    }, 2500);
  })

   



  //Setting KYC Upload
  $(".settings .docs .upload-btn").click(function (e) {
    e.preventDefault();
    var _parent = $(this).parent();
    var _file = _parent.find("input[type=file]");

    $(_file).trigger("click");
  })
  $(".settings .docs .remove-btn").click(function (e) {
    e.preventDefault();
    var _parent = $(this).parent();
    _parent.find("input[type=file]").val("");
    _parent.removeClass("attached");
  })

  $(".settings .docs .image .icon, .settings .avater .image .icon").click(function (e) {
    var _parent = $(this).parent().parent();
    var _file = _parent.find("input[type=file]");

    $(_file).trigger("click");
  })

  $(".settings .docs .item.profile-pic input, .settings .avater input").change(function (e) {
    var file = e.target.files[0];
    if (file.type.match("image.*")) {
      var _parent = $(this).parent().parent();

      var reader = new FileReader();
      reader.onload = function (_file) {
        var dataUrl = _file.target.result;

        _parent.find(".image").attr("style", "background-image: url('" + dataUrl + "')");
      }

      reader.readAsDataURL(file);
    }
  })

    $(".settings .docs .item:not(.profile-pic) input").change(function (e) {
        var file = e.target.files[0];
        if (file.type.match("application.*")) {
            var _parent = $(this).parent().parent();
            var _text = $(this).parent().find(".file");
            _text.html(file.name + " | <em>" + formatSize(file.size) + "</em>");
            _parent.addClass("attached");

        }
    });


    //General PIN Input Movement
    $('section div.form-card, .modal .modal-content, .setting-content').on('input', '.input-pin input', function (e) {
        $(this).attr("maxlength", "1");
        var _parent = $(this).parent();
        var _index = $(this).index() + 1;
        var _num = 4;
        if (_parent.hasClass("x6")) {
            _num = 6;
        }

        if ($(this).val().length === 1) {
            $(this).blur();

            if (_index < _num) {
                _parent.find("input:nth-child(" + (_index + 1) + ")").focus();
            }
        }
    });

    $('section div.form-card, .modal .modal-content .setting-content').on('keyup', '.input-pin input', function (e) {
        if (e.key.toLowerCase() === "backspace") {
            var _parent = $(this).parent();
            var _index = $(this).index() + 1;

            if ($(this).val().length === 0) {
                $(this).blur();

                if (_index > 1) {
                    _parent.find("input:nth-child(" + (_index - 1) + ")").focus();
                }
            }

        }
    });

    //Password Input Event
    $('section div.form-card, .modal .modal-content').on('input', 'form .input.password-check input[type=password]', function (e) {
        checkPasswordPolicy($(this).val(), $(this));
    });

  formatInput();



//$(document).on('show.bs.modal', '#modal-fund-trn-single', function (e) {
//    debugger
//    $("#modal-fund-trn-single .modal-content .form-card .form-section").removeClass('active');
//    //$("#modal-fund-trn-single .modal-content .form-card .form-section.fund-trn-phone").addClass('active');
//    if ($("#modal-fund-trn-single .modal-content .form-card .form-section.fund-trn-phone").get(0) != null) {
//        $("#modal-fund-trn-single .modal-content .form-card .form-section.fund-trn-phone").addClass('active');
//    } else {
//        $("#modal-fund-trn-single .modal-content .form-card .form-section.fund-trn-transpin").addClass('active');
//    }
    
//});


$('#modal-fund-trn-single').on('click', '#ContinueTrans', function (e) {
    e.preventDefault();
    e.stopPropagation();
    $('.fund-trn-phone form .multiple_trn_error').remove();
    var detailInvalid = false;
    var Amount = $('.fund-trn-phone .amtfield').val().replace(",", "");
    var DestinationPhone = $('#TransactionModel_DestinationPhone').val();
    if (!DestinationPhone || !Amount || DestinationPhone.length < 10 || Amount.length < 1) {
        detailInvalid = true;
    }
    if (parseFloat(Amount) < 100) {
        $('.fund-trn-phone form p').after('<div class="multiple_trn_error"><span style="color: #ff7070; font-weight: bold;">Amount must be at least N100</span></div>');
        //$("#modal-fund-trn-single .form-section").toggleClass('active');
        return false;
    }
    if (detailInvalid) {
        $('.fund-trn-phone form p').after('<div class="multiple_trn_error"><span style="color: #ff7070; font-weight: bold;">Phone Number / Amount is Invalid</span></div>');
        //$("#modal-fund-trn-single .form-section").toggleClass('active');
        return false;
    } 
    $("#modal-fund-trn-single .form-section").toggleClass('active');
    var clickedEle = $(this);
    var nform = clickedEle.closest('form');
    $.post(nform.attr("action"), nform.serialize(), function (data) {

        var ss = $("#modal-fund-trn-single .modal-content");
        $("#modal-fund-trn-single .modal-content").html(data);
    });
});


$('#modal-fund-trn-single').on('click', '#CompleteTransfer', function (e) {

    e.preventDefault();
    e.stopPropagation();
    var valid = true;
    $("#modal-fund-trn-single .form-section p.auth_pin_text").removeClass("errorColor");
    $("#modal-fund-trn-single .form-section .input-pin input[type='text']").each(function (e) {
        if (!$(this).val()) {
            $("#modal-fund-trn-single .form-section p.auth_pin_text").addClass("errorColor");
            valid = false;
            return false;
        }
    });
    if (valid) {
        $("#modal-fund-trn-single .form-section").toggleClass('active');
        var clickedEle = $(this);
        var nform = clickedEle.closest('form');
        $.post(nform.attr("action"), nform.serialize(), function (data) {

            var ss = $("#modal-fund-trn-single .modal-content");
            $("#modal-fund-trn-single .modal-content").html(data);

        });
    }
});



$('#modal-fund-trn-single').on('click', '#fund-trn-otptoken', function (e) {

    e.preventDefault();
    e.stopPropagation();
    var valid = true;
    $("#modal-fund-trn-single .form-section label.auth_pin_text").removeClass("errorColor");
    $("#modal-fund-trn-single .form-section .input-pin input[type='text']").each(function (e) {
        if (!$(this).val()) {
            $("#modal-fund-trn-single .form-section label.auth_pin_text").addClass("errorColor");
            valid = false;
            return false;
        }
    });
    if (valid) {
        $("#modal-fund-trn-single .form-section").toggleClass('active');
        var clickedEle = $(this);
        var nform = clickedEle.closest('form');
        $.post("Transaction/TransferOTPAuth", nform.serialize(), function (data) {

            $("#modal-fund-trn-single .modal-content").html(data);

        });

    }
});


$('#modal-fund-trn-single').on('click', '#fund-trn-transpin', function (e) {

    e.preventDefault();
    e.stopPropagation();
    var valid = true;
    $("#modal-fund-trn-single .form-section label.auth_pin_text").removeClass("errorColor");
    $("#modal-fund-trn-single .form-section .input-pin input[type='text']").each(function (e) {
        if (!$(this).val()) {
            $("#modal-fund-trn-single .form-section label.auth_pin_text").addClass("errorColor");
            valid = false;
            return false;
        }
    });
    if (valid) {
        $("#modal-fund-trn-single .form-section").toggleClass('active');
        var clickedEle = $(this);
        var nform = clickedEle.closest('form');
        $.post("Transaction/TransferTAPAuth", nform.serialize(), function (data) {

            $("#modal-fund-trn-single .modal-content").html(data);

        });
    }
});


$('#modal-fund-trn-single').on('click', '#CompleteTAPTransfer', function (e) {

    e.preventDefault();
    e.stopPropagation();
    $("#modal-fund-trn-single .form-section").toggleClass('active');
    var clickedEle = $(this);
    var nform = clickedEle.closest('form');
    $.post(nform.attr("action"), nform.serialize(), function (data) {
     
        var ss = $("#modal-fund-trn-single .modal-content");
        $("#modal-fund-trn-single .modal-content").html(data);

    });
});


$('#modal-fund-trn-single').on('click', '#CompleteOTPTransfer', function (e) {

    e.preventDefault();
    e.stopPropagation();
    $("#modal-fund-trn-single .form-section").toggleClass('active');
    var clickedEle = $(this);
    var nform = clickedEle.closest('form');
    $.post(nform.attr("action"), nform.serialize(), function (data) {
    
        var ss = $("#modal-fund-trn-single .modal-content");
        $("#modal-fund-trn-single .modal-content").html(data);

    });
});


$('#modal-fund-wallet').on('click', '#FundButton', function (e) {
    $('#modal-fund-wallet .form-card .form-section.loading').addClass("active");
    $.ajax({
        type: "GET",
        url: "/Wallet/QueryCards",
        async: false,
        success: function (response) {
            $("#modal-fund-wallet .modal-content").html(response);
            $(".form-section.wallet-amount .fund_amount.currency").each(function (index) {
                $(this).attr("id", "cleave-wallet-amount-" + index);
                var cleave = new Cleave("#cleave-wallet-amount-" + index, {
                    numeral: true,
                    numeralThousandsGroupStyle: "thousand",
                    numeralPositiveOnly: true
                });
            });
            $(".form-section.card-info input.credit-card").each(function (index) {
                $(this).attr("id", "cleave-card-info-card-" + index);
                var cleave = new Cleave("#cleave-card-info-card-" + index, {
                    blocks: [4, 4, 4, 4, 3],
                    numericOnly: true,
                });
            });
            //Expiration
            $(".form-section.card-info input.expire").each(function (index) {
                $(this).attr("id", "cleave-card-info-expire-" + index);
                var cleave = new Cleave("#cleave-card-info-expire-" + index, {
                    date: true,
                    datePattern: ["m", "Y"]
                });
            });
            //CVV 
            $(".form-section.card-info  input.cvv").each(function (index) {
                $(this).attr("id", "cleave-card-info-cvv-" + index);
                var cleave = new Cleave("#cleave-card-info-cvv-" + index, {
                    numeral: true,
                    numeralThousandsGroupStyle: "none",
                    numeralPositiveOnly: true,
                    numeralDecimalScale: 0
                });
            });
        }
    });
    
});

    $('#modal-fund-wallet').on('click', '#AddCardInline', function (e) {
        e.preventDefault();
        e.stopPropagation();
        var clickedEle = $(this);
        $(this).removeClass('active');
        var nform = clickedEle.closest('form');
        $('#modal-fund-wallet .error_message').text("");
        var amount_string = nform.find('.fund_amount').val();
        amount_string = amount_string.replace(/[^\d\.\-]/g, ""); 
        //debugger
        var nAmount = parseFloat(amount_string);
        if (!isNaN(nAmount) && nAmount >= MinFundAmount) {
            $('#modal-fund-wallet .form-card .form-section').removeClass("active");
            $('#modal-fund-wallet .form-card .form-section.card-info').addClass("active");
        } else {
            // debugger
            nform.find('.error_message').text("Enter a valid amount, amount must be N100 or more.");
            //$("#modal-fund-wallet .form-section").toggleClass('active');
        }
        
    });
    

$('#modal-fund-wallet .modal-content').on('click','.select-list .item', function (e) {

  
    //localStorage.removeItem('Card');
    $('.modals .modal-dialog .form-card .select-list .item').removeClass('active');
    $(this).addClass('active');
    //var CardId = $(this).find('.Id').val();

    //localStorage.setItem('Card', CardId);

    
});


$('#modal-fund-wallet').on('click', '#GoToPinButton', function (e) {

    e.preventDefault();
    e.stopPropagation();
    $("#modal-fund-wallet .form-section").toggleClass('active');
    var clickedEle = $(this);
    var nform = clickedEle.closest('form');
    $.post(nform.attr("action"), nform.serialize(), function (data) {
    
        $("#modal-fund-wallet .modal-content").html(data);

    });
});


$('#modal-fund-wallet').on('click', '#FundWalletButton', function (e) {

    e.preventDefault();
    e.stopPropagation();
    if ($('.modals .modal-dialog .form-card .select-list .item').hasClass('active')) {
        //var id = localStorage.getItem('Card');
        var id = $('.modals .modal-dialog .form-card .select-list .item.active').find('.Id').val();

        $("#modal-fund-wallet .form-section").removeClass('active');
        $("#modal-fund-wallet .form-section.loading").addClass('active');
        var clickedEle = $(this);
        var nform = clickedEle.closest('form');
        nform.find('.error_message').text("");
        var amount_string = nform.find('.fund_amount').val();
        amount_string = amount_string.replace(/[^\d\.\-]/g, ""); 
        debugger
        var nAmount = parseFloat(amount_string);
        if (!isNaN(nAmount) && nAmount >= MinFundAmount) {
            $.post(nform.attr("action") + "/" + id, nform.serialize(), function (data) {
                debugger
                $("#modal-fund-wallet .modal-content").html(data);

            }).fail(function () {
                debugger
                $("#modal-fund-wallet .form-section").removeClass('active');
                $("#modal-fund-wallet .form-section.wallet-amount").addClass('active');
            });
        } else {
            debugger
            nform.find('.error_message').text("Enter a valid amount, amount must be N100 or more.");
            $("#modal-fund-wallet .form-section").removeClass('active');
            $("#modal-fund-wallet .form-section.wallet-amount").addClass('active');
        }
    } else {
        $('#modal-fund-wallet .form-card .form-section .error_message').text("You must select a card");
    }
});


    $("#modal-fund-wallet").on('keyup', '.form-section.wallet-amount .fund_amount', function (e) {
        var charge_string = $('.form-section.wallet-amount .cc_charge').html();
        charge_string = charge_string.replace(/[^\d\.\-]/g, ""); 
        var charge = parseFloat(charge_string);
        var amount_string = $(this).val();
        amount_string = amount_string.replace(/[^\d\.\-]/g, "");
        var amount = parseFloat(amount_string);
        if (!isNaN(charge) && !isNaN(amount)) {
            var total = amount + charge;
            $('.total_amount .total_charge').html(total.toString().replace(/,/g, "").replace(/\B(?=(\d{3})+(?!\d))/g, ","));
        }
    });

$('#modal-add-card').on('click', '#AddCardButton', function (e) {

    e.preventDefault();
    e.stopPropagation();
    $("#modal-add-card .form-section").toggleClass('active');
    var clickedEle = $(this);
    var nform = clickedEle.closest('form');
    $.post(nform.attr("action"), nform.serialize(), function (data) {
       
        $("#modal-add-card .modal-content").html(data);

    });
});


$('#modal-add-card').on('click', '#CardPinButton', function (e) {

    e.preventDefault();
    e.stopPropagation();
    $("#modal-add-card .form-section").toggleClass('active');
    var clickedEle = $(this);
    var nform = clickedEle.closest('form');
    $.post(nform.attr("action"), nform.serialize(), function (data) {
      
        $("#modal-add-card .modal-content").html(data);

    });
});


$('#modal-setup-transpin').on('click', '#2FAButton', function (e) {

    e.preventDefault();
    e.stopPropagation();
    $("#modal-setup-transpin .form-section").toggleClass('active');
    var clickedEle = $(this);
    var nform = clickedEle.closest('form');
    $.post(nform.attr("action"), nform.serialize(), function (data) {
     
        $("#modal-setup-transpin .modal-content").html(data);

    });
});






//Registration

$('#Reg-form-card').on('click', '#PhoneBvnButton', function (e) {

    e.preventDefault();
    e.stopPropagation();
    $("#Reg-form-card .form-one").toggleClass('active');
    var clickedEle = $(this);
    var nform = clickedEle.closest('form');
    $.post(nform.attr("action"), nform.serialize(), function (data) {
    
        $("#Reg-form-card").html(data);
        formatInput();

    });
});

$('#Reg-form-card').on('click', '#ValidatePhoneButton', function (e) {

    e.preventDefault();
    e.stopPropagation();
    $("#Reg-form-card .form-section").toggleClass('active');
    var clickedEle = $(this);
    var nform = clickedEle.closest('form');
    $.post(nform.attr("action"), nform.serialize(), function (data) {
   
        $("#Reg-form-card").html(data);
        formatInput();

    });
});


$('#Reg-form-card').on('click', '#ResendCodeButton', function (e) {
  //  debugger
    e.preventDefault();
    e.stopPropagation();
    $("#Reg-form-card .form-section").toggleClass('active');
    var clickedEle = $(this);
    var nform = clickedEle.closest('form');
   
    $.post("/Auth/ResendCode", nform.serialize(), function (data) {
      //  debugger
        $("#Reg-form-card").html(data);

        $("#otp1 input[type='text']").val('');
        //$("#otp2").val("") ;
        //$("#otp3").val("") ;
        //$("#otp4").val("") ;
        //$("#otp5").val("") ;
        //$("#otp6").val("");
    });
});


$('#Reg-form-card').on('click', '#VerifyPinButton', function (e) {

    e.preventDefault();
    e.stopPropagation();
    $("#Reg-form-card .form-section").toggleClass('active');
    var clickedEle = $(this);
    var nform = clickedEle.closest('form');
    $.post(nform.attr("action"), nform.serialize(), function (data) {
      
        $("#Reg-form-card").html(data);

    });
});


$('#Reg-form-card').on('click', '#SignUpButton', function (e) {

    e.preventDefault();
    e.stopPropagation();
    $("#Reg-form-card .form-section").toggleClass('active');
    var clickedEle = $(this);
    var nform = clickedEle.closest('form');
    $.post(nform.attr("action"), nform.serialize(), function (data) {
      
        $("#Reg-form-card").html(data);

    });
});

$('#Reg-form-card').on('click', '#EXSignUpButton', function (e) {

    e.preventDefault();
    e.stopPropagation();
    $("#Reg-form-card .form-section").toggleClass('active');
    var clickedEle = $(this);
    var nform = clickedEle.closest('form');
    $.post(nform.attr("action"), nform.serialize(), function (data) {
     
        $("#Reg-form-card").html(data);

    });
});




//Password Reset
$('#Reg-form-card').on('click', '#ResetPassButton', function (e) {

    e.preventDefault();
    e.stopPropagation();
    $("#Reg-form-card .form-two").toggleClass('active');
    var clickedEle = $(this);
    var nform = clickedEle.closest('form');
    $.post(nform.attr("action"), nform.serialize(), function (data) {
       
        $("#Reg-form-card").html(data);

    });
});

$('#Reg-form-card').on('click', '#ValidateRCodeButton', function (e) {

    e.preventDefault();
    e.stopPropagation();
    $("#Reg-form-card .form-section").toggleClass('active');
    var clickedEle = $(this);
    var nform = clickedEle.closest('form');
    $.post(nform.attr("action"), nform.serialize(), function (data) {
      
        $("#Reg-form-card").html(data);

    });
});


$('#Reg-form-card').on('click', '#ResetButton', function (e) {

    e.preventDefault();
    e.stopPropagation();
    $("#Reg-form-card .form-section").toggleClass('active');
    var clickedEle = $(this);
    var nform = clickedEle.closest('form');
    $.post(nform.attr("action"), nform.serialize(), function (data) {
     
        $("#Reg-form-card").html(data);

    });
});

$('#Reg-form-card').on('click', '#ResendRCodeButton', function (e) {
    //debugger
    e.preventDefault();
    e.stopPropagation();
  
    $("#Reg-form-card .form-section").toggleClass('active');
    var clickedEle = $(this);
    var nform = clickedEle.closest('form');
    var i = nform.serialize();
    $.post("/Auth/ResendResetCode", nform.serialize(), function (data) {
   
        $("#Reg-form-card").html(data);
        $(".otpass input[type='text']").val('');
       
        

    });
});


//Multiple Recipient
$('#modal-fund-trn-multiple').on('click', '#fund-trn-add-recipient', function (e) {
    e.preventDefault();
    e.stopPropagation();
    $("#modal-fund-trn-multiple  .f-two").toggleClass('active');
    $("#modal-fund-trn-multiple  .f-three").toggleClass('active');
});


$('#modal-fund-trn-multiple').on('click', '#fund-trn-file-upload', function (e) {
    e.preventDefault();
    e.stopPropagation();
    $("#modal-fund-trn-multiple  .f-two").toggleClass('active');
    $("#modal-fund-trn-multiple  .f-five").toggleClass('active');
});


//$('#recipient-list-id').on('click', '.delete-beneficiary', function (e) {
//    $(this).parents('.item').remove();

//    return false;
//});

//$('#recipient-list-id').on('click', '.delete-beneficiary', function (e) {
//    debugger
//    let Phone = $('#PhoneField').val();
//    let DestinationPhone = $(this).parents('.item').find('.phone_number_tfr').text();
//    let itemsArray = localStorage.getItem(Phone) ? JSON.parse(localStorage.getItem(Phone)) : [];
//    debugger
//    for (let i = itemsArray.length - 1; i >= 0; i--) {
//        if (itemsArray[i].DestinationPhone == DestinationPhone) {
//            itemsArray.splice(i, 1);
//        }
//    }

//    localStorage.setItem(Phone, JSON.stringify(itemsArray));
//    $(this).parents('.item').remove();
//    return false;
//});
$('#recipient-list-id').on('click', '.delete-beneficiary', function (e) {
    let Phone = $('#PhoneField').val();
    let total = 0;
    let DestinationPhone = $(this).parents('.item').find('.phone_number_tfr').text();
    let itemsArray = localStorage.getItem(Phone) ? JSON.parse(localStorage.getItem(Phone)) : [];

    for (let i = itemsArray.length - 1; i >= 0; i--) {
        if (itemsArray[i].DestinationPhone == DestinationPhone) {
            itemsArray.splice(i, 1);
        } else {
            total += parseFloat(itemsArray[i].Amount);
        }
    }
    $('#recipient-list-id div.bottom .sum').html("Total: <strong>&#8358;" + total + "</strong>");
    $('#recipient-list-id .count').html(itemsArray.length);
    localStorage.setItem(Phone, JSON.stringify(itemsArray));
    $(this).parents('.item').remove();
    return false;
});

$('#recipient-list-id').on('click', '.add-another', function (e) {
    $("#modal-fund-trn-multiple .f-three").toggleClass('active');
    $("#modal-fund-trn-multiple .f-four").toggleClass('active');
});



$('#modal-fund-trn-multiple').on('click', '#RecipientListButton', function (e) {
 
    e.preventDefault();
    e.stopPropagation();
    $("#modal-fund-trn-multiple .f-one").toggleClass('active');
    $("#modal-fund-trn-multiple .f-four").toggleClass('active');
    var clickedEle = $(this);
    var nform = clickedEle.closest('form');
    $.post(nform.attr("action"), nform.serialize(), function (data) {
    
        $("#modal-fund-trn-multiple .modal-content").html(data);
    });
});



$('#modal-fund-trn-multiple').on('click', '#MAddRecipientButton', function (e) {
     
    e.preventDefault();
    e.stopPropagation();
    $('.fund-trn-add-recipient form .multiple_trn_error').remove();
    $("#modal-fund-trn-multiple .f-three, #modal-fund-trn-multiple .f-one").toggleClass('active');
    //$("#modal-fund-trn-multiple .f-one").toggleClass('active');
    var numberExists = false;
    var detailInvalid = false;
    var Phone = $('#PhoneField').val();
    var Amount = $('.fund-trn-add-recipient .amtfield').val().replace(",", "");
    var DestinationPhone = $('#DestPhoneField').val();

    if (!DestinationPhone || !Amount || DestinationPhone.length < 10 || Amount.length < 1) {
        detailInvalid = true;
    }
    if (parseFloat(Amount) < 100) {
        $('.fund-trn-add-recipient form p').after('<div class="multiple_trn_error"><span style="color: #ff7070; font-weight: bold;">Amount must be at least N100</span></div>');
        $("#modal-fund-trn-multiple .f-three, #modal-fund-trn-multiple .f-one").toggleClass('active');
        return false;
    }
    if (detailInvalid) {
        $('.fund-trn-add-recipient form p').after('<div class="multiple_trn_error"><span style="color: #ff7070; font-weight: bold;">Phone Number / Amount is Invalid</span></div>');
        $("#modal-fund-trn-multiple .f-three, #modal-fund-trn-multiple .f-one").toggleClass('active');
        return false;
    }    
    
    let itemsArray = localStorage.getItem(Phone) ? JSON.parse(localStorage.getItem(Phone)) : [];

    


    for (var item of itemsArray) {

        if (item.DestinationPhone === DestinationPhone) {

            numberExists = true;
            break;
        }
    }


    if (numberExists) {
        $('.fund-trn-add-recipient form p').after('<div class="multiple_trn_error"><span style="color: #ff7070; font-weight: bold;">Phone number already in the beneficiary list</span></div>');
        $("#modal-fund-trn-multiple .f-three, #modal-fund-trn-multiple .f-one").toggleClass('active');
        return false;
    }    


    var Name = "UnKnown Recipient";


    $.ajax({
        type: "GET",
        url: "/Transaction/QueryRecipient",
        async: false,
        data: {DestinationPhone},
        success: function (response) {

            Name = response;
        }
    });

    var d = new Object();
    d.Amount = Amount;
    d.DestinationPhone = DestinationPhone;
    d.Name = Name;
    


    itemsArray.push(d);
    localStorage.setItem(Phone, JSON.stringify(itemsArray));
    var data = JSON.parse(localStorage.getItem(Phone));

    $('#DestPhoneField').val("");
    $('#AmtField').val("");
    var total = 0;
    $('#recipient-list-id .item').remove();
    data.forEach(item => {

        var nextId = data.indexOf(item);

        var gg = ` <div class="item">
                                    <div class="avater">
                                        <img src="/assets/img/png/avatar.png" alt="">
                                        <p>
                                            <strong>${item.Name}</strong>
                                           <span class="phone_number_tfr">${item.DestinationPhone}</span>
                                        </p>
                                    </div>
             <input class="form-control"  id="rows_${nextId}_Name" name="Recipients[${nextId}].DestinationPhone" type="hidden" value="${item.DestinationPhone}">
             <input class="form-control"  id="rows_${nextId}_Name" name="Recipients[${nextId}].Amount" type="hidden" value="${item.Amount}">
                                    <strong class="sum">&#8358;${parseFloat(item.Amount).toLocaleString()}</strong>
                                    <a class="btn btn-link delete-beneficiary">
                                        <i class="icon auto">
                                            <svg width="12" height="16" viewBox="0 0 12 16" fill="none"
                                                 xmlns="http://www.w3.org/2000/svg">
                                                <path d="M0.999349 13.8333C0.999349 14.75 1.74935 15.5 2.66602 15.5H9.33268C10.2494 15.5 10.9994 14.75 10.9994 13.8333V3.83333H0.999349V13.8333ZM3.04935 7.9L4.22435 6.725L5.99935 8.49167L7.76602 6.725L8.94102 7.9L7.17435 9.66667L8.94102 11.4333L7.76602 12.6083L5.99935 10.8417L4.23268 12.6083L3.05768 11.4333L4.82435 9.66667L3.04935 7.9ZM8.91602 1.33333L8.08268 0.5H3.91602L3.08268 1.33333H0.166016V3H11.8327V1.33333H8.91602Z"
                                                      fill="#FF7070" />
                                            </svg>
                                        </i>
                                    </a>
                                </div>`;

    
        $('#recipient-list-id div.bottom').before(gg);
        total += parseFloat(item.Amount);
    });

    $('#recipient-list-id div.bottom .sum').html("Total: <strong>&#8358;" + total.toLocaleString()+"</strong>");
    $('#recipient-list-id .count').html(data.length);

    //when lists is equal to 10, hide the add another button

    if (data.length > 10) {
        $('#recipient-list-id div.bottom .add-another').hide();
    };
        $('#RecipientListButton').removeClass('d-none');
   
  
     $("#modal-fund-trn-multiple .f-one").toggleClass('active');
    $("#modal-fund-trn-multiple .f-four").toggleClass('active');
});




$('#modal-fund-trn-multiple').on('click', '#MultiOTPButton', function (e) {

    e.preventDefault();
    e.stopPropagation();
    $(this).parents(".m-content-wrap").find(".form-section.fund-trn-authpin label.auth_pin_text").removeClass("errorColor");
    var valid = true;
    $(this).parents(".m-content-wrap").find(".form-section.fund-trn-authpin .input-pin input[type='text']").each(function (e) {
        if (!$(this).val()) {
            $(this).parents(".m-content-wrap").find(".form-section.fund-trn-authpin label.auth_pin_text").addClass("errorColor");
            valid = false;
            return false;
        }
    });
    if (valid) {
        $("#modal-fund-trn-multiple .form-section").toggleClass('active');
        var clickedEle = $(this);
        var nform = clickedEle.closest('form');
        $.post("Transaction/MultipleTransferOTPAuth", nform.serialize(), function (data) {
            $("#modal-fund-trn-multiple .modal-content").html(data);
        });
    }
 });



$('#modal-fund-trn-multiple').on('click', '#MultiTAPButton', function (e) {
    e.preventDefault();
    e.stopPropagation();
    $(this).parents(".m-content-wrap").find(".form-section.fund-trn-authpin label.auth_pin_text").removeClass("errorColor");
    var valid = true;
    $(this).parents(".m-content-wrap").find(".form-section.fund-trn-authpin .input-pin input[type='text']").each(function (e) {
        if (!$(this).val()) {
            $(this).parents(".m-content-wrap").find(".form-section.fund-trn-authpin label.auth_pin_text").addClass("errorColor");
            valid = false;
            return false;
        }
    });
    if (valid) {
        $("#modal-fund-trn-multiple .form-section").toggleClass('active');
        var clickedEle = $(this);
        var nform = clickedEle.closest('form');
        $.post("Transaction/MultipleTransferTAPAuth", nform.serialize(), function (data) {
            $("#modal-fund-trn-multiple .modal-content").html(data);
        });
    }
});




$('#modal-fund-trn-multiple').on('click', '#CompleteTAPTransfer', function (e) {

    e.preventDefault();
    e.stopPropagation();
    $("#modal-fund-trn-multiple .form-section").toggleClass('active');
    localStorage.clear();
    var clickedEle = $(this);
    var nform = clickedEle.closest('form');
    $.post(nform.attr("action"), nform.serialize(), function (data) {
      
        $("#modal-fund-trn-multiple .modal-content").html(data);
    });
});


$('#modal-fund-trn-multiple').on('click', '#CompleteOTPTransfer', function (e) {
  
    e.preventDefault();
    e.stopPropagation();
    $("#modal-fund-trn-multiple .form-section").toggleClass('active');
    localStorage.clear();
    var clickedEle = $(this);
    var nform = clickedEle.closest('form');
    $.post(nform.attr("action"), nform.serialize(), function (data) {

        $("#modal-fund-trn-multiple .modal-content").html(data);

    });
});



$('#modal-fund-trn-multiple').on('click', '#CompletePINTransfer', function (e) {

    e.preventDefault();
    e.stopPropagation();
  
    $("#modal-fund-trn-multiple .form-section").toggleClass('active');
    localStorage.clear();
    var clickedEle = $(this);
    var nform = clickedEle.closest('form');
    $.post(nform.attr("action"), nform.serialize(), function (data) {
      
        $("#modal-fund-trn-multiple .modal-content").html(data);
    });
});

//Start Code to repeat transaction

$('.content.history').on('click', '.repeat_history_btn', function (e) {

    //debugger
    e.preventDefault();
    e.stopPropagation();

    var transId = $(this).data("itemid");
    $.ajax({
        type: 'GET',
        url: '/Transaction/RepeatTransaction',
        cache: false,
        data: {
            Id: transId,
        },
        success: function (data) {
            //debugger
            if (data.amount == null) {
                $("#modal-fund-trn-single").modal('show');
                $("#modal-fund-trn-single .modal-content").html(data);
            } else {
                $("#modal-fund-trn-single").modal('hide');
                $("#modal-fund-trn-single").removeClass('show');
                $("#modal-fund-wallet").modal('show');
                $('#modal-fund-wallet .form-card .form-section.loading').addClass("active");
                $.ajax({
                    type: "GET",
                    url: "/Wallet/QueryCards",
                    async: false,
                    success: function (response) {
                       // 
                        $("#modal-fund-wallet .modal-content").html(response);
                        $("#modal-fund-wallet .modal-content .form-section.wallet-amount .fund_amount").val(data.amount);
                        $("#modal-fund-wallet .form-section.wallet-amount .fund_amount").keyup();
                        $(".form-section.wallet-amount .fund_amount.currency").each(function (index) {
                            $(this).attr("id", "cleave-wallet-amount-" + index);
                            var cleave = new Cleave("#cleave-wallet-amount-" + index, {
                                numeral: true,
                                numeralThousandsGroupStyle: "thousand",
                                numeralPositiveOnly: true
                            });
                        });
                        $(".form-section.card-info input.credit-card").each(function (index) {
                            $(this).attr("id", "cleave-card-info-card-" + index);
                            var cleave = new Cleave("#cleave-card-info-card-" + index, {
                                blocks: [4, 4, 4, 4, 3],
                                numericOnly: true,
                            });
                        });
                        //Expiration
                        $(".form-section.card-info input.expire").each(function (index) {
                            $(this).attr("id", "cleave-card-info-expire-" + index);
                            var cleave = new Cleave("#cleave-card-info-expire-" + index, {
                                date: true,
                                datePattern: ["m", "Y"]
                            });
                        });
                        //CVV 
                        $(".form-section.card-info input.cvv").each(function (index) {
                            $(this).attr("id", "cleave-card-info-cvv-" + index);
                            var cleave = new Cleave("#cleave-card-info-cvv-" + index, {
                                numeral: true,
                                numeralThousandsGroupStyle: "none",
                                numeralPositiveOnly: true,
                                numeralDecimalScale: 0
                            });
                        });
                        /*if (data.cardId) {
                            $("#modal-fund-wallet .modal-content .form-card .form-section.wallet-amount .select-list .item input[value='" + data.cardId + "']").closest('.item').addClass('active');
                        }*/
                    }
                    
                });
            }
        }
    });
});
//End Code to repeat transaction
var PassportURL = $(".passporturl").val();

$("#pp").attr("style", "background-image: url('" + PassportURL + "')");

    $('#modal-fund-wallet').on('click', '#GoBackWalletButton', function (e) {

    $('#modal-fund-wallet .form-card .form-section').removeClass("active");
    $('#modal-fund-wallet .form-card .form-section.loading').addClass("active");
    

    $.get("/Transaction/GoBackWallet", function (data) {
        $("#modal-fund-wallet .modal-content").html(data);
    });
});
$('#modal-fund-trn-single').on('click', '#GoBackFundButton', function (e) {
    $('#modal-fund-trn-single .form-card .form-section.loading').addClass("active");
    $.get("/Transaction/GoBackFund", function (data) {
        $("#modal-fund-trn-single .modal-content").html(data);

    }).always(function () {
        var cleave = new Cleave("#TransactionModel_Amount", {
            numeral: true,
            numeralThousandsGroupStyle: "thousand"
        });
    });
});
    $('#modal-fund-trn-multiple').on('click', '#GoBackUploadButton', function (e) {
        //debugger
        $('#modal-fund-trn-multiple .form-card .form-section.fund-trn-transpin').removeClass("active");
        $('#modal-fund-trn-multiple .form-card .form-section.loading').addClass("active");
       
        $.get("/Transaction/GoBackUpload", function (data) {
       // debugger
        $("#modal-fund-trn-multiple .modal-content").html(data);

    //}).always(function () {
    //    var cleave = new Cleave("#TransactionModel_Amount", {
    //        numeral: true,
    //        numeralThousandsGroupStyle: "thousand"
    //    });
    });
});

//$("#LoginButtonId").click(function (e) {
//    debugger
//    $('.auth .card .login').removeClass("active");
//    $('.auth .card .loading').addClass("active");
//})

$("#LoginButtonId").click(function (e) {
    $('.auth .form-card .form-section.login').removeClass('active');
    $('.auth .form-card .form-section.loading').addClass('active');
})

$('#Reg-form-card').on('click', '.reg-success-btn', function (e) {
   // debugger
    $('#Reg-form-card-Resp').removeClass('active');
    $('.auth .form-card .form-section.loading').addClass('active');
});

$('#setting-auth-pin').on('submit', '#setauthpin', function (e) {
   // debugger;
    var p1 = $("#np1").val();
    var p2 = $("#np2").val();
    var p3 = $("#np3").val();
    var p4 = $("#np4").val();
    var p5 = $("#cp1").val();
    var p6 = $("#cp2").val();
    var p7 = $("#cp3").val();
    var p8 = $("#cp4").val();
    var letters = /^[a-zA-Z]+$/
    if (p1 == "" || p2 == "" || p3 == "" || p4 == "" || p5 == "" || p6 == "" || p7 == "" || p8 == "") {
        e.preventDefault();
        $(".invindicator").text("Four Numbers are required please fill all the boxes");
    } else if (p1 != p5 || p2 != p6 || p3 != p7 || p4 != p8) {

        e.preventDefault();
        $(".invindicator").text("New Pin and Comfirmation Pin doesn't match");

    } else if (p1.match(letters) || p2.match(letters) || p3.match(letters) || p4.match(letters) || p5.match(letters) || p6.match(letters) || p7.match(letters) || p8.match(letters)) {
        e.preventDefault();
        $(".invindicator").text("Please use numbers only");
    } else {
        $(".invindicator").text("");
    }

});

$('#setting-transaction-pin').on('submit', '#settranspin', function (e) {
   // debugger;
    var p1 = $("#np1").val();
    var p2 = $("#np2").val();
    var p3 = $("#np3").val();
    var p4 = $("#np4").val();
    var p5 = $("#cp1").val();
    var p6 = $("#cp2").val();
    var p7 = $("#cp3").val();
    var p8 = $("#cp4").val();
    var letters = /^[a-zA-Z]+$/
    if (p1 == "" || p2 == "" || p3 == "" || p4 == "" || p5 == "" || p6 == "" || p7 == "" || p8 == "") {
        e.preventDefault();
        $(".invindicator").text("Four Numbers are required please fill all the boxes");
    } else if (p1 != p5 || p2 != p6 || p3 != p7 || p4 != p8) {

        e.preventDefault();
        $(".invindicator").text("New Pin and Comfirmation Pin doesn't match");

    } else if (p1.match(letters) || p2.match(letters) || p3.match(letters) || p4.match(letters) || p5.match(letters) || p6.match(letters) || p7.match(letters) || p8.match(letters)) {
        e.preventDefault();
        $(".invindicator").text("Please use numbers only");
    } else {
        $(".invindicator").text("");
    }

});
$('#setting-transpin-setup').on('submit', '#newusertranssetup', function (e) {
   // debugger;
    var p1 = $("#nnp1").val();
    var p2 = $("#nnp2").val();
    var p3 = $("#nnp3").val();
    var p4 = $("#nnp4").val();
    var p5 = $("#ncp1").val();
    var p6 = $("#ncp2").val();
    var p7 = $("#ncp3").val();
    var p8 = $("#ncp4").val();
    var letters = /^[a-zA-Z]+$/
    if (p1 == "" || p2 == "" || p3 == "" || p4 == "" || p5 == "" || p6 == "" || p7 == "" || p8 == "") {
        e.preventDefault();
        $(".invindicator2").text("Four Numbers are required please fill all the boxes");
    } else if (p1 != p5 || p2 != p6 || p3 != p7 || p4 != p8) {

        e.preventDefault();
        $(".invindicator2").text("New Pin and Comfirmation Pin doesn't match");

    } else if (p1.match(letters) || p2.match(letters) || p3.match(letters) || p4.match(letters) || p5.match(letters) || p6.match(letters) || p7.match(letters) || p8.match(letters)) {
        e.preventDefault();
        $(".invindicator2").text("Please use numbers only");
    } else {
        $(".invindicator2").text("");
    }

    });
});

function formatSize(byte) {
  if (byte > 0 && byte < 1000) {
    return byte + "Byte";
  }
  else if (byte >= 1000 && byte < 1000000) {
    return byte / 1000 + "kb";
  }
  else if (byte >= 1000000) {
    return byte / 1000000 + "mb";
  }
  else {
    return "";
  }
}

function getUrlVars() {
  var vars = [], hash;
  var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
  for (var i = 0; i < hashes.length; i++) {
    hash = hashes[i].split('=');
    vars.push(hash[0]);
    vars[hash[0]] = hash[1];
  }
  return vars;
}

function setSettingActive() {
    
  //Load Set Active Form
  var _activePage = getUrlVars()['p'];
  if (_activePage) {
    //Set Nav Active
    $(".settings .category-nav a").removeClass("active");
    $(".settings .category-nav a").each(function (e) {
      if ($(this).attr("href").includes(_activePage)) {
        $(this).addClass("active");
        return;
      }
    })

    //Set Page Active
    $(".settings .setting-content").hide();
    $(".settings .setting-sect").removeClass("active");
      setTimeout(function () {
         // debugger
      $(".settings .setting-sect#setting-" + _activePage).addClass("active");
      $(".settings .loading").hide();
      $(".settings .setting-content").show();
    }, 2000)

    //Scroll to Tab 
    if ($(window).width() <= mPoint) {
      var _left = $(".settings .category-nav a.active").offset().left - 45;
      $(".settings .category-nav-wrap").animate({
        scrollLeft: _left
      });
    }
  }
  else {
    $(".settings .setting-content").hide();
    $(".settings .setting-sect").removeClass("active");
    setTimeout(function () {
      $(".settings .setting-sect:first-child").addClass("active");
      $(".settings .loading").hide();
      $(".settings .setting-content").show();
    }, 2000)
  }
}

function setFormPosition() {
  if ($(window).width() > mPoint && $(".page > header .links").length > 0) {
    var left = $(".page > header .container").width();

    console.log($(window).width(), left);
    $(".home .auth").css("right", ($(window).width() - left) / 2);
  }
}

function setBgPosition() {
  if ($(window).width() > mPoint && $(".page > header .links").length > 0) {
    var left = $(".page > header .logo").offset().left;
    $("section.image .cover").css("width", left);
  }
}

//function loadCharts() {

//    if ($(".overview .usage-card").length > 0) {

//        var quantity;

//        $.ajax({
//            type: "GET",
//            url: "/Home/GetDailyChatData",
//            async: false,
//            success: function (response) {

//                quantity = response.quantity;
//            }
            
//        });
 

//        if (quantity[0] === 0 && quantity[1] === 0 ) {
          
//          $('.overview .usage-card').html('<h6>No Transaction Data</h6>');
//      }
//      else {
          

//          //Globals
//          Chart.defaults.global.defaultFontFamily = 'Muli';
//          var _opt = {
//              responsive: true,
//              maintainAspectRatio: true,
//              cutoutPercentage: 25,
//              legend: {
//                  display: false
//              },
//              title: {
//                  display: false,
//              },
//          }
//          //Pie
//          new Chart(document.getElementById("usage-doughnut-ct"), {
//              type: 'doughnut',
//              data: {
//                  labels: ["Fund Transfer", "Fund Wallet"],//, "Bills Payment"],
//                  datasets: [
//                      {
//                          label: "Transactions",
//                          backgroundColor: ["#6AC895", "#FF7070"],//, "#FBB700"],
//                          data: quantity
//                      },
//                  ]
//              },
//              options: _opt
//          });
//      }
//  }

//}

function formatInput() {
  //Credit Cards 
  $("form input.credit-card").each(function (index) {
    $(this).attr("id", "cleave-card-" + index);
    var cleave = new Cleave("#cleave-card-" + index, {
        blocks: [4, 4, 4, 4, 3],
        numericOnly: true,
    });
  });
  //Dates
    $("form input.date").each(function (index) {
        //console.log($(this).get(0));
        $(this).attr("id", "cleave-date-" + index);
    var cleave = new Cleave("#cleave-date-" + index, {
      date: true,
      datePattern: ["d", "m", "Y"]
    });
  });
  //Expiration
  $("form input.expire").each(function (index) {
    $(this).attr("id", "cleave-expire-" + index);
    var cleave = new Cleave("#cleave-expire-" + index, {
      date: true,
      datePattern: ["m", "Y"]
    });
  });

  //Phone 
  $("form input.tel").each(function (index) {
    $(this).attr("id", "cleave-tel-" + index);
    var cleave = new Cleave("#cleave-tel-" + index, {
      blocks: [4, 3, 4],
    });
  });

  //Currency 
  $("form input.currency").each(function (index) {
    $(this).attr("id", "cleave-currency-" + index);
    var cleave = new Cleave("#cleave-currency-" + index, {
      numeral: true,
        numeralThousandsGroupStyle: "thousand",
        numeralPositiveOnly: true
    });
    });

    //CVV 
    $("form input.cvv").each(function (index) {
        $(this).attr("id", "cleave-cvv-" + index);
        var cleave = new Cleave("#cleave-cvv-" + index, {
            numeral: true,
            numeralThousandsGroupStyle: "none",
            numeralPositiveOnly: true,
            numeralDecimalScale: 0
        });
    });

}
function checkPasswordPolicy(password, input) {
    var score = 0;
    var checker = $(input).siblings(".checker");
    $(checker).find(".item").removeClass("checked");

    if (password && password.length >= 8) {
        $(checker).find(".item:nth-child(1)").addClass("checked");
        score++;
    }
    else {
        $(checker).find(".item:nth-child(1)").removeClass("checked");
        score--;
    }

    if (password && password.match(/[a-z]/)) {
        $(checker).find(".item:nth-child(2)").addClass("checked");
        score++;
    }
    else {
        $(checker).find(".item:nth-child(2)").removeClass("checked");
        score--;
    }

    if (password && password.match(/\d+/)) {
        $(checker).find(".item:nth-child(3)").addClass("checked");
        score++;
    }
    else {
        $(checker).find(".item:nth-child(3)").removeClass("checked");
        score--;
    }

    // If the password length is greater than 8 and must contain alphabets,numbers and special characters
    if (password && password.match(/.[!,@,#,$,%,^,&,*,?,_,~,-,(,)]/)) {
        $(checker).find(".item:nth-child(4)").addClass("checked");
        score++;
    }
    else {
        $(checker).find(".item:nth-child(4)").removeClass("checked");
        score--;
    }

    if (score == 4) {
        $(input).attr("data-valid", "true");
    } else {
        $(input).removeAttr("data-valid");
    }

}





//$('#create-account-profile').on('submit', '#signupsetup', function (e) {
//    debugger;
//    var p1 = $("#signupdob").val();
//    var dob= Date.parse(p1);


//    if (dob > Date.now()) {
//        e.preventDefault();
//        $(".invindicator3").text("you entered an invalid date of birth,please check and retry");
//    } 

//});

//$('section.auth').on('click', '#resend-btn', function (e) {
   
   
//});



