
	//Parallax

$(document).on('scroll', function () {
    var scrollPosition = $(this).scrollTop();
    $('.parallax-fade-top').css({
        'top': (scrollPosition / 3) + 'px',
        'opacity': 1 - (scrollPosition / 300)
    });
});

    //Cursor

(function ($) {

	document.getElementsByTagName("body")[0].addEventListener("mousemove", function (n) {
		t.style.left = n.clientX + "px",
			t.style.top = n.clientY + "px",
			e.style.left = n.clientX + "px",
			e.style.top = n.clientY + "px",
			i.style.left = n.clientX + "px",
			i.style.top = n.clientY + "px"
	});
	var t = document.getElementById("cursor"),
		e = document.getElementById("cursor2"),
		i = document.getElementById("cursor3");
	function n(t) {
		e.classList.add("hover"), i.classList.add("hover")
	}
	function s(t) {
		e.classList.remove("hover"), i.classList.remove("hover")
	}
	s();
	for (var r = document.querySelectorAll(".hover-target"), a = r.length - 1; a >= 0; a--) {
		o(r[a])
	}
	function o(t) {
		t.addEventListener("mouseover", n), t.addEventListener("mouseout", s)
	}


	//Navigation

	var app = function () {
		var body = undefined;
		var menu = undefined;
		var menuItems = undefined;
		var init = function init() {
			body = document.querySelector('body');
			menu = document.querySelector('.menu-icon');
			menuItems = document.querySelectorAll('.nav__list-item');
			applyListeners();
		};
		var applyListeners = function applyListeners() {
			menu.addEventListener('click', function () {
				return toggleClass(body, 'nav-active');
			});
		};
		var toggleClass = function toggleClass(element, stringClass) {
			if (element.classList.contains(stringClass)) element.classList.remove(stringClass); else element.classList.add(stringClass);
		};
		init();
	}();


	//Switch Light/Dark

	$("#switch").on('click', function () {
		if ($("body").hasClass("light")) {
			$("body").removeClass("light");
			$("#switch").removeClass("switched");
		}
		else {
			$("body").addClass("light");
			$("#switch").addClass("switched");
		}
	});

})(jQuery);

    //Show Selected Image

function readURL(input) {
	if (input.files && input.files[0]) {
		var reader = new FileReader();

		reader.onload = function (e) {
			$('.showImageLabel').css("display","block")
			$('#showImage').attr('src', e.target.result).width(250).height(300);
		};

		reader.readAsDataURL(input.files[0]);
	}
	else {
		$('#showImage').attr('src', "")
    }
}


$(document).ready(function () {

	$('.deletebutton').click(function () {
		$(this).closest('.book').addClass("deleteme");
	});

});