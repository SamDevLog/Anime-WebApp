window.initializeSwiper = () => {
    var swiper = new Swiper(".swiper-container", {
        effect: "coverflow",
        grabCursor: true,
        loop: false,
        centeredSlides: true,
        slidesPerView: "auto",
        coverflowEffect: {
            rotate: 20,
            stretch: 0,
            depth: 200,
            modifier: 1,
            slideShadows: false,
        },
        autoplay: {
            delay: 2500,
            disableOnInteraction: true,
        },
    });
};
