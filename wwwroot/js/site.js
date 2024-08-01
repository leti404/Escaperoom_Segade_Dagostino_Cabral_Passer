// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener('DOMContentLoaded', function () {
    const hoverElement = document.getElementById('hoverElement');
    const hoverAudio = document.getElementById('hoverAudio');

    hoverElement.addEventListener('mouseover', function () {
        hoverAudio.play();
    });

    hoverElement.addEventListener('mouseout', function () {
        hoverAudio.pause();
        hoverAudio.currentTime = 0; // Reset audio to the start
    });
});
