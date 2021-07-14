window.initializeScroller = () => {
    var swiper = new Swiper(".swiper-container", {
        direction: "vertical",
        effect: "slide",
<<<<<<< HEAD
        grabCursor: false,
        spaceBetween: 10,
=======
        grabCursor: true,
        spaceBetween: '10',
>>>>>>> d7fa2c8db7b8f5490bccd6b8bc8387dad1319103
        loop: true,
        autoplay: {
            delay: 2500,
            disableOnInteraction: true,
        },
      });
};
