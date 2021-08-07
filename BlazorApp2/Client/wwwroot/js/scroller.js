window.initializeScroller = () => {
    var swiper = new Swiper(".swiper-container", {
        direction: "vertical",
        effect: "slide",
        grabCursor: false,
        loop: true,
        autoplay: {
            delay: 4000,
            disableOnInteraction: true,
        },
      });
};
