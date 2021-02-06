
  // slider-in scale-nin artmasi

$(document).ready(function () {

        $(".slider").owlCarousel(
            {
                items: 1,
                loop: true,
                autoplay: true
            }
        );


    let count = 1;

    $(".owl-item.active")
        .children("img")
        .css({ transform: "scale(1.1)", transition: "10s" });

    //$("#carouselExampleFade").on("slide.bs.carousel", function () {
    //    if (count == 1) {
    //        $(".owl-item.active").children("img").css({ transform: "scale(1)" });

    //        $(".text h1").addClass("animate__fadeInDownBig");
    //        $(".text h2").addClass("animate__fadeInRightBig");
    //        $(".text p").addClass("animate__fadeInUpBig");

    //        setTimeout(() => {
    //            $(".owl-item")
    //                .next()
    //                .children("img")
    //                .css({ transform: "scale(1.1)", transition: "10s" });
    //        }, 1000);

    //        count = 0;
    //    } else {
    //        $(".owl-item.active").children("img").css({ transform: "scale(1)" });

    //        $(".text h1").addClass("animate__fadeInDownBig");
    //        $(".text h2").addClass("animate__fadeInRightBig");
    //        $(".text p").addClass("animate__fadeInUpBig");

    //        setTimeout(() => {
    //            $(".owl-item.active")
    //                .children("img")
    //                .css({ transform: "scale(1.1)", transition: "10s" });
    //        }, 1000);
    //        count++;
    //    }
    //});
});
