window.initializeGlider = (className) => {
    new Glide(className, {
        autoplay: 3000,
        bound: true,
        rewind: true,
        gap: 40,
        hoverpause: true,
        perView: 2,
        breakpoints: {
            1200:{
                perView: 3
            },
            1024: {
              perView: 2
            },
            600: {
              perView: 1
            }
          }
    }).mount()
}