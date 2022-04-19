$(document).ready(function(){
    $(".menuKitap").click(function(e){
        e.preventDefault()
        $(this).children('ul').slideToggle("display");
   
    });
})
