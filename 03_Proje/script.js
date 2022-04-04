$(document).ready(function () {
    $("#navbarRooter #deneme").click(function () {
        var idPosition = ($("#" + this.className)).position().top;
        var textScroll = $('#' + this.className).scrollTop();
        var totalScroll = textScroll + idPosition;
        // $(document).scrollTop(totalScroll);
        $('html, body').animate({
            scrollTop: totalScroll
        }, 500);
        
    //    $(this).classList.add("active");
        
    });

    $("#hedef").click(function(){
        $("#hedef").fadeTo(750,0.1) 
    })   
    $("#hedef").mouseleave(function(){
        $("#hedef").fadeTo(1000,0.9) 
    })


    let sliderIndex = 0;
    let allSlides = $(".slide").toArray();
    let allDots = $(".dot").toArray();

    $("#prevSlide").click(function () {
        if (sliderIndex == 0) {
            sliderIndex = allSlides.length
        }
        showSlide(--sliderIndex);
    })
    $("#nextSlide").click(function () {
        if (sliderIndex == allSlides.length - 1) {
            sliderIndex = -1;
        }
        showSlide(++sliderIndex)
    })
    $(".dot").click(function () {
        sliderIndex = $(this).index()
        showSlide(sliderIndex);
    })

    function showSlide(n) {
        for (let i = 0; i < allSlides.length; i++) {
            allSlides[i].style.display = "none";
            allDots[i].classList.remove("active");
        }

        $(".slide").eq(n).fadeTo(300, 1);
        allDots[n].classList.add("active");

    }
    showSlide(sliderIndex);
});

