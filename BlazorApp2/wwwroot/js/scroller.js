window.initializeScroller = () => {
    var swiper = new Swiper(".swiper-container", {
        direction: "vertical",
        grabCursor: true,
        loop: true,
        autoplay: {
            delay: 2500,
            disableOnInteraction: true,
        },
      });
};
