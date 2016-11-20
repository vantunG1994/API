var curent = 0;
new WOW().init();
$(document).ready(function(){

	ScrollMenu();
	if($(window).width() > 767){
		$(window).on('load scroll', function(e){
			if($(window).scrollTop() > 30){
				$('.tagert-menu').addClass('blk-menu-fix');
				if($('.tagert-menu').hasClass('template-12-flag')){
					$('.tagert-menu').addClass('clor-menu-fix-12');
				}
			}else{
				$('.tagert-menu').removeClass('blk-menu-fix');
				$('.tagert-menu').removeClass('clor-menu-fix-12');
			}
		});
	}else{
		$('.tagert-menu').removeClass('blk-menu-fix');
	}
	
	//active menu on scroll 
	ScrollWindowActiveMenuTop();
	
});// end ready

	function ScrollMenu(){
	var list_ele = $('.commont-menu .js-dynamic-menu-des a');
	list_ele.click(function(){
		var target_ele = $(this).attr('href');
		var height_ele = $(target_ele).offset().top;
		var time_scroll = 0;
		if(height_ele - $(window).scrollTop() < 0){
			time_scroll = (height_ele - $(window).scrollTop()) * (-1);
		}else{
			time_scroll = height_ele - $(window).scrollTop();
		}
			$('html, body').stop().animate({
			scrollTop: $(target_ele).offset().top
			}, (height_ele <= 300) ? 900 : (time_scroll/500) * 250);
		
	});
}// end function 

// function CrollActive
function ScrollWindowActiveMenuTop(){
	var list_component = $('.js-dynamic-menu');
	var list_menu = $('.commont-menu .menu-des li');
	var index_active = 0;
	var time_run_active;
	$(window).on("load scroll",function(e){
		var pos_win = $(window).scrollTop();
		list_component.each(function(i,val){
			if(pos_win >= ($(this).offset().top - 30) && pos_win <= ($(this).height() + $(this).offset().top)){
				index_active = i;
			}
		});
		
			// forEach list menu
			list_menu.removeClass('menu__item--current').find('a').removeClass('menu__item--current');
			list_menu.eq(index_active).addClass('menu__item--current').find('a').addClass('menu__item--current');
			
		
	});// end on
}// end function 