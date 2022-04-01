$(document).ready(function(){
    $("#navbarRooter div").click(function(){
        // $(document).scrollTop(600);
        // console.log(this.id)
        let deneme = $("#"+this.className)
        $(document).scrollTop($("#"+this.className).height());

        http://www.pinusart.com/yazilar-76-jquery-menu-ile-sayfa-kaydirma-scrolling-tek-sayfa-tasarim.html
    })
})