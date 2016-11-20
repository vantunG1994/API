$(window).ready(function(){
	mycarousel("#API",1,1,1,false,true);
});


function mycarousel(id,itemdestop,itemtable,itemmobile,dots,autoplay){
	try{
		$(id).find(".carousel").each(function(){
			var owl=$(this).find(".carousel-items").owlCarousel({
				items:1,
				loop:true,
				dots:dots,
				autoplay:autoplay,
				smartSpeed:1000,
				responsive:{
			        0:{
			            items:itemmobile,
			        },
			        768:{
			            items:itemtable,
			        },
			        1200:{
			            items:itemdestop,
			        }
			    }
			});
			$(this).find(".carouse-prev").click(function(){
				$(this).parents(".carousel").find(".owl-prev").click();
			});
			$(this).find(".carouse-next").click(function(){
				$(this).parents(".carousel").find(".owl-next").click();
			});
		});
	}
	catch(err){
		console.log(err);
	}
}