(function($){

    $( document ).ready(function() {
        filter();
    });

    function filter() {
        var coll = document.getElementsByClassName("collapsible");
        var i;

        for (i = 0; i < coll.length; i++) {
            coll[i].addEventListener("click", function() {
                this.classList.toggle("active");
                var content = this.nextElementSibling;
                if (content.style.maxHeight){
                    content.style.maxHeight = null;
                    content.classList.remove("mb-3");
                } else {
                    content.style.maxHeight = "fit-content"
                    content.classList.add("mb-3");
                }
            });
        }
    }
})(jQuery);


