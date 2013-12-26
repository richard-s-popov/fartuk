/* Initialize Cycle Slider */

$(document).ready(function(){
$('.cycle_slider').cycle({
		fx:     'fade',
		speed:  400,
		timeout: 4000,
		next: '.next',
		prev: '.prev',
		sync: 1,
		pause: 1,
		cleartype: true,
		pager:  '.cycle_nav',
		pagerAnchorBuilder: function(idx, slide) {
			return '<li><a href="#"></a></li>';
		}
	});
})