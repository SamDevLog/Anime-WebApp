window.initializeGlider = (className) => {
    new Glide(className, {
        autoplay: 3000,
        bound: true,
        gap: 40,
        hoverpause: true,
        perView: 2,
    }).mount()
}