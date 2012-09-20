/**
 * Base js functions
 */

$(document).ready(function(){
    //Init jQuery Masonry layout
    init_masonry();

    //Select menu init
    $("#collapsed-navbar ."+$('body').attr('class')).attr('selected', 'selected');

    //Select menu onchange
    $("#collapsed-navbar").change(function () {
        window.location = $(this).val();
    });
});


function init_masonry(){
    var $container = $('#content');

    var gutter = 12;
    var minWidth = 150;
    $container.imagesLoaded( function(){
        $container.masonry({
            itemSelector : '.box',
            gutterWidth: gutter,
            isAnimated: true,
              columnWidth: function( containerWidth ) {
                var numOfBoxes = (containerWidth/minWidth | 0);

                var boxWidth = (((containerWidth - (numOfBoxes-1)*gutter)/numOfBoxes) | 0) ;

                if (containerWidth < minWidth) {
                    boxWidth = containerWidth;
                }

                $('.box').width(boxWidth);

                return boxWidth;
              }
        });
    });
}
