window.initializeScroller = () => {
    var swiper = new Swiper(".swiper-container", {
        direction: "vertical",
        effect: "slide",
        grabCursor: true,
        spaceBetween: '10',
        loop: true,
        autoplay: {
            delay: 2500,
            disableOnInteraction: true,
        },
      });
};
